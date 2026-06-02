namespace exambank.ui.Common
{
    partial class UC_ExamCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // UC_ExamCard - vẽ hoàn toàn bằng OnPaint, không cần child controls
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "UC_ExamCard";
            this.Size = new System.Drawing.Size(280, 200);
            this.ResumeLayout(false);
        }
    }
}
