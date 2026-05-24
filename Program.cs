using Demo_template.Forms;
using System;
using System.Windows.Forms;

namespace Demo_template
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //вызов формы авторизации как диалогового окна (для избежания Hide(), который не завершает полностью работу программы)
            using (Login loginForm = new Login()) 
            {
                if (loginForm.ShowDialog() == DialogResult.OK) 
                {
                    string role = loginForm.SendRole();

                    MainForm mainForm = new MainForm();
                    mainForm.Role = role;

                    Application.Run(mainForm);
                }
            }
        }
    }
}