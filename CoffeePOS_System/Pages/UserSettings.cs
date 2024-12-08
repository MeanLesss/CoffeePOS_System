using CoffeePOS_System.DB_Context;
using CoffeePOS_System.ENUM;
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
    public partial class UserSettings : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext();
        List<User> users = new List<User>();
        Guid selectedItem = Guid.Empty;
        public UserSettings()
        {
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            dataGridView_User.DataSource = pos_context.Users;
            comboBox_role.DataSource = Enum.GetValues(typeof(RoleEnum))
                               .Cast<RoleEnum>()
                               .Select(x => new { Value = x, Name = x.ToString() })
                               .ToList();

            comboBox_role.DisplayMember = "Name";
            comboBox_role.ValueMember = "Value";
            RenderTable();

        }
       
        private void button_Add_Click(object sender, EventArgs e)
        {  
            // Create a user object
            var user = new User
            { 
                Guid = Guid.NewGuid(), // Or use an existing Guid if updating
                Username = textBox_Name.Text,
                Password = textBox_password.Text,
                Role = comboBox_role.Text, 
                Status = checkBox_active.Checked ? (byte?)1 : 0
            };

            try
            {
                // Check if the user already exists based on a unique identifier (e.g., Name or Guid)
                var existinguser = pos_context.Users.FirstOrDefault(p => p.Username == user.Username);

                if (existinguser != null)
                {
                    // Update existing user
                    existinguser.Username = user.Username;
                    existinguser.Password = user.Password; 
                    existinguser.Role = user.Role; 
                    existinguser.Status = user.Status; 

                }
                else
                {
                    // Insert new user
                    pos_context.Users.InsertOnSubmit(user);
                }

                // Submit changes to the database
                pos_context.SubmitChanges();

                // Refresh the DataGridView
                dataGridView_User.DataSource = pos_context.Users;
                RenderTable();
                // Clear input fields
                ClearAllInput();

                MessageBox.Show("Save Successfully!");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Any cleanup code if necessary
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAllInput();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.No)
            {
                MessageBox.Show("Delete Cancelled!");
                return;
            }

            try
            {
                // Check if the user already exists based on a unique identifier (e.g., Name or Guid)
                var existinguser = pos_context.Users.FirstOrDefault(p => p.Guid == selectedItem);

                // Insert new user
                pos_context.Users.DeleteOnSubmit(existinguser);

                // Submit changes to the database
                pos_context.SubmitChanges();

                // Refresh the DataGridView
                dataGridView_User.DataSource = pos_context.Users;

                // Clear input fields
                ClearAllInput();

                MessageBox.Show("Delete Successfully!");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Any cleanup code if necessary
            }
        }

        private void dataGridView_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                var dataGrid = sender as DataGridView;

                // Check if the click was on a valid row (not the header and not a new row)
                if (dataGrid != null && e.RowIndex >= 0 && !dataGrid.Rows[e.RowIndex].IsNewRow)
                {
                    var selectedRow = dataGrid.Rows[e.RowIndex];

                    // Cast the DataBoundItem to your object type
                    var selectedData = selectedRow.DataBoundItem as User;

                    // Now selectedData holds the object from the clicked row
                    // You can now use selectedData here
                }

                ClearAllInput();
                button_Add.Text = "Update";
                buttonDelete.Visible = true;
                if (e.RowIndex >= 0)
                {
                    // Get the clicked row
                    DataGridViewRow row = dataGridView_User.Rows[e.RowIndex];
                    // Create an object to store the data
                    var dataObject = new
                    {
                        ID = row.Cells["ID"].Value,
                        Guid = row.Cells["Guid"].Value,
                        Username = row.Cells["Username"].Value ?? "",
                        Password = row.Cells["Password"].Value ?? "",
                        Role = row.Cells["Role"].Value ?? "",
                        Status = row.Cells["Status"].Value ?? 0,
                        UserCode = row.Cells["UserCode"].Value ?? "",
                    };
                    selectedItem = (Guid)dataObject.Guid;
                    label_id.Text = dataObject.UserCode.ToString();
                    textBox_Name.Text = dataObject.Username.ToString();
                    textBox_password.Text = dataObject.Password.ToString();
                    textBox_usercode.Text = dataObject.UserCode.ToString();
                    checkBox_active.Checked = (byte)dataObject.Status == 1 ? true : false;

                }
            }
            catch (Exception ex)
            { 
                ClearAllInput();
                button_Add.Text = "Add";
                buttonDelete.Visible = false; 
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            // Clear previous results in the DataGridView
            dataGridView_User.DataSource = null;

            // Check if the search box is not empty
            if (!string.IsNullOrEmpty(textBox_SearchBox.Text) )
            {
                string searchTerm = textBox_SearchBox.Text.ToLower();

                // Filter products based on the search term
                var filteredProducts = pos_context.Users
                    .Where(p => p.Username.ToLower().Contains(searchTerm.ToLower()) || p.UserCode.ToLower().Contains(searchTerm))
                    .ToList();

                // Set the filtered results as the data source
                dataGridView_User.DataSource = filteredProducts;
            } 
            else
            {
                dataGridView_User.DataSource = pos_context.Users.ToList();
            }
            RenderTable();
        }
        private void RenderTable()
        {
            HashSet<string> ignoreColumns = new HashSet<string> { "guid" };
            for (int i = 0; i < dataGridView_User.Columns.Count; i++)
            {
                var columnName = dataGridView_User.Columns[i].Name;
                if (ignoreColumns.Contains(columnName.ToLower()))
                {
                    // Hide the column if it's in the ignore list
                    dataGridView_User.Columns[i].Visible = false;
                }
                else
                {
                    // Set AutoSizeMode for visible columns
                    dataGridView_User.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        private void ClearAllInput()
        {
            textBox_Name.Clear(); 
            buttonDelete.Visible = false;
            checkBox_active.Checked = false;
            textBox_password.Clear();
            textBox_usercode.Clear(); 
            button_Add.Text = "Add"; 
            label_id.Text = 0.ToString();
        }
    }
}
