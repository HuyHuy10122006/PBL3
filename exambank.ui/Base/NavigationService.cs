using System;
using System.Collections.Generic;
using System.Text;
using Sunny.UI;
using System.Windows.Forms;

namespace exambank.ui.Base
{
    public class NavigationService
    {
        private readonly UIPanel _container;

        public NavigationService(UIPanel container)
        {
            _container = container;
        }

        public void Display(UserControl uc)
        {
            // Ẩn tất cả UC hiện tại thay vì xóa chúng
            // Tránh việc Controls.Clear() + Controls.Add() → fire lại Load event
            foreach (Control ctrl in _container.Controls)
            {
                ctrl.Visible = false;
            }

            // Nếu UC chưa từng được thêm vào container thì thêm lần đầu
            if (!_container.Controls.Contains(uc))
            {
                uc.Dock = DockStyle.Fill;
                _container.Controls.Add(uc);
            }

            // Hiển thị UC được chọn
            uc.Visible = true;
            uc.BringToFront();
        }
    }
}
