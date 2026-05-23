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

            using (Login loginForm = new Login()) 
            {
                if (loginForm.ShowDialog() == DialogResult.OK) 
                {
                        if (loginForm.ShowDialog() == DialogResult.OK)                    
                            Application.Run(new MainForm());
                }
            }
        }
    }
}