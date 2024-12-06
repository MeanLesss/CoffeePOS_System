using CoffeePOS_System.DB_Context;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS_System.Components
{
    public partial class OrderItemListItem_Component : UserControl
    {
        private EventHandler _eventAdd;
        private EventHandler _eventMinus;
        private EventHandler _eventView;
        public int _totalItemCount { get; set; }
        Order _order;
        private Action<Order> _updateProductOrder;
        private Action<Order> _removeProductOrder;
        public OrderItemListItem_Component()
        {
            InitializeComponent();
        }
        public OrderItemListItem_Component(Order selectProd, Action<Order> updateProductOrder = null, Action<Order> removeProductOrder = null)
        {
            _order = selectProd;
            _updateProductOrder = updateProductOrder;
            _removeProductOrder = removeProductOrder;
            InitializeComponent();
            InitUI();
        }
        private void InitUI()
        {
            label_Item_Name.Text = _order.Product.Name;
            labelPrice.Text = _order.Product.Price.Value.ToString("C2");
            textBoxQty.Text = _order.Qty.ToString();
            iconPictureBoxProd.WaitOnLoad = true;
            SetImageToPictureBox(iconPictureBoxProd,_order.Product.ImagePath);
        }
        public void SetImageToPictureBox(IconPictureBox pictureBox, string imagePath)
        {
            try
            {
                // Load the image from the specified path and set it to the PictureBox
                pictureBox.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                //MessageBox.Show($"Error loading image: {ex.Message}");
                Console.WriteLine($"Error loading image: {ex.Message}");
                pictureBox.Image = null; // Clear the image if there's an error
            }
        }
        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            _totalItemCount = _totalItemCount > 0 ? --_totalItemCount : 0;
            textBoxQty.Text = _totalItemCount.ToString();
            _order.Qty = _totalItemCount;   
            this._removeProductOrder(_order);
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            _totalItemCount++;
            textBoxQty.Text = _totalItemCount.ToString();
            _order .Qty = _totalItemCount; 
            this._updateProductOrder(_order);
        }
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            var input = (TextBox)sender;
            int output = 0;

            // Check if the input text is a valid number
            if (int.TryParse(input.Text.Trim(), out output))
            {
                _totalItemCount = output;
            }
            else
            {
                _totalItemCount = output;
                // If not a valid number, reset the text to the last valid count
                input.TextChanged -= textBoxCount_TextChanged; // Temporarily remove the event handler
                input.Text = _totalItemCount.ToString();
                input.SelectionStart = input.Text.Length; // Move the cursor to the end
                input.TextChanged += textBoxCount_TextChanged; // Reattach the event handler
            }
        }

        private void iconButtonRemove_Click(object sender, EventArgs e)
        { 
            _totalItemCount = 0;
            textBoxQty.Text = _totalItemCount.ToString();
            _order.Qty = _totalItemCount;
            this._removeProductOrder(_order);
        }
    }
}
