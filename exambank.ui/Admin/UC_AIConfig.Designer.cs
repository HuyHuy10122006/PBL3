namespace exambank.ui
{
    partial class UC_AIConfig
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            // === LEFT PANEL ===
            pnlConnection = new Sunny.UI.UIPanel();
            btnCheck = new Sunny.UI.UIButton();
            txtKey = new Sunny.UI.UITextBox();
            lblApiKey = new Sunny.UI.UILabel();
            lblModel = new Sunny.UI.UILabel();
            cbModel = new Sunny.UI.UIComboBox();
            lblService = new Sunny.UI.UILabel();
            cbService = new Sunny.UI.UIComboBox();
            lblTitleConnection = new Sunny.UI.UILabel();
            pnlPrompt = new Sunny.UI.UIPanel();
            lblTitlePrompt = new Sunny.UI.UILabel();
            grpPrompt = new Sunny.UI.UIGroupBox();
            txtSystemPrompt = new Sunny.UI.UITextBox();
            lblTemp = new Sunny.UI.UILabel();
            trackTemp = new Sunny.UI.UITrackBar();
            lblTempValue = new Sunny.UI.UILabel();
            // === RIGHT PANEL ===
            pnlTest = new Sunny.UI.UIPanel();
            lblTitleTest = new Sunny.UI.UILabel();
            grpOutput = new Sunny.UI.UIGroupBox();
            txtOutput = new Sunny.UI.UITextBox();
            btnTestPrompt = new Sunny.UI.UIButton();
            btnTestPrompt = new Sunny.UI.UIButton();
            tabTestInput = new Sunny.UI.UITabControl();
            tpTestText = new TabPage();
            txtTestInput = new Sunny.UI.UITextBox();
            tpTestFile = new TabPage();
            btnSelectTestFile = new Sunny.UI.UISymbolButton();
            txtTestFilePath = new Sunny.UI.UITextBox();
            lblNumQuestions = new Sunny.UI.UILabel();
            udtxtNumQuestions = new Sunny.UI.UIUpDownTextBox();
            btnUpdate = new Sunny.UI.UISymbolButton();

            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlConnection.SuspendLayout();
            pnlPrompt.SuspendLayout();
            grpPrompt.SuspendLayout();
            pnlTest.SuspendLayout();
            grpOutput.SuspendLayout();
            tabTestInput.SuspendLayout();
            tpTestText.SuspendLayout();
            tpTestFile.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitMain.Location = new Point(15, 15);
            splitMain.Name = "splitMain";
            splitMain.Size = new Size(944, 880);
            splitMain.SplitterDistance = 440;
            splitMain.SplitterWidth = 8;
            splitMain.TabIndex = 0;
            // 
            // === LEFT PANEL (splitMain.Panel1) ===
            //
            splitMain.Panel1.Controls.Add(pnlPrompt);
            splitMain.Panel1.Controls.Add(pnlConnection);
            splitMain.Panel1.Padding = new Padding(0, 0, 5, 0);
            // 
            // pnlConnection
            // 
            pnlConnection.BackColor = Color.Transparent;
            pnlConnection.Controls.Add(btnCheck);
            pnlConnection.Controls.Add(txtKey);
            pnlConnection.Controls.Add(lblApiKey);
            pnlConnection.Controls.Add(lblModel);
            pnlConnection.Controls.Add(cbModel);
            pnlConnection.Controls.Add(lblService);
            pnlConnection.Controls.Add(cbService);
            pnlConnection.Controls.Add(lblTitleConnection);
            pnlConnection.Dock = DockStyle.Top;
            pnlConnection.FillColor = Color.White;
            pnlConnection.FillColor2 = Color.White;
            pnlConnection.Font = new Font("Microsoft Sans Serif", 12F);
            pnlConnection.Location = new Point(0, 0);
            pnlConnection.MinimumSize = new Size(1, 1);
            pnlConnection.Name = "pnlConnection";
            pnlConnection.Radius = 15;
            pnlConnection.RectColor = Color.Gray;
            pnlConnection.Size = new Size(435, 280);
            pnlConnection.TabIndex = 0;
            pnlConnection.Text = null;
            pnlConnection.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitleConnection
            // 
            lblTitleConnection.BackColor = Color.White;
            lblTitleConnection.Font = new Font("Times New Roman", 13.2F, FontStyle.Bold);
            lblTitleConnection.ForeColor = Color.Navy;
            lblTitleConnection.Location = new Point(10, 4);
            lblTitleConnection.Name = "lblTitleConnection";
            lblTitleConnection.Size = new Size(310, 29);
            lblTitleConnection.TabIndex = 0;
            lblTitleConnection.Text = "Kết nối và xác thực";
            // 
            // lblService
            // 
            lblService.BackColor = Color.Transparent;
            lblService.Font = new Font("Times New Roman", 12F);
            lblService.ForeColor = Color.FromArgb(48, 48, 48);
            lblService.Location = new Point(15, 45);
            lblService.Name = "lblService";
            lblService.Size = new Size(140, 35);
            lblService.TabIndex = 1;
            lblService.Text = "Service Provider:";
            lblService.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbService
            // 
            cbService.DataSource = null;
            cbService.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbService.FillColor = Color.White;
            cbService.FillColor2 = Color.FromArgb(24, 24, 24);
            cbService.Font = new Font("Times New Roman", 10.8F);
            cbService.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbService.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbService.Location = new Point(160, 45);
            cbService.MinimumSize = new Size(63, 0);
            cbService.Name = "cbService";
            cbService.Padding = new Padding(0, 0, 30, 2);
            cbService.RectColor = Color.FromArgb(18, 58, 92);
            cbService.Size = new Size(255, 35);
            cbService.Style = Sunny.UI.UIStyle.Custom;
            cbService.TabIndex = 2;
            cbService.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblModel
            // 
            lblModel.BackColor = Color.Transparent;
            lblModel.Font = new Font("Times New Roman", 12F);
            lblModel.ForeColor = Color.FromArgb(48, 48, 48);
            lblModel.Location = new Point(15, 90);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(140, 35);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model:";
            lblModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbModel
            // 
            cbModel.DataSource = null;
            cbModel.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbModel.FillColor = Color.White;
            cbModel.FillColor2 = Color.FromArgb(24, 24, 24);
            cbModel.Font = new Font("Times New Roman", 10.8F);
            cbModel.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbModel.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbModel.Location = new Point(160, 90);
            cbModel.MinimumSize = new Size(63, 0);
            cbModel.Name = "cbModel";
            cbModel.Padding = new Padding(0, 0, 30, 2);
            cbModel.RectColor = Color.FromArgb(18, 58, 92);
            cbModel.Size = new Size(255, 35);
            cbModel.Style = Sunny.UI.UIStyle.Custom;
            cbModel.TabIndex = 4;
            cbModel.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblApiKey
            // 
            lblApiKey.BackColor = Color.Transparent;
            lblApiKey.Font = new Font("Times New Roman", 12F);
            lblApiKey.ForeColor = Color.FromArgb(48, 48, 48);
            lblApiKey.Location = new Point(15, 138);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(140, 35);
            lblApiKey.TabIndex = 5;
            lblApiKey.Text = "API Key:";
            lblApiKey.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKey
            // 
            txtKey.ButtonRectColor = Color.FromArgb(18, 58, 92);
            txtKey.ButtonStyleInherited = false;
            txtKey.FillColor2 = Color.FromArgb(24, 24, 24);
            txtKey.Font = new Font("Times New Roman", 12F);
            txtKey.Location = new Point(160, 138);
            txtKey.MinimumSize = new Size(1, 16);
            txtKey.Name = "txtKey";
            txtKey.Padding = new Padding(5);
            txtKey.RectColor = Color.FromArgb(18, 58, 92);
            txtKey.ScrollBarColor = Color.FromArgb(24, 24, 24);
            txtKey.ScrollBarStyleInherited = false;
            txtKey.ShowText = false;
            txtKey.Size = new Size(255, 36);
            txtKey.Style = Sunny.UI.UIStyle.Custom;
            txtKey.TabIndex = 6;
            txtKey.TextAlignment = ContentAlignment.MiddleLeft;
            txtKey.Watermark = "Nhập API key...";
            // 
            // btnCheck
            // 
            btnCheck.FillColor = Color.FromArgb(0, 0, 192);
            btnCheck.Font = new Font("Times New Roman", 11F);
            btnCheck.Location = new Point(120, 195);
            btnCheck.MinimumSize = new Size(1, 1);
            btnCheck.Name = "btnCheck";
            btnCheck.Radius = 10;
            btnCheck.Size = new Size(200, 44);
            btnCheck.Style = Sunny.UI.UIStyle.Custom;
            btnCheck.TabIndex = 7;
            btnCheck.Text = "Kiểm tra kết nối";
            btnCheck.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCheck.Click += btnCheck_Click;
            // 
            // pnlPrompt
            // 
            pnlPrompt.BackColor = Color.Transparent;
            pnlPrompt.Controls.Add(lblTempValue);
            pnlPrompt.Controls.Add(trackTemp);
            pnlPrompt.Controls.Add(lblTemp);
            pnlPrompt.Controls.Add(grpPrompt);
            pnlPrompt.Controls.Add(lblTitlePrompt);
            pnlPrompt.Dock = DockStyle.Fill;
            pnlPrompt.FillColor = Color.White;
            pnlPrompt.FillColor2 = Color.White;
            pnlPrompt.Font = new Font("Times New Roman", 12F);
            pnlPrompt.Location = new Point(0, 280);
            pnlPrompt.MinimumSize = new Size(1, 1);
            pnlPrompt.Name = "pnlPrompt";
            pnlPrompt.Radius = 15;
            pnlPrompt.RectColor = Color.Gray;
            pnlPrompt.Size = new Size(435, 600);
            pnlPrompt.TabIndex = 1;
            pnlPrompt.Text = null;
            pnlPrompt.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitlePrompt
            // 
            lblTitlePrompt.BackColor = Color.White;
            lblTitlePrompt.Font = new Font("Times New Roman", 13.2F, FontStyle.Bold);
            lblTitlePrompt.ForeColor = Color.Navy;
            lblTitlePrompt.Location = new Point(10, 4);
            lblTitlePrompt.Name = "lblTitlePrompt";
            lblTitlePrompt.Size = new Size(310, 29);
            lblTitlePrompt.TabIndex = 0;
            lblTitlePrompt.Text = "Định hình phản hồi";
            // 
            // grpPrompt
            // 
            grpPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            grpPrompt.BackColor = Color.Transparent;
            grpPrompt.Controls.Add(txtSystemPrompt);
            grpPrompt.FillColor = Color.Transparent;
            grpPrompt.FillColor2 = Color.Transparent;
            grpPrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            grpPrompt.ForeColor = Color.Navy;
            grpPrompt.Location = new Point(15, 40);
            grpPrompt.MinimumSize = new Size(1, 1);
            grpPrompt.Name = "grpPrompt";
            grpPrompt.Padding = new Padding(0, 32, 0, 0);
            grpPrompt.RectColor = Color.Gray;
            grpPrompt.Size = new Size(405, 380);
            grpPrompt.Style = Sunny.UI.UIStyle.Custom;
            grpPrompt.TabIndex = 1;
            grpPrompt.Text = "System Prompt";
            grpPrompt.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // txtSystemPrompt
            // 
            txtSystemPrompt.Dock = DockStyle.Fill;
            txtSystemPrompt.FillColor2 = Color.FromArgb(24, 24, 24);
            txtSystemPrompt.Font = new Font("Times New Roman", 12F);
            txtSystemPrompt.Location = new Point(0, 32);
            txtSystemPrompt.MinimumSize = new Size(1, 16);
            txtSystemPrompt.Multiline = true;
            txtSystemPrompt.Name = "txtSystemPrompt";
            txtSystemPrompt.Padding = new Padding(5);
            txtSystemPrompt.RectColor = Color.FromArgb(18, 58, 92);
            txtSystemPrompt.RectSides = ToolStripStatusLabelBorderSides.None;
            txtSystemPrompt.ShowText = false;
            txtSystemPrompt.Size = new Size(405, 348);
            txtSystemPrompt.Style = Sunny.UI.UIStyle.Custom;
            txtSystemPrompt.TabIndex = 2;
            txtSystemPrompt.TextAlignment = ContentAlignment.TopLeft;
            txtSystemPrompt.Watermark = "Nhập system prompt tại đây...";
            // 
            // lblTemp
            // 
            lblTemp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTemp.BackColor = Color.Transparent;
            lblTemp.Font = new Font("Times New Roman", 12F);
            lblTemp.ForeColor = Color.FromArgb(48, 48, 48);
            lblTemp.Location = new Point(15, 435);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(190, 29);
            lblTemp.TabIndex = 3;
            lblTemp.Text = "Temperature (0.0 - 1.0):";
            // 
            // trackTemp
            // 
            trackTemp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackTemp.BackColor = Color.Transparent;
            trackTemp.FillColor = Color.White;
            trackTemp.Font = new Font("Times New Roman", 12F);
            trackTemp.ForeColor = Color.Black;
            trackTemp.Location = new Point(210, 430);
            trackTemp.MinimumSize = new Size(1, 1);
            trackTemp.Name = "trackTemp";
            trackTemp.RectColor = Color.Black;
            trackTemp.Size = new Size(160, 36);
            trackTemp.Style = Sunny.UI.UIStyle.Custom;
            trackTemp.TabIndex = 4;
            trackTemp.Value = 50;
            trackTemp.ValueChanged += trackTemp_ValueChanged;
            // 
            // lblTempValue
            // 
            lblTempValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTempValue.BackColor = Color.Transparent;
            lblTempValue.Font = new Font("Times New Roman", 12F);
            lblTempValue.ForeColor = Color.FromArgb(48, 48, 48);
            lblTempValue.Location = new Point(375, 435);
            lblTempValue.Name = "lblTempValue";
            lblTempValue.Size = new Size(50, 29);
            lblTempValue.TabIndex = 5;
            lblTempValue.Text = "0.5";
            // 
            // === RIGHT PANEL (splitMain.Panel2) ===
            //
            splitMain.Panel2.Controls.Add(pnlTest);
            splitMain.Panel2.Padding = new Padding(5, 0, 0, 0);
            // 
            // pnlTest
            // 
            pnlTest.BackColor = Color.Transparent;
            pnlTest.Controls.Add(btnTestPrompt);
            pnlTest.Controls.Add(grpOutput);
            pnlTest.Controls.Add(tabTestInput);
            pnlTest.Controls.Add(lblNumQuestions);
            pnlTest.Controls.Add(udtxtNumQuestions);
            pnlTest.Controls.Add(lblTitleTest);
            pnlTest.Dock = DockStyle.Fill;
            pnlTest.FillColor = Color.White;
            pnlTest.FillColor2 = Color.White;
            pnlTest.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTest.Location = new Point(5, 0);
            pnlTest.MinimumSize = new Size(1, 1);
            pnlTest.Name = "pnlTest";
            pnlTest.Radius = 15;
            pnlTest.RectColor = Color.Gray;
            pnlTest.Size = new Size(491, 880);
            pnlTest.TabIndex = 0;
            pnlTest.Text = null;
            pnlTest.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitleTest
            // 
            lblTitleTest.BackColor = Color.White;
            lblTitleTest.Font = new Font("Times New Roman", 13.2F, FontStyle.Bold);
            lblTitleTest.ForeColor = Color.Navy;
            lblTitleTest.Location = new Point(10, 4);
            lblTitleTest.Name = "lblTitleTest";
            lblTitleTest.Size = new Size(310, 29);
            lblTitleTest.TabIndex = 0;
            lblTitleTest.Text = "Chạy thử nghiệm AI";
            // 
            // lblNumQuestions
            // 
            lblNumQuestions.BackColor = Color.Transparent;
            lblNumQuestions.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblNumQuestions.ForeColor = Color.Navy;
            lblNumQuestions.Location = new Point(15, 38);
            lblNumQuestions.Name = "lblNumQuestions";
            lblNumQuestions.Size = new Size(130, 25);
            lblNumQuestions.TabIndex = 1;
            lblNumQuestions.Text = "Số lượng câu:";
            // 
            // udtxtNumQuestions
            // 
            udtxtNumQuestions.Font = new Font("Times New Roman", 11F);
            udtxtNumQuestions.Location = new Point(145, 36);
            udtxtNumQuestions.Maximum = 50D;
            udtxtNumQuestions.Minimum = 1D;
            udtxtNumQuestions.Name = "udtxtNumQuestions";
            udtxtNumQuestions.Size = new Size(100, 29);
            udtxtNumQuestions.TabIndex = 2;
            udtxtNumQuestions.Text = "2";
            udtxtNumQuestions.ShowText = false;
            udtxtNumQuestions.TextAlignment = ContentAlignment.MiddleCenter;
            udtxtNumQuestions.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // tabTestInput
            // 
            tabTestInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabTestInput.Controls.Add(tpTestText);
            tabTestInput.Controls.Add(tpTestFile);
            tabTestInput.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabTestInput.FillColor = Color.White;
            tabTestInput.Font = new Font("Times New Roman", 11F);
            tabTestInput.ItemSize = new Size(150, 30);
            tabTestInput.Location = new Point(15, 70);
            tabTestInput.MainPage = "";
            tabTestInput.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            tabTestInput.Name = "tabTestInput";
            tabTestInput.SelectedIndex = 0;
            tabTestInput.SizeMode = TabSizeMode.Fixed;
            tabTestInput.Size = new Size(461, 120);
            tabTestInput.TabBackColor = Color.White;
            tabTestInput.TabSelectedColor = Color.LightGray;
            tabTestInput.TabSelectedForeColor = Color.Navy;
            tabTestInput.TabSelectedHighColor = Color.Blue;
            tabTestInput.TabUnSelectedColor = Color.WhiteSmoke;
            tabTestInput.TabUnSelectedForeColor = Color.DimGray;
            tabTestInput.TabIndex = 3;
            // 
            // tpTestText
            // 
            tpTestText.BackColor = Color.White;
            tpTestText.Controls.Add(txtTestInput);
            tpTestText.Location = new Point(0, 30);
            tpTestText.Name = "tpTestText";
            tpTestText.Size = new Size(461, 90);
            tpTestText.TabIndex = 0;
            tpTestText.Text = "Văn bản";
            // 
            // txtTestInput
            // 
            txtTestInput.Dock = DockStyle.Fill;
            txtTestInput.FillColor2 = Color.FromArgb(24, 24, 24);
            txtTestInput.Font = new Font("Times New Roman", 11F);
            txtTestInput.Location = new Point(0, 0);
            txtTestInput.MinimumSize = new Size(1, 16);
            txtTestInput.Multiline = true;
            txtTestInput.Name = "txtTestInput";
            txtTestInput.Padding = new Padding(5);
            txtTestInput.RectColor = Color.FromArgb(18, 58, 92);
            txtTestInput.ShowScrollBar = true;
            txtTestInput.ShowText = false;
            txtTestInput.Size = new Size(461, 90);
            txtTestInput.Style = Sunny.UI.UIStyle.Custom;
            txtTestInput.TabIndex = 0;
            txtTestInput.TextAlignment = ContentAlignment.TopLeft;
            txtTestInput.Watermark = "Nhập nội dung để thử tạo câu hỏi... (bỏ trống sẽ dùng nội dung mặc định)";
            // 
            // tpTestFile
            // 
            tpTestFile.BackColor = Color.White;
            tpTestFile.Controls.Add(btnSelectTestFile);
            tpTestFile.Controls.Add(txtTestFilePath);
            tpTestFile.Location = new Point(0, 30);
            tpTestFile.Name = "tpTestFile";
            tpTestFile.Size = new Size(461, 90);
            tpTestFile.TabIndex = 1;
            tpTestFile.Text = "Tệp tin (PDF)";
            // 
            // btnSelectTestFile
            // 
            btnSelectTestFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectTestFile.Font = new Font("Times New Roman", 11F);
            btnSelectTestFile.Location = new Point(410, 15);
            btnSelectTestFile.Name = "btnSelectTestFile";
            btnSelectTestFile.Size = new Size(35, 35);
            btnSelectTestFile.Symbol = 61717;
            btnSelectTestFile.TabIndex = 1;
            btnSelectTestFile.Click += btnSelectTestFile_Click;
            // 
            // txtTestFilePath
            // 
            txtTestFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTestFilePath.Font = new Font("Times New Roman", 11F);
            txtTestFilePath.Location = new Point(15, 15);
            txtTestFilePath.Name = "txtTestFilePath";
            txtTestFilePath.ReadOnly = true;
            txtTestFilePath.Size = new Size(385, 35);
            txtTestFilePath.TabIndex = 0;
            txtTestFilePath.Watermark = "Đường dẫn tài liệu...";
            // 
            // grpOutput
            // 
            grpOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpOutput.BackColor = Color.Transparent;
            grpOutput.Controls.Add(txtOutput);
            grpOutput.FillColor = Color.Transparent;
            grpOutput.FillColor2 = Color.Transparent;
            grpOutput.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            grpOutput.ForeColor = Color.Navy;
            grpOutput.Location = new Point(15, 195);
            grpOutput.MinimumSize = new Size(1, 1);
            grpOutput.Name = "grpOutput";
            grpOutput.Padding = new Padding(0, 32, 0, 0);
            grpOutput.RectColor = Color.Gray;
            grpOutput.Size = new Size(461, 610);
            grpOutput.Style = Sunny.UI.UIStyle.Custom;
            grpOutput.TabIndex = 4;
            grpOutput.Text = "AI Output Preview";
            grpOutput.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.FillColor2 = Color.FromArgb(24, 24, 24);
            txtOutput.Font = new Font("Times New Roman", 12F);
            txtOutput.Location = new Point(0, 32);
            txtOutput.MinimumSize = new Size(1, 16);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Padding = new Padding(5);
            txtOutput.ReadOnly = true;
            txtOutput.RectColor = Color.FromArgb(18, 58, 92);
            txtOutput.RectSides = ToolStripStatusLabelBorderSides.None;
            txtOutput.ShowText = false;
            txtOutput.Size = new Size(461, 578);
            txtOutput.Style = Sunny.UI.UIStyle.Custom;
            txtOutput.TabIndex = 5;
            txtOutput.TextAlignment = ContentAlignment.TopLeft;
            txtOutput.Watermark = "Kết quả từ AI sẽ hiển thị tại đây...";
            // 
            // btnTestPrompt
            // 
            btnTestPrompt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTestPrompt.FillColor = Color.FromArgb(0, 0, 192);
            btnTestPrompt.Font = new Font("Times New Roman", 12F);
            btnTestPrompt.Location = new Point(296, 820);
            btnTestPrompt.MinimumSize = new Size(1, 1);
            btnTestPrompt.Name = "btnTestPrompt";
            btnTestPrompt.Radius = 10;
            btnTestPrompt.Size = new Size(180, 44);
            btnTestPrompt.Style = Sunny.UI.UIStyle.Custom;
            btnTestPrompt.TabIndex = 6;
            btnTestPrompt.Text = "▶ Chạy thử Prompt";
            btnTestPrompt.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTestPrompt.Click += btnTestPrompt_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.FillColor = Color.Navy;
            btnUpdate.FillColor2 = Color.Navy;
            btnUpdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(756, 905);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Radius = 10;
            btnUpdate.Size = new Size(203, 54);
            btnUpdate.Symbol = 0;
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "💾 Lưu cấu hình";
            btnUpdate.TipsFont = new Font("Times New Roman", 12F);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UC_AIConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 243);
            Controls.Add(btnUpdate);
            Controls.Add(splitMain);
            Name = "UC_AIConfig";
            Size = new Size(974, 970);
            Load += UC_AIConfig_Load;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlConnection.ResumeLayout(false);
            pnlPrompt.ResumeLayout(false);
            grpPrompt.ResumeLayout(false);
            pnlTest.ResumeLayout(false);
            grpOutput.ResumeLayout(false);
            tabTestInput.ResumeLayout(false);
            tpTestText.ResumeLayout(false);
            tpTestFile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        // Left panel
        private Sunny.UI.UIPanel pnlConnection;
        private Sunny.UI.UILabel lblTitleConnection;
        private Sunny.UI.UILabel lblService;
        private Sunny.UI.UIComboBox cbService;
        private Sunny.UI.UILabel lblModel;
        private Sunny.UI.UIComboBox cbModel;
        private Sunny.UI.UILabel lblApiKey;
        private Sunny.UI.UITextBox txtKey;
        private Sunny.UI.UIButton btnCheck;
        private Sunny.UI.UIPanel pnlPrompt;
        private Sunny.UI.UILabel lblTitlePrompt;
        private Sunny.UI.UIGroupBox grpPrompt;
        private Sunny.UI.UITextBox txtSystemPrompt;
        private Sunny.UI.UILabel lblTemp;
        private Sunny.UI.UITrackBar trackTemp;
        private Sunny.UI.UILabel lblTempValue;
        // Right panel
        private Sunny.UI.UIPanel pnlTest;
        private Sunny.UI.UILabel lblTitleTest;
        private Sunny.UI.UILabel lblNumQuestions;
        private Sunny.UI.UIUpDownTextBox udtxtNumQuestions;
        private Sunny.UI.UITabControl tabTestInput;
        private System.Windows.Forms.TabPage tpTestText;
        private Sunny.UI.UITextBox txtTestInput;
        private System.Windows.Forms.TabPage tpTestFile;
        private Sunny.UI.UISymbolButton btnSelectTestFile;
        private Sunny.UI.UITextBox txtTestFilePath;
        private Sunny.UI.UIGroupBox grpOutput;
        private Sunny.UI.UITextBox txtOutput;
        private Sunny.UI.UIButton btnTestPrompt;
        // Bottom
        private Sunny.UI.UISymbolButton btnUpdate;
    }
}
