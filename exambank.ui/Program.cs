using exambank.data;
using exambank.ui;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

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
            ApplicationConfiguration.Initialize();

            // Tự động Migrate/Tạo các bảng trong Database nếu chưa có
            try
            {
                using (var db = new ExamBankDbContext())
                {
                    db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo Database (có thể do sai kết nối hoặc mạng): " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể cho chạy tiếp hoặc return tùy ý
            }

            Application.Run(new FormDangNhap());
        }
    }
}