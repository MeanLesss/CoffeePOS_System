using CoffeePOS_System.DB_Context;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CoffeePOS_System.Components
{
    public partial class OrderItemCard_Component : UserControl
    {
        private Color _color;
        private int _widthEllipese = 20;
        private int _heightEllipse =20;
        //private Product _product;
        private Order _order;
        private EventHandler _eventAdd;
        private EventHandler _eventMinus;
        private EventHandler _eventView;
        public int _totalItemCount { get; set; } = 0;
        private Action<Order> _updateProductOrder;
        private Action<Order> _removeProductOrder;
        public OrderItemCard_Component()
        {
            //InitializeComponent();
            //_product = new Product();
            _order = new Order();
            UpdateBorder();
        }
        public OrderItemCard_Component(Order order , Action<Order> updateProductOrder = null, Action<Order> removeProductOrder = null)
        {
            InitializeComponent();
            _order  = order;
            _updateProductOrder = updateProductOrder;
            _removeProductOrder = removeProductOrder;
            UpdateBorder();
        }
        public OrderItemCard_Component(Order order, int widthEllipese = 20, int heightEllipse = 20, Color borderColor = default,
            Action<Order> updateProductOrder = null, Action<Order> removeProductOrder = null)
        {
            InitializeComponent();
            //_product = product;
            _order = order;
            _color = borderColor;
            _widthEllipese=widthEllipese;
            _heightEllipse= heightEllipse;
            _updateProductOrder = updateProductOrder;
            _removeProductOrder = removeProductOrder;   
            
            UpdateBorder();
        }
        void UserControl_Paint(object sender, PaintEventArgs e)
        {
            // Set the size of the UserControl
            //this.Size = new Size(200, 100); // Change this to your desired size

         

            // Draw a border around the UserControl
            int borderWidth = 5;
            Color borderColor = _color; // Change this to your desired border color
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                                       borderColor, borderWidth, ButtonBorderStyle.Solid,
                                       borderColor, borderWidth, ButtonBorderStyle.Solid,
                                       borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
        private void OrderItemCard_Component_Load(object sender, EventArgs e)
        {
            label_title.Text = _order.Product.Name;
            labelPrice.Text = _order.Product.Price.Value.ToString("C2");
            SetImageToPictureBox(iconPictureBoxItem,_order.Product.ImagePath);
            //label_title.Text = _product.Name;

            textBoxCount.Text = _totalItemCount.ToString();
            if (_eventAdd != null && _eventMinus != null && _eventView != null)
            {
                iconButtonMinus.Click += _eventMinus;
                iconButtonAdd.Click += _eventAdd;
            }

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

        public Image GetImageFromPath(string imagePath)
        {
            try
            {
                // Load the image from the specified path
                return Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, invalid image format)
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null; // Return null if there was an error
            }
        }

        private void UpdateBorder()
        {
            textBoxCount.BackColor = _color;
            _color = Color.Black;
            this.Paint += new PaintEventHandler(UserControl_Paint);
            Region = System.Drawing.Region.FromHrgn(GlobalCustomizeFuction.CreateRoundRectRgn(0, 0, Width, Height, _widthEllipese, _heightEllipse));

        }

        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            _totalItemCount =_totalItemCount > 0 ? --_totalItemCount : 0;

            textBoxCount.Text = _totalItemCount.ToString();
            _order.Qty = _totalItemCount; 
            //_order.Product = _product;
            //this._updateProductOrder(_totalItemCount, _product);
            this._removeProductOrder(_order);
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            _totalItemCount++;
            textBoxCount.Text = _totalItemCount.ToString();
            _order.Qty = _totalItemCount;  
            this._updateProductOrder(_order);
        }
        public void UpdateOrder(Order newOrderDetails)
        {
            // Update the UI elements or properties with the new order details
            this._order = newOrderDetails; // Assuming you have an Order property
                                          // Update UI elements, e.g., labels, text boxes, etc.
            textBoxCount.Text = _order.Qty.ToString();
        }
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            var input = (TextBox)sender;
            int output = 0;
            
            // Check if the input text is a valid number
            if (int.TryParse(input.Text.Trim(), out output))
            {
                _totalItemCount = output;
                input.Text = _totalItemCount.ToString();
                _order.Qty = _totalItemCount;
                this._updateProductOrder(_order);
            }
            else
            {
                _totalItemCount = 0; 
                _order.Qty = _totalItemCount;
                this._removeProductOrder(_order);
                // If not a valid number, reset the text to the last valid count
                input.TextChanged -= textBoxCount_TextChanged; // Temporarily remove the event handler
                input.Text = _totalItemCount.ToString();
                input.SelectionStart = input.Text.Length; // Move the cursor to the end
                input.TextChanged += textBoxCount_TextChanged; // Reattach the event handler
            }
        }
    }
}
