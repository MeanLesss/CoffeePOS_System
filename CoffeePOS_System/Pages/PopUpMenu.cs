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
        public PopUpMenu()
        {
            InitializeComponent();
        }

        private void iconButtonDrink_Click(object sender, EventArgs e)
        {
            this.Close();
            new DrinkSettings().Show();
        }

        private void iconButtonFood_Click(object sender, EventArgs e)
        {
            this.Close();
            new FoodSetting().Show();
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
            this.Close();
            new LoginForm().ShowDialog(); 
        }

        private void iconButtonLogoutExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
