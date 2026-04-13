using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exambank.ui
{
    public partial class UC_AICreate : UserControl
    {
        public UC_AICreate()
        {
            InitializeComponent();
        }

        // Hàm dùng để nạp dữ liệu mẫu từ Class
        private void NapDuLieuChuong(List<string> danhSach)
        {
            clbChuong.Items.Clear();
            foreach (var item in danhSach)
            {
                clbChuong.Items.Add(item);
            }
        }

        private void txtSelectedChuong_Click(object sender, EventArgs e)
        {
            pnlPopup.Visible = !pnlPopup.Visible;
            if (pnlPopup.Visible) pnlPopup.BringToFront();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>();
            foreach (var item in clbChuong.CheckedItems)
            {
                string chuong = item.ToString().Split(':')[0].Split(" ")[1];
                selected.Add(chuong);
            }
            if (selected.Count > 0)
            {
                txtSelectedChuong.Text = "Chương:" + string.Join(", ", selected);
            }
            pnlPopup.Visible = false;
        }

        private void HienThiDuLieuMau()
        {
            var dsCauHoi = new List<dynamic>
            {
                new { ID = 1, NoiDung = "Phep bien doi nao sau day khong lam thay doi hinh dang doi tuong?", DapAn = new[] {"Tinh tien", "Ti le", "Bien dang", "Doi xung"}},
                new { ID = 2, NoiDung = "Trong he toa do WCS, truc dung thuong la truc nao?", DapAn = new[] {"Truc X", "Truc Y", "Truc Z", "Truc W"}},
                new { ID = 3, NoiDung = "Thuat toan Bresenham dung de ve duong gi?", DapAn = new[] {"Duong thang", "Duong tron", "Duong Ellipse", "Tat ca deu dung"}}
            };

            //flpPreview.Controls.Clear();

            // Lấy chiều rộng thực tế của vùng chứa (trừ đi khoảng cách lề và thanh cuộn)
            int targetWidth = flpPreview.ClientSize.Width - 40;

            foreach (var item in dsCauHoi)
            {
                UC_Question uc = new UC_Question();
                uc.SetData(item.ID, item.NoiDung, item.DapAn);
                // Gán chiều rộng cụ thể
                uc.Width = targetWidth;

                flpPreview.Controls.Add(uc);
            }
        }

        private void UC_AICreate_Load(object sender, EventArgs e)
        {
            List<string> danhSachChuong = new List<string> {
            "Chương 1: Di truyền học Di truyền học Di truyền học",
            "Chương 2: Biến dị",
            "Chương 3: Tiến hóa",
            "Chương 4: Sinh thái học"
            };
            NapDuLieuChuong(danhSachChuong);
            
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            HienThiDuLieuMau();
        }
    }
}
