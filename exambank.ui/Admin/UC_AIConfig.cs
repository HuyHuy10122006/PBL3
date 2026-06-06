using exambank.data;
using exambank.data.Models;
using exambank.logic;
using exambank.logic.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_AIConfig : UserControl
    {
        private AIConfigModel _currentConfig;
        private readonly DocumentService _docService = new DocumentService();

        public UC_AIConfig()
        {
            InitializeComponent();
        }

        private async void UC_AIConfig_Load(object sender, EventArgs e)
        {
            InitComboBoxData();
            await LoadConfigFromDatabaseAsync();
        }

        /// <summary>
        /// Khởi tạo dữ liệu cho ComboBox Service Provider và Model
        /// </summary>
        private void InitComboBoxData()
        {
            cbService.Items.Clear();
            cbService.Items.AddRange(new object[]
            {
                "Google Gemini",
                "OpenAI",
                "Ollama (Local)"
            });

            cbModel.Items.Clear();
            cbModel.Items.AddRange(new object[]
            {
                "gemini-flash-lite-latest",
                "gemini-2.0-flash",
                "gemini-2.5-flash",
                "gemini-2.5-pro",
                "gpt-4o-mini",
                "gpt-4o",
                "gemma3:4b"
            });
        }

        /// <summary>
        /// Đọc cấu hình AI từ Database và hiển thị lên các Control
        /// </summary>
        private async Task LoadConfigFromDatabaseAsync()
        {
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    var repo = new DatabaseRepository(db);
                    _currentConfig = await repo.GetActiveAIConfigAsync();
                }

                if (_currentConfig != null)
                {
                    // Hiển thị dữ liệu lên UI
                    SetComboValue(cbService, _currentConfig.ServiceProvider);
                    SetComboValue(cbModel, _currentConfig.Model);
                    txtKey.Text = _currentConfig.ApiKey ?? "";
                    txtSystemPrompt.Text = _currentConfig.SystemPrompt ?? "";

                    int tempPercent = (int)(_currentConfig.Temperature * 100);
                    trackTemp.Value = Math.Clamp(tempPercent, 0, 100);
                    lblTempValue.Text = _currentConfig.Temperature.ToString("0.0");
                }
                else
                {
                    // Tạo cấu hình mới mặc định
                    _currentConfig = new AIConfigModel();
                    cbService.SelectedIndex = 0;
                    cbModel.SelectedIndex = 0;
                    txtSystemPrompt.Text = _currentConfig.SystemPrompt;
                    trackTemp.Value = 70;
                    lblTempValue.Text = "0.7";
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Lỗi khi tải cấu hình AI: " + ex.Message);
                _currentConfig = new AIConfigModel();
            }
        }

        /// <summary>
        /// Chọn item trong ComboBox theo text, nếu không có thì thêm mới
        /// </summary>
        private void SetComboValue(Sunny.UI.UIComboBox cb, string value)
        {
            if (string.IsNullOrWhiteSpace(value)) { cb.SelectedIndex = 0; return; }
            int idx = cb.Items.IndexOf(value);
            if (idx >= 0)
                cb.SelectedIndex = idx;
            else
            {
                cb.Items.Add(value);
                cb.SelectedIndex = cb.Items.Count - 1;
            }
        }

        /// <summary>
        /// Xử lý sự kiện khi TrackBar thay đổi giá trị
        /// </summary>
        private void trackTemp_ValueChanged(object sender, EventArgs e)
        {
            double temp = trackTemp.Value / 100.0;
            lblTempValue.Text = temp.ToString("0.0");
        }

        /// <summary>
        /// Kiểm tra kết nối API
        /// </summary>
        private async void btnCheck_Click(object sender, EventArgs e)
        {
            string apiKey = txtKey.Text.Trim();
            string model = cbModel.Text;

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập API Key trước khi kiểm tra kết nối.");
                return;
            }

            btnCheck.Enabled = false;
            btnCheck.Text = "Đang kiểm tra...";

            try
            {
                var testService = new GeminiService(apiKey, model);
                string result = await testService.TestConnectionAsync();

                if (result.Contains("✅"))
                {
                    UIMessageBox.ShowSuccess2(result);
                }
                else
                {
                    UIMessageBox.ShowError2(result);
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError2("Lỗi: " + ex.Message);
            }
            finally
            {
                btnCheck.Enabled = true;
                btnCheck.Text = "Kiểm tra kết nối";
            }
        }

        private void btnSelectTestFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Thiết lập bộ lọc file
                ofd.Filter = "Document Files|*.pdf";
                ofd.Title = "Chọn tài liệu nguồn để tạo câu hỏi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn lên TextBox
                    txtTestFilePath.Text = ofd.FileName;
                    UIMessageTip.ShowOk("Chọn file thành công.");
                }
            }
        }

        /// <summary>
        /// Chạy thử Prompt để xem kết quả AI trả về
        /// </summary>
        private async void btnTestPrompt_Click(object sender, EventArgs e)
        {
            string apiKey = txtKey.Text.Trim();
            string model = cbModel.Text;
            string prompt = txtSystemPrompt.Text.Trim();
            double temp = trackTemp.Value / 100.0;

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập API Key trước khi chạy thử.");
                return;
            }

            if (string.IsNullOrWhiteSpace(prompt))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập System Prompt trước khi chạy thử.");
                return;
            }

            string inputData = "";

            if (tabTestInput.SelectedIndex == 0) // Văn bản
            {
                inputData = txtTestInput.Text.Trim();
            }
            else // Tệp tin
            {
                if (string.IsNullOrEmpty(txtTestFilePath.Text))
                {
                    UIMessageBox.ShowWarning2("Vui lòng chọn file tài liệu trước!");
                    return;
                }
                try
                {
                    if (!System.IO.File.Exists(txtTestFilePath.Text))
                    {
                        UIMessageBox.ShowWarning2("File không tồn tại hoặc không thể truy cập.");
                        return;
                    }
                    inputData = _docService.ExtractTextFromPdf(txtTestFilePath.Text);
                }
                catch (Exception exFile)
                {
                    UIMessageBox.ShowError2("Không thể đọc file: " + exFile.Message);
                    return;
                }
            }

            btnTestPrompt.Enabled = false;
            btnTestPrompt.Text = "AI đang xử lý...";
            txtOutput.Text = "⏳ Đang gửi yêu cầu tới AI...";

            try
            {
                int numQuestions = udtxtNumQuestions.IntValue;
                if (numQuestions < 1) numQuestions = 2;

                var testService = new GeminiService(apiKey, model, prompt, temp);
                string result = await testService.TestPromptAsync(prompt, temp, inputData, numQuestions);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                txtOutput.Text = "❌ Lỗi: " + ex.Message;
            }
            finally
            {
                btnTestPrompt.Enabled = true;
                btnTestPrompt.Text = "▶ Chạy thử Prompt";
            }
        }

        /// <summary>
        /// Lưu cấu hình AI vào Database
        /// </summary>
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập API Key.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSystemPrompt.Text))
            {
                UIMessageBox.ShowWarning2("Vui lòng nhập System Prompt.");
                return;
            }

            btnUpdate.Enabled = false;
            btnUpdate.Text = "Đang lưu...";

            try
            {
                // Cập nhật thông tin từ UI vào Model
                _currentConfig.ServiceProvider = cbService.Text;
                _currentConfig.Model = cbModel.Text;
                _currentConfig.ApiKey = txtKey.Text.Trim();
                _currentConfig.SystemPrompt = txtSystemPrompt.Text.Trim();
                _currentConfig.Temperature = trackTemp.Value / 100.0;
                _currentConfig.IsActive = true;

                using (var db = new ExamBankDbContext())
                {
                    var repo = new DatabaseRepository(db);

                    if (_currentConfig.Id == 0)
                    {
                        // Tạo bản ghi mới nếu chưa có
                        _currentConfig.CreatedAt = DateTime.Now;
                        await repo.AddAIConfigAsync(_currentConfig);
                    }
                    else
                    {
                        // Cập nhật bản ghi đã có
                        db.Attach(_currentConfig);
                        await repo.UpdateAIConfigAsync(_currentConfig);
                    }
                }

                UIMessageBox.ShowSuccess2("Lưu cấu hình AI thành công!\n\nCấu hình mới sẽ được áp dụng cho tất cả giáo viên khi sử dụng chức năng tạo câu hỏi AI.");
            }
            catch (Exception ex)
            {
                string msg = ex.InnerException?.Message ?? ex.Message;
                UIMessageBox.ShowError2("Lỗi khi lưu cấu hình: " + msg);
            }
            finally
            {
                btnUpdate.Enabled = true;
                btnUpdate.Text = "💾 Lưu cấu hình";
            }
        }
    }
}
