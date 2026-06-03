using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using exambank.data.Models;

namespace exambank.ui.Common
{
    public partial class UC_ExamCard : UserControl
    {
        public ExamModel ExamData { get; private set; }
        public event EventHandler<ExamCardEventArgs> ActionClicked;

        private bool _showActions;
        private bool _isHovered = false;
        private readonly Color _accentColor;
        private readonly Color _accentColorLight;
        private readonly string _subjectIcon;

        // Màu sắc theo môn học
        private static readonly Dictionary<string, (Color primary, Color light, string icon)> SubjectThemes = new Dictionary<string, (Color, Color, string)>(StringComparer.OrdinalIgnoreCase)
        {
            { "Toán", (Color.FromArgb(66, 133, 244), Color.FromArgb(232, 240, 254), "∑") },
            { "Văn", (Color.FromArgb(234, 67, 53), Color.FromArgb(252, 232, 230), "✎") },
            { "Anh", (Color.FromArgb(52, 168, 83), Color.FromArgb(230, 244, 234), "🌐") },
            { "Lý", (Color.FromArgb(251, 188, 4), Color.FromArgb(254, 247, 224), "⚡") },
            { "Hóa", (Color.FromArgb(156, 39, 176), Color.FromArgb(243, 229, 245), "⚗") },
            { "Sinh", (Color.FromArgb(0, 150, 136), Color.FromArgb(224, 242, 241), "🧬") },
            { "Sử", (Color.FromArgb(255, 87, 34), Color.FromArgb(251, 233, 224), "📜") },
            { "Địa", (Color.FromArgb(33, 150, 243), Color.FromArgb(227, 242, 253), "🌍") },
            { "GDCD", (Color.FromArgb(121, 85, 72), Color.FromArgb(239, 235, 233), "⚖") },
            { "Tin", (Color.FromArgb(63, 81, 181), Color.FromArgb(232, 234, 246), "💻") },
        };

        public UC_ExamCard(ExamModel exam, bool showActions = true)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            
            ExamData = exam;
            _showActions = showActions;
            
            // Xác định theme theo môn
            if (SubjectThemes.TryGetValue(exam.Subject ?? "", out var theme))
            {
                _accentColor = theme.primary;
                _accentColorLight = theme.light;
                _subjectIcon = theme.icon;
            }
            else
            {
                _accentColor = Color.FromArgb(66, 133, 244);
                _accentColorLight = Color.FromArgb(232, 240, 254);
                _subjectIcon = "📝";
            }

            this.Size = new Size(280, 200);
            this.Margin = new Padding(12);
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.Transparent;

