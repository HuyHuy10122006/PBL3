using exambank.ui;

namespace test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormDangNhap login = new FormDangNhap();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormGiaoVien());
            }
        }
    }
}