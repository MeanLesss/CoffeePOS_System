using CoffeePOS_System.DB_Context;
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
    public partial class CategorySetting : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext();
        List<Category> categories = new List<Category>();
        Guid selectedItem = Guid.Empty;
        public CategorySetting()
        {
            InitializeComponent();
        }

        private void CategorySetting_Load(object sender, EventArgs e)
        {
            dataGridView_Cate.DataSource = pos_context.Categories;

            RenderTable();
        }
        private void RenderTable()
        {
            HashSet<string> ignoreColumns = new HashSet<string> { "guid" };
            for (int i = 0; i < dataGridView_Cate.Columns.Count; i++)
            {
                var columnName = dataGridView_Cate.Columns[i].Name;
                if (ignoreColumns.Contains(columnName.ToLower()))
                {
                    // Hide the column if it's in the ignore list
                    dataGridView_Cate.Columns[i].Visible = false;
                }
                else
                {
                    // Set AutoSizeMode for visible columns
                    dataGridView_Cate.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void dataGridView_Cate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataGrid = sender as DataGridView;

            // Check if the click was on a valid row (not the header and not a new row)
            if (dataGrid != null && e.RowIndex >= 0 && !dataGrid.Rows[e.RowIndex].IsNewRow)
            {
                var selectedRow = dataGrid.Rows[e.RowIndex];

                // Cast the DataBoundItem to your object type
                var selectedData = selectedRow.DataBoundItem as Category;

                // Now selectedData holds the object from the clicked row
                // You can now use selectedData here
            }

            ClearAllInput();
            button_Add.Text = "Update";
            buttonDelete.Visible = true;
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = dataGridView_Cate.Rows[e.RowIndex];
                // Create an object to store the data
                var dataObject = new
                {
                    ID = row.Cells["ID"].Value,
                    Guid = row.Cells["Guid"].Value,
                    Name = row.Cells["Name"].Value, 
                    Status = row.Cells["Status"].Value, 
                };
                selectedItem = (Guid)dataObject.Guid;
                textBox_Name.Text = dataObject.Name.ToString();
                checkBox_active.Checked = (byte)dataObject.Status == 1 ? true : false;
                 
            }

        }
        private void ClearAllInput()
        {
            textBox_Name.Clear(); 
            buttonDelete.Visible = false;
            checkBox_active.Checked = false; 
            button_Add.Text = "Add"; 
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
                // Check if the product already exists based on a unique identifier (e.g., Name or Guid)
                var existingProduct = pos_context.Categories.FirstOrDefault(p => p.Guid == selectedItem);

                // Insert new product
                pos_context.Categories.DeleteOnSubmit(existingProduct);

                // Submit changes to the database
                pos_context.SubmitChanges();

                // Refresh the DataGridView
                dataGridView_Cate.DataSource = pos_context.Categories;

                // Clear input fields
                ClearAllInput();
                RenderTable();

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

        private void button_Add_Click(object sender, EventArgs e)
        { 
             
            // Create a product object
            var category = new Category
            { 
                Name = textBox_Name.Text, 
                Status = checkBox_active.Checked ? (byte?)1 : 0, 
                Guid = Guid.NewGuid() // Or use an existing Guid if updating
            };

            try
            {
                // Check if the product already exists based on a unique identifier (e.g., Name or Guid)
                var existingProduct = pos_context.Categories.FirstOrDefault(p => p.Name == category.Name);

                if (existingProduct != null)
                {
                    // Update existing product
                    existingProduct.Name = category.Name;
                    existingProduct.Status = category.Status; 

                }
                else
                {
                    // Insert new product
                    pos_context.Categories.InsertOnSubmit(category);
                }

                // Submit changes to the database
                pos_context.SubmitChanges();

                // Refresh the DataGridView
                dataGridView_Cate.DataSource = pos_context.Categories;
                // Clear input fields
                ClearAllInput();
                RenderTable();
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            // Clear previous results in the DataGridView
            dataGridView_Cate.DataSource = null;

            // Check if the search box is not empty
            if (!string.IsNullOrEmpty(textBox_SearchBox.Text) )
            {
                string searchTerm = textBox_SearchBox.Text.ToLower();

                // Filter products based on the search term
                var filteredProducts = pos_context.Categories
                    .Where(p => p.Name.ToLower().Contains(searchTerm) )
                    .ToList();

                // Set the filtered results as the data source
                dataGridView_Cate.DataSource = filteredProducts;
            } 
            else
            {
                dataGridView_Cate.DataSource = pos_context.Categories;
            }
            RenderTable();
        }
    }
}