            // Hover events
            this.MouseEnter += (s, e) => { _isHovered = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { _isHovered = false; this.Invalidate(); };
            this.Click += Control_Click;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle cardRect = new Rectangle(4, 4, this.Width - 8, this.Height - 8);
            int radius = 16;

            // === SHADOW ===
            if (_isHovered)
            {
                using (var shadowPath = CreateRoundedRectPath(new Rectangle(cardRect.X + 2, cardRect.Y + 4, cardRect.Width, cardRect.Height), radius))
                using (var shadowBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                {
                    g.FillPath(shadowBrush, shadowPath);
                }
            }
            else
            {
                using (var shadowPath = CreateRoundedRectPath(new Rectangle(cardRect.X + 1, cardRect.Y + 2, cardRect.Width, cardRect.Height), radius))
                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    g.FillPath(shadowBrush, shadowPath);
                }
            }

            // === CARD BACKGROUND ===
            using (var cardPath = CreateRoundedRectPath(cardRect, radius))
            {
                using (var bgBrush = new SolidBrush(Color.White))
                {
                    g.FillPath(bgBrush, cardPath);
                }

                // === GRADIENT HEADER (phần trên) ===
                int headerHeight = 70;
                Rectangle headerRect = new Rectangle(cardRect.X, cardRect.Y, cardRect.Width, headerHeight);
                using (var headerPath = CreateRoundedRectTopPath(headerRect, radius))
                {
                    g.SetClip(headerPath);
                    using (var gradientBrush = new LinearGradientBrush(headerRect, _accentColor, Color.FromArgb(Math.Min(255, _accentColor.R + 40), Math.Min(255, _accentColor.G + 30), Math.Min(255, _accentColor.B + 20)), 45f))
                    {
                        g.FillRectangle(gradientBrush, headerRect);
                    }

                    // Pattern decoration nhỏ trên header
                    using (var patternBrush = new SolidBrush(Color.FromArgb(30, 255, 255, 255)))
                    {
                        g.FillEllipse(patternBrush, cardRect.Right - 60, cardRect.Y - 20, 80, 80);
                        g.FillEllipse(patternBrush, cardRect.Right - 100, cardRect.Y + 30, 50, 50);
                    }

                    g.ResetClip();
                }

                // === SUBJECT ICON trong header ===
                using (var iconFont = new Font("Segoe UI Emoji", 22f, FontStyle.Regular))
                using (var whiteBrush = new SolidBrush(Color.White))
                {
                    g.DrawString(_subjectIcon, iconFont, whiteBrush, cardRect.X + 16, cardRect.Y + 12);
                }

                // === SUBJECT NAME trên header ===
                using (var subjectFont = new Font("Segoe UI", 11f, FontStyle.Bold))
                using (var whiteBrush = new SolidBrush(Color.White))
                {
                    g.DrawString(ExamData.Subject ?? "Chưa rõ", subjectFont, whiteBrush, cardRect.X + 58, cardRect.Y + 18);
                }

                // === EXAM CODE trên header ===
                using (var codeFont = new Font("Segoe UI", 8.5f, FontStyle.Regular))
                using (var codeBrush = new SolidBrush(Color.FromArgb(200, 255, 255, 255)))
                {
                    g.DrawString($"Mã: {ExamData.ExamCode}", codeFont, codeBrush, cardRect.X + 58, cardRect.Y + 42);
                }

                // === STATUS BADGE ===
                if (ExamData.IsShared)
                {
                    string badgeText;
                    Color badgeBgColor;
                    Color badgeFgColor;

                    switch (ExamData.ApprovalStatus)
                    {
                        case ApprovalStatus.Pending:
                            badgeText = "⏳ Chờ duyệt";
                            badgeBgColor = Color.FromArgb(220, 255, 152, 0); // cam
                            badgeFgColor = Color.FromArgb(180, 95, 0);
                            break;
                        case ApprovalStatus.Approved:
                            badgeText = "✓ Đã duyệt";
                            badgeBgColor = Color.FromArgb(220, 76, 175, 80); // xanh
                            badgeFgColor = Color.White;
                            break;
                        case ApprovalStatus.Rejected:
                            badgeText = "✗ Từ chối";
                            badgeBgColor = Color.FromArgb(220, 244, 67, 54); // đỏ
                            badgeFgColor = Color.White;
                            break;
                        default:
                            badgeText = "Đã chia sẻ";
                            badgeBgColor = Color.FromArgb(180, 255, 255, 255);
                            badgeFgColor = _accentColor;
                            break;
                    }

                    using (var badgeFont = new Font("Segoe UI", 7.5f, FontStyle.Bold))
                    {
                        SizeF badgeSize = g.MeasureString(badgeText, badgeFont);
                        RectangleF badgeRect = new RectangleF(cardRect.Right - badgeSize.Width - 20, cardRect.Y + 8, badgeSize.Width + 12, badgeSize.Height + 4);
                        using (var badgePath = CreateRoundedRectPath(Rectangle.Round(badgeRect), 8))
                        using (var badgeBrush = new SolidBrush(badgeBgColor))
                        {
                            g.FillPath(badgeBrush, badgePath);
                        }
                        using (var badgeTextBrush = new SolidBrush(badgeFgColor))
                        {
                            g.DrawString(badgeText, badgeFont, badgeTextBrush, badgeRect.X + 6, badgeRect.Y + 2);
                        }
                    }
                }

                // === TITLE (phần dưới header) ===
                int titleY = cardRect.Y + headerHeight + 10;
                using (var titleFont = new Font("Segoe UI", 11f, FontStyle.Bold))
                using (var titleBrush = new SolidBrush(Color.FromArgb(33, 33, 33)))
                {
                    RectangleF titleRect = new RectangleF(cardRect.X + 16, titleY, cardRect.Width - 60, 44);
                    using (var sf = new StringFormat { Trimming = StringTrimming.EllipsisWord, FormatFlags = 0 })
                    {
                        g.DrawString(ExamData.Title, titleFont, titleBrush, titleRect, sf);
                    }
                }

                // === INFO CHIPS (Thời gian, Số câu) ===
                int infoY = cardRect.Y + headerHeight + 58;
                
                // Duration chip
                DrawInfoChip(g, $"⏱ {ExamData.Duration} phút", cardRect.X + 16, infoY, _accentColorLight, _accentColor);
                
                // Question count chip
                DrawInfoChip(g, $"📋 {ExamData.TotalQuestions} câu", cardRect.X + 130, infoY, _accentColorLight, _accentColor);

                // === AUTHOR (nếu có) ===
                if (ExamData.Author != null)
                {
                    int authorY = cardRect.Bottom - 28;
                    using (var authorFont = new Font("Segoe UI", 8f, FontStyle.Regular))
                    using (var authorBrush = new SolidBrush(Color.FromArgb(120, 120, 120)))
                    {
                        g.DrawString($"👤 {ExamData.Author.FullName}", authorFont, authorBrush, cardRect.X + 16, authorY);
                    }
                }

                // === MORE BUTTON (⋮) ===
                if (_showActions)
                {
                    Rectangle btnRect = new Rectangle(cardRect.Right - 38, cardRect.Y + headerHeight + 10, 28, 28);
                    _moreBtnRect = btnRect;
                    
                    Color btnBg = _isHovered ? Color.FromArgb(240, 240, 240) : Color.Transparent;
                    using (var btnPath = CreateRoundedRectPath(btnRect, 6))
                    using (var btnBrush = new SolidBrush(btnBg))
                    {
                        g.FillPath(btnBrush, btnPath);
                    }
                    using (var moreFont = new Font("Segoe UI", 14f, FontStyle.Bold))
                    using (var moreBrush = new SolidBrush(Color.FromArgb(100, 100, 100)))
                    {
                        var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        g.DrawString("⋮", moreFont, moreBrush, btnRect, sf);
                    }
                }

                // === HOVER BORDER ===
                if (_isHovered)
                {
                    using (var borderPen = new Pen(_accentColor, 2f))
                    {
                        g.DrawPath(borderPen, cardPath);
                    }
                }
                else
                {
                    using (var borderPen = new Pen(Color.FromArgb(230, 230, 230), 1f))
                    {
                        g.DrawPath(borderPen, cardPath);
                    }
                }
            }
        }

