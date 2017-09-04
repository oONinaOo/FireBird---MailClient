using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!FileHandler.checkAccountFile())
            {
                Application.Run(new LoginForm());
            }
            else
            {
                string accountInfo = FileHandler.getAccountInfo();
                Application.Run(new MainForm(FileHandler.getAccountInfo(), FileHandler.GetPassword(FileHandler.getAccountInfo())));

            }
        }
    }
}
