namespace exambank.ui
{
    partial class FormXemDe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpQuestions = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpQuestions
            // 
            flpQuestions.AutoScroll = true;
            flpQuestions.Dock = DockStyle.Fill;
            flpQuestions.FlowDirection = FlowDirection.TopDown;
            flpQuestions.Location = new Point(0, 35);
            flpQuestions.Name = "flpQuestions";
            flpQuestions.Size = new Size(1120, 511);
            flpQuestions.TabIndex = 0;
            flpQuestions.WrapContents = false;
            // 
            // FormXemDe
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1120, 546);
            Controls.Add(flpQuestions);
            Name = "FormXemDe";
            Text = "FormXemDe";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpQuestions;
    }
}