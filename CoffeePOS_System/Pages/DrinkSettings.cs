using CoffeePOS_System.DB_Context;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS_System.Pages
{
    public partial class DrinkSettings : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext(); 
        List<Category> categories = new List<Category>();
        Guid selectedItem = Guid.Empty;
        public DrinkSettings()
        {
            InitializeComponent();
        }

        private void DrinkSettings_Load(object sender, EventArgs e)
        {
            dataGridView_Product.DataSource = pos_context.Products;
            categories = pos_context.Categories.Where(x => x.Status == 1).OrderBy(x => x.Name).ToList();
            comboBox_Category.DataSource = categories;
            comboBox_Category.DisplayMember = "Name"; // Property to display
            comboBox_Category.ValueMember = "Guid"; 
            RenderTable(); 
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conboBox = sender as ComboBox;
            if (conboBox != null && conboBox.SelectedValue != null) { 
                dataGridView_Product.DataSource = pos_context.Products.Where(x=>x.CategoryGuid.ToString() ==  conboBox.SelectedValue.ToString() ).ToList();
                RenderTable();        
            }
        }

        private void RenderTable()
        {
            HashSet<string> ignoreColumns = new HashSet<string> { "guid", "category", "categoryguid" };
            for (int i = 0; i < dataGridView_Product.Columns.Count; i++)
            {
                var columnName = dataGridView_Product.Columns[i].Name;
                if (ignoreColumns.Contains(columnName.ToLower()))
                {
                    // Hide the column if it's in the ignore list
                    dataGridView_Product.Columns[i].Visible = false;
                }
                else
                {
                    // Set AutoSizeMode for visible columns
                    dataGridView_Product.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            // Clear previous results in the DataGridView
            dataGridView_Product.DataSource = null;

            // Check if the search box is not empty
            if (!string.IsNullOrEmpty(textBox_SearchBox.Text) && comboBox_Category.SelectedIndex != null)
            {
                string searchTerm = textBox_SearchBox.Text.ToLower();

                // Filter products based on the search term
                var filteredProducts = pos_context.Products
                    .Where(p => p.Name.ToLower().Contains(searchTerm) &&
                                p.CategoryGuid.ToString() == comboBox_Category.SelectedIndex.ToString())
                    .ToList();

                // Set the filtered results as the data source
                dataGridView_Product.DataSource = filteredProducts;
            }
            else if(string.IsNullOrEmpty(textBox_SearchBox.Text) && comboBox_Category.SelectedIndex != null)
            {
                // If the search box is empty, display all products
                dataGridView_Product.DataSource = pos_context.Products
                    .Where(p => p.CategoryGuid.ToString() == comboBox_Category.SelectedIndex.ToString())
                    .ToList();
            }
            else
            {
                dataGridView_Product.DataSource = null;
            }
            RenderTable(); 
        }

        private void labelImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxProduct.Image != null)
            {
                labelImage.Visible = false;
                pictureBoxProduct.Image.Dispose();
                pictureBoxProduct.Image = null;
            }
            LoadImage(pictureBoxProduct);
        }
        private void LoadImage(PictureBox pictureBox)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of selected file
                string filePath = openFileDialog.FileName;

                // Display the image in the PictureBox
                pictureBox.Image = new Bitmap(filePath);
                pictureBoxProduct.ImageLocation = filePath;
                labelImage.Visible = false;
            }
        }
        private void LoadImage(Image image, string filePath)
        {
            // Display the image in the PictureBox
            labelImage.Visible = false;
            pictureBoxProduct.Image = image;
            pictureBoxProduct.ImageLocation = filePath;
        }
        private string SaveImage(Image image, string username)
        {
            try
            {
                // Define the destination path 
                string destinationPath = Path.Combine(Directory.GetCurrentDirectory(), $"SavedImages\\{username}").Replace("\\bin\\Debug", "");

                // Create the directory if it doesn't exist
                string destFile = "";
                Directory.CreateDirectory(destinationPath);
                if (pictureBoxProduct.Image != null)
                {    // Get the path of selected file
                    string filePath = pictureBoxProduct.ImageLocation;
                    // Generate a unique name for the file
                    //string fileName = Path.GetFileNameWithoutExtension(filePath) + "_" + Guid.NewGuid() + Path.GetExtension(filePath);
                    string fileName = Guid.NewGuid() + Path.GetExtension(filePath);

                    // Combine the destination directory with the unique file name
                    destFile = Path.Combine(destinationPath, fileName);

                    // Copy the file to the destination folder
                    File.Copy(filePath, destFile, true);
                }

                return destFile;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return "";
        }
        private void ClearAllInput()
        { 
            textBox_Name.Clear();
            textBox_stock.Clear();
            buttonDelete.Visible = false;
            checkBox_active.Checked = false;
            textBox_remark.Clear();
            textBox_description.Clear();
            textBox_price.Clear();
            button_Add.Text = "Add";
            dateTimePicker_Date.Value = DateTime.Now;
            pictureBoxProduct.Image = null;
            labelImage.Visible = true;
            label_id.Text = 0.ToString();
        }
        private void dataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = sender as DataGridView;

            // Check if the click was on a valid row (not the header and not a new row)
            if (dataGrid != null && e.RowIndex >= 0 && !dataGrid.Rows[e.RowIndex].IsNewRow)
            {
                var selectedRow = dataGrid.Rows[e.RowIndex];

                // Cast the DataBoundItem to your object type
                var selectedData = selectedRow.DataBoundItem as Product;

                // Now selectedData holds the object from the clicked row
                // You can now use selectedData here
            }

            ClearAllInput();
            button_Add.Text = "Update";
            buttonDelete.Visible = true;
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = dataGridView_Product.Rows[e.RowIndex];
                // Create an object to store the data
                var dataObject = new
                {
                    ID = row.Cells["ID"].Value,
                    Guid = row.Cells["Guid"].Value,
                    Name = row.Cells["Name"].Value,
                    Price = row.Cells["Price"].Value,
                    Stock = row.Cells["StockCount"].Value,
                    ImportDate = row.Cells["ImportDate"].Value,
                    Status = row.Cells["Status"].Value,
                    CateGuid = row.Cells["CategoryGuid"].Value,
                    ImagePath = row.Cells["ImagePath"].Value,
                };
                selectedItem = (Guid)dataObject.Guid;
                label_id.Text = dataObject.ID.ToString();
                textBox_Name.Text = dataObject.Name.ToString();
                textBox_stock.Text = dataObject.Stock.ToString();
                textBox_price.Text = dataObject.Price.ToString();
                dateTimePicker_Date.Value = dataObject.ImportDate != null ? (DateTime)dataObject.ImportDate : DateTime.Now ;
                checkBox_active.Checked = (byte)dataObject.Status == 1 ? true : false;
                if (dataObject.ImagePath != null &&  !string.IsNullOrEmpty(dataObject.ImagePath.ToString()))
                {
                    SetImageToPictureBox(pictureBoxProduct, dataObject.ImagePath.ToString());
                    //labelImage.Visible = false;
                }

                //pictureBoxProduct.Image = (Image)dataObject.Image;
                //pictureBoxProduct.ImageLocation = dataObject.ImagePath.ToString(); 
            }
        }
      
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAllInput();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Guid categoryGuid;

            // Attempt to parse the selected value of the combo box into a Guid
            if (!Guid.TryParse(comboBox_Category.SelectedValue.ToString(), out categoryGuid))
            {
                MessageBox.Show("Invalid category selection.");
                return; // Exit early to prevent further execution
            }

            // Attempt to parse the price from the text box
            decimal? parsedPrice = null;
            if (!string.IsNullOrWhiteSpace(textBox_price.Text))
            {
                if (!decimal.TryParse(textBox_price.Text, out decimal tempPrice))
                {
                    MessageBox.Show("Invalid price value.");
                    return; // Exit early
                }
                parsedPrice = tempPrice;
            }

            int? parsedStock = null;
            if (!string.IsNullOrWhiteSpace(textBox_stock.Text))
            {
                if (!int.TryParse(textBox_stock.Text, out int tempStock))
                {
                    MessageBox.Show("Invalid stock value.");
                    return; // Exit early
                }
                parsedStock = tempStock;
            }

            // Create a product object
            var product = new Product
            {
                CategoryGuid = categoryGuid,
                Description = textBox_description.Text,
                ImportDate = dateTimePicker_Date.Value,
                Name = textBox_Name.Text,
                Price = parsedPrice,
                Remark = textBox_remark.Text,
                StockCount = parsedStock,
                Status = checkBox_active.Checked ? (byte?)1 : 0,
                ImagePath = SaveImage(pictureBoxProduct.Image, textBox_Name.Text),
                Guid = Guid.NewGuid() // Or use an existing Guid if updating
            };

            try
            {
                // Check if the product already exists based on a unique identifier (e.g., Name or Guid)
                var existingProduct = pos_context.Products.FirstOrDefault(p => p.Name == product.Name);

                if (existingProduct != null)
                {
                    // Update existing product
                    existingProduct.CategoryGuid = categoryGuid;
                    existingProduct.Description = product.Description;
                    existingProduct.ImportDate = product.ImportDate;
                    existingProduct.Price = parsedPrice;
                    existingProduct.Remark = product.Remark;
                    existingProduct.StockCount = parsedStock;
                    existingProduct.Status = product.Status;
                    existingProduct.ImagePath = product.ImagePath;

                }
                else
                {
                    // Insert new product
                    pos_context.Products.InsertOnSubmit(product);
                }

                // Submit changes to the database
                pos_context.SubmitChanges();

                // Refresh the DataGridView
                dataGridView_Product.DataSource = pos_context.Products;

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

        public void SetImageToPictureBox(PictureBox pictureBox, string imagePath)
        {
            try
            {
                // Load the image from the specified path and set it to the PictureBox
                pictureBox.Image = Image.FromFile(imagePath);
                labelImage.Visible = false;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading image: {ex.Message}");
                pictureBox.Image = null; // Clear the image if there's an error
                labelImage.Visible = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure to delete this item?","Delete Confirmation",MessageBoxButtons.YesNo);
            if(confirmation == DialogResult.No)
            {
                MessageBox.Show("Delete Cancelled!");
                return;
            }

            try
            {
                // Check if the product already exists based on a unique identifier (e.g., Name or Guid)
                var existingProduct = pos_context.Products.FirstOrDefault(p => p.Guid == selectedItem);
 
                // Insert new product
                pos_context.Products.DeleteOnSubmit(existingProduct);

                // Submit changes to the database
                pos_context.SubmitChanges();

                // Refresh the DataGridView
                dataGridView_Product.DataSource = pos_context.Products;

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
    }
}
