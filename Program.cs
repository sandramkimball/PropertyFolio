using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyFolio
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms.LoginForm loginForm = new Forms.LoginForm();

            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Forms.MainForm());
            }
            
        }
    }
}
