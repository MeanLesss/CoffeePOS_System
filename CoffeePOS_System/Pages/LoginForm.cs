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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void iconButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu(this).ShowDialog();
        }
    }
}
