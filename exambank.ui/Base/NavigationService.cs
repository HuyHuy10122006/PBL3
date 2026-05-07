using System;
using System.Collections.Generic;
using System.Text;
using Sunny.UI;

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
            if (!_container.Controls.Contains(uc))
            {
                uc.Dock = DockStyle.Fill;
                _container.Controls.Clear();
                _container.Controls.Add(uc);
            }
            uc.BringToFront();
        }
    }
}
