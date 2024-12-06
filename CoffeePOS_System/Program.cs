using CoffeePOS_System.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DrinkSettings());
            Application.Run(new LoginForm());
            //Application.Run(new MainMenu());
            //Application.Run(new Dashboard());
        }
    }
}