        private Rectangle _moreBtnRect;

        private void DrawInfoChip(Graphics g, string text, float x, float y, Color bgColor, Color textColor)
        {
            using (var chipFont = new Font("Segoe UI", 8.5f, FontStyle.Regular))
            {
                SizeF textSize = g.MeasureString(text, chipFont);
                RectangleF chipRect = new RectangleF(x, y, textSize.Width + 10, textSize.Height + 4);
                using (var chipPath = CreateRoundedRectPath(Rectangle.Round(chipRect), 8))
                using (var chipBrush = new SolidBrush(bgColor))
                {
                    g.FillPath(chipBrush, chipPath);
                }
                using (var textBrush = new SolidBrush(textColor))
                {
                    g.DrawString(text, chipFont, textBrush, x + 5, y + 2);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (_showActions && _moreBtnRect.Contains(e.Location))
            {
                ActionClicked?.Invoke(this, new ExamCardEventArgs(ExamData, "More", this));
            }
            else
            {
                ActionClicked?.Invoke(this, new ExamCardEventArgs(ExamData, "View"));
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            // Handled by OnMouseClick
        }

        // Tạo đường bo tròn 4 góc
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

        // Tạo đường bo tròn 2 góc trên
        private GraphicsPath CreateRoundedRectTopPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            path.CloseFigure();
            return path;
        }
    }

    public class ExamCardEventArgs : EventArgs
    {
        public ExamModel Exam { get; }
        public string Action { get; }
        public Control SourceControl { get; }

        public ExamCardEventArgs(ExamModel exam, string action, Control sourceControl = null)
        {
            Exam = exam;
            Action = action;
            SourceControl = sourceControl;
        }
    }
}
