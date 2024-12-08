using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS_System.Pages
{
    public partial class PopUpMenu : Form
    {
        MainMenu _mainMenu;
        public PopUpMenu(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void iconButtonDrink_Click(object sender, EventArgs e)
        {
            this.Close();
            new DrinkSettings().Show();
        }

        private void iconButtonFood_Click(object sender, EventArgs e)
        {
            this.Close();
            new ReportForm().Show();
        }

        private void iconButtonCate_Click(object sender, EventArgs e)
        {
            this.Close();
            new CategorySetting().Show();
        }

        private void iconButtonUser_Click(object sender, EventArgs e)
        {
            this.Close();
            new UserSettings().Show();
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.usercode = string.Empty;
            Properties.Settings.Default.username = string.Empty;
            Properties.Settings.Default.isLogout = true;
            Properties.Settings.Default.Save();
            _mainMenu.Hide();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
            new LoginForm().Show(); 
        }

        private void iconButtonLogoutExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.usercode = string.Empty;
            Properties.Settings.Default.username = string.Empty;
            Properties.Settings.Default.isLogout = true;
            Properties.Settings.Default.Save();
            _mainMenu.Close();
            Application.Exit();
        }

        private void iconButtonReport_Click(object sender, EventArgs e)
        {
            this.Close();
            new ReportForm().Show();

        }
    }
}
