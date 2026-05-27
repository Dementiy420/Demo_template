using Demo_template;
using Demo_template.Forms;
using System.Data;

namespace Demo_entity
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
            


            //вызов формы авторизации как диалогового окна(для избежания Hide(), который не завершает полностью работу программы)
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