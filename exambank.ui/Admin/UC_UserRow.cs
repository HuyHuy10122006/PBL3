using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using exambank.data.Models;

namespace exambank.ui.Admin
{
    public class UC_UserRow : UserControl
    {
        public UserModel UserData { get; private set; }
        public int Index { get; private set; }
        public event EventHandler<UserModel> ActionClicked;

        private bool _isHovered = false;
        private bool _isCurrentUser = false;
        private Image _avatar;
        private Rectangle _actionRect;

        public UC_UserRow(UserModel user, int index, bool isCurrentUser = false)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            UserData = user;
            Index = index;
            _isCurrentUser = isCurrentUser;
            
            this.Size = new Size(1180, 60);
            this.Margin = new Padding(0, 0, 0, 0); // Sát nhau để border đẹp hơn
            
            try {
                // Tải ảnh trực tiếp từ thư mục dự án nếu có
                string path = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\Resources\user_avata.png");
                if (System.IO.File.Exists(path)) {
                    _avatar = Image.FromFile(path);
                }
            } catch {
                _avatar = null;
            }

            this.MouseEnter += (s, e) => { _isHovered = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { _isHovered = false; this.Invalidate(); };
            this.MouseClick += UC_UserRow_MouseClick;
            this.MouseMove += UC_UserRow_MouseMove;
        }

        private void UC_UserRow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_actionRect.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void UC_UserRow_MouseClick(object sender, MouseEventArgs e)
        {
            if (_actionRect.Contains(e.Location))
            {
                ActionClicked?.Invoke(this, UserData);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Nền
            if (_isHovered)
                g.FillRectangle(new SolidBrush(Color.FromArgb(245, 247, 250)), this.ClientRectangle);
            else
                g.FillRectangle(new SolidBrush(Color.White), this.ClientRectangle);

            // Viền dưới (Bottom border)
            g.DrawLine(new Pen(Color.FromArgb(235, 235, 235)), 0, this.Height - 1, this.Width, this.Height - 1);

            int yCenter = this.Height / 2;
            StringFormat sfCenter = new StringFormat { LineAlignment = StringAlignment.Center };
            StringFormat sfLeft = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near };
            
            Font fontRegular = new Font("Segoe UI", 10);
            Font fontBold = new Font("Segoe UI", 10, FontStyle.Bold);
            Font fontSmall = new Font("Segoe UI", 9, FontStyle.Regular);
            
            Brush textBrush = new SolidBrush(Color.FromArgb(50, 50, 50));
            Brush subTextBrush = new SolidBrush(Color.FromArgb(120, 120, 120));

            // STT
            g.DrawString(Index.ToString(), fontRegular, textBrush, new Rectangle(20, 0, 40, this.Height), sfCenter);

            // Avatar (ảnh tròn)
            int avatarSize = 36;
            Rectangle avatarRect = new Rectangle(70, yCenter - avatarSize / 2, avatarSize, avatarSize);
            if (_avatar != null)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(avatarRect);
                    g.SetClip(path);
                    g.DrawImage(_avatar, avatarRect);
                    g.ResetClip();
                }
            }
            else
            {
                // Fallback nếu không có ảnh
                g.FillEllipse(new SolidBrush(Color.LightGray), avatarRect);
            }

            // Họ tên & Username (Cộng thêm dấu chấm xanh nếu là tài khoản hiện tại)
            g.DrawString(UserData.FullName, fontBold, textBrush, new Point(120, yCenter - 18));
            
            if (_isCurrentUser)
            {
                SizeF nameSize = g.MeasureString(UserData.FullName, fontBold);
                int dotX = 120 + (int)nameSize.Width + 5;
                g.FillEllipse(new SolidBrush(Color.FromArgb(52, 168, 83)), dotX, yCenter - 10, 8, 8);
            }

            g.DrawString(UserData.Username, fontSmall, subTextBrush, new Point(120, yCenter + 2));

            // Email
            g.DrawString(UserData.Email, fontRegular, textBrush, new Rectangle(350, 0, 200, this.Height), sfLeft);

            // Vai trò (Badge)
            Rectangle roleRect = new Rectangle(600, yCenter - 15, 90, 30);
            Color roleBg, roleText;
            if (UserData.Role == "SuperAdmin" || UserData.Role == "Admin")
            {
                roleBg = Color.FromArgb(243, 232, 255); // Tím nhạt
                roleText = Color.FromArgb(107, 33, 168);
            }
            else
            {
                roleBg = Color.FromArgb(232, 240, 254); // Xanh biển nhạt
                roleText = Color.FromArgb(25, 103, 210);
            }
            using (GraphicsPath path = CreateRoundedRectPath(roleRect, 10))
            {
                g.FillPath(new SolidBrush(roleBg), path);
                sfCenter.Alignment = StringAlignment.Center;
                g.DrawString(UserData.Role, fontSmall, new SolidBrush(roleText), roleRect, sfCenter);
            }

            // Trạng thái (Badge)
            Rectangle statusRect = new Rectangle(760, yCenter - 15, 90, 30);
            Color statusBg, statusText;
            if (UserData.IsActive)
            {
                statusBg = Color.FromArgb(220, 252, 231); // Xanh lá nhạt
                statusText = Color.FromArgb(22, 101, 52);
            }
            else
            {
                statusBg = Color.FromArgb(254, 242, 242); // Đỏ nhạt
                statusText = Color.FromArgb(153, 27, 27);
            }
            using (GraphicsPath path = CreateRoundedRectPath(statusRect, 10))
            {
                g.FillPath(new SolidBrush(statusBg), path);
                g.DrawString(UserData.IsActive ? "Hoạt động" : "Bị khóa", fontSmall, new SolidBrush(statusText), statusRect, sfCenter);
            }

            // Lần đăng nhập cuối
            string lastLoginText = UserData.LastLogin.HasValue ? UserData.LastLogin.Value.ToString("dd/MM/yyyy HH:mm") : "-";
            g.DrawString(lastLoginText, fontRegular, textBrush, new Rectangle(900, 0, 150, this.Height), sfLeft);

            // Nút Thao tác (3 chấm)
            _actionRect = new Rectangle(1100, yCenter - 15, 30, 30);
            using (GraphicsPath path = CreateRoundedRectPath(_actionRect, 5))
            {
                g.FillPath(new SolidBrush(Color.White), path);
                g.DrawPath(new Pen(Color.FromArgb(220, 220, 220)), path);
            }
            // Vẽ 3 chấm
            g.FillEllipse(new SolidBrush(Color.Gray), 1113, yCenter - 8, 4, 4);
            g.FillEllipse(new SolidBrush(Color.Gray), 1113, yCenter - 2, 4, 4);
            g.FillEllipse(new SolidBrush(Color.Gray), 1113, yCenter + 4, 4, 4);
        }

        private GraphicsPath CreateRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
