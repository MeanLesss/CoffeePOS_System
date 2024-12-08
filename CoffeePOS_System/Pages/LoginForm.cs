using CoffeePOS_System.DB_Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS_System.Pages
{
    public partial class LoginForm : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext();
        private string random_pin = "";
        private int[] pins = new int[5];
        private string stringPin;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void iconButtonLogin_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(stringPin))
            {
                User foundUser = pos_context.Users.FirstOrDefault(x=>x.UserCode == stringPin); 
                if (foundUser != null)
                { 
                    if (checkBoxRemember.Checked == true)
                    { 
                        Properties.Settings.Default.isLogout = false; 
                    }
                    else
                    {
                        Properties.Settings.Default.isLogout = true;
                    }
                    Properties.Settings.Default.usercode = stringPin;
                    Properties.Settings.Default.username = foundUser.Username;
                    Properties.Settings.Default.Save(); 
                    this.Hide();
                    new MainMenu(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin!");
                }
            }
            else
            {
                MessageBox.Show("Please input your pin!");
            }
         
        }
        private void pin_input(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                TextBox input = sender as TextBox;
                if (input != null)
                {
                    string inputName = input.Name;
                    string indexStr = inputName.Contains("_") ? inputName.Split('_')[1] : "";
                    int inputOrder = 0;
                    if (!string.IsNullOrEmpty(indexStr))
                    {
                        index = int.Parse(indexStr);
                        int number;
                        if (int.TryParse(input.Text, out number))
                        {
                            pins[index] = number;
                        }
                    }
                    if (index == pins.Count() - 1)
                    {
                        stringPin = "";
                        for (var i = 0; i < pins.Count(); i++)
                        {
                            stringPin += pins[i];
                        }
                        Console.WriteLine(stringPin.ToString());
                    }
                    else
                    {
                        TextBox nextTextBox = this.Controls["textBoxPin_" + (index + 1)] as TextBox;
                        if (nextTextBox != null)
                        {
                            nextTextBox.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void textBoxPin_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                TextBox currentTextBox = sender as TextBox;
                if (currentTextBox != null && currentTextBox.Text.Length == 0)
                {
                    string inputName = currentTextBox.Name;
                    string indexStr = inputName.Contains("_") ? inputName.Split('_')[1] : "";
                    if (!string.IsNullOrEmpty(indexStr))
                    {
                        int index = int.Parse(indexStr);
                        if (index > 0)
                        {
                            TextBox previousTextBox = this.Controls["textBoxPin_" + (index - 1)] as TextBox;
                            if (previousTextBox != null)
                            {
                                previousTextBox.Focus();
                            }
                        }
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isLogout)
            {
                Properties.Settings.Default.usercode = string.Empty;
                Properties.Settings.Default.username = string.Empty; 
                Properties.Settings.Default.Save();
            }
            if(!string.IsNullOrEmpty(Properties.Settings.Default.usercode) && 
                !string.IsNullOrEmpty(Properties.Settings.Default.username))
            {
                this.Hide();
                new MainMenu(this).ShowDialog();
            } 
        }
    }
}
