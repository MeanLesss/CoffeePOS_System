using CoffeePOS_System.Components;
using CoffeePOS_System.DB_Context;
using CoffeePOS_System.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Animation;

namespace CoffeePOS_System
{
    public partial class MainMenu : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext(); 
        List<Product> products = new List<Product>();
        List<Order> productCards = new List<Order>();
        List<Order> orders = new List<Order>();
        List<Category> categories = new List<Category>();
        LoginForm _loginForm;
        double rotation = 0.0;  
        DataSet cateDataset = new DataSet();

        Guid cateGuid = default;
        double _subTotal = 0.0;
        double _vat = 0.0;
        double _total = 0.0;

        public MainMenu()
        {
            InitializeComponent(); 
        }
        public MainMenu(LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_username.Text = Properties.Settings.Default.username;
            label_usercode.Text = Properties.Settings.Default.usercode;
            timer1.Start();
            PopulateCate();
          
            if(comboBoxCategory.SelectedValue != null)
            {
                cateGuid = (Guid)comboBoxCategory.SelectedValue ;
            } 
            GetProductByCate(cateGuid);
         
            //dataGridView_sales.DataSource = userList;
            //dataGridView_sales.Columns["Guid"].Visible = false;
        }

        private void UpdateProductLsit()
        {
            // Clear previous items in the panel to avoid duplicates
            flowLayoutPanel_item.Controls.Clear();

            // Add product cards to the flow layout panel
            foreach (var prod in productCards)
            {
                // Create card as Order 
                flowLayoutPanel_item.Controls.Add(new OrderItemCard_Component(prod, AddProductOrder, RemoveProductOrder)
                {
                    Name = prod.Product.Guid.ToString(),
                });
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            var i = 1; 
            MessageBox.Show("Test");
        }
        private void AddProductOrder(Order order)
        {
            try
            {
                if(order.Qty == 0)
                {
                    return;
                }
                if (!orders.Contains(order))
                {
                    orders.Add(order);
                }
                else
                {
                    orders.Find(x => x == order).Qty = order.Qty;
                }
                // Try to find the control using a loop
                OrderItemCard_Component foundCard = null;
                foreach (var control in flowLayoutPanel_item.Controls)
                {
                    if (control is OrderItemCard_Component card &&
                        card.Name.Equals(order.Product.Guid.ToString(), StringComparison.Ordinal))
                    {
                        foundCard = card;
                        break;
                    }
                }

                if (foundCard != null)
                {
                    foundCard.UpdateOrder(order); 
                }
                else
                {
                    // Optionally handle the case where the card was not found
                    Debug.WriteLine("Order item card not found for product: " + order.Product.Guid);
                }
                UpdateOrderListUI();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        private void RemoveProductOrder(Order order)
        {
            try
            {
                if (order == null)
                {
                    throw new ArgumentNullException(nameof(order), "Order cannot be null.");
                }
                if (order.Qty < 0)
                {
                    return; // Early return if quantity is invalid
                }

                // Check if the order exists in the list
                var existingOrder = orders.Find(x => x == order);
                if (existingOrder != null)
                {
                    if (order.Qty <= 0)
                    {
                        //orders.Remove(existingOrder); 
                        //orders.Clear();
                        ResetOrder();
                    }
                    else
                    {
                        existingOrder.Qty = order.Qty; // Update quantity if greater than zero
                    }

                    // Try to find the control and update it
                    var foundCard = flowLayoutPanel_item.Controls
                        .OfType<OrderItemCard_Component>()
                        .FirstOrDefault(card => card.Name.Equals(order.Product.Guid.ToString(), StringComparison.Ordinal));

                    if (foundCard != null)
                    {
                        foundCard.UpdateOrder(order); 
                    }
                    else
                    {
                        // Handle case where the card was not found
                        Debug.WriteLine("Order item card not found for product: " + order.Product.Guid);
                    }
                    UpdateOrderListUI();
                }
               

                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
         
        private void UpdateOrderListUI()
        {
            // Clear previous items in the panel to avoid duplicates
            flowLayoutPanelOrdered.Controls.Clear();

            // Add products to the flow layout panel
            double sub = 0.0;
            foreach (var order in orders)
            {
                if (order.Qty > 0)
                {
                    sub += (double)(order.Qty * order.Price);
                    TotalPriceCalculation(sub);
                    var itemCard = new OrderItemListItem_Component(order, AddProductOrder, RemoveProductOrder)
                    {
                        Name = order.Product.Guid.ToString()
                    };
                    flowLayoutPanelOrdered.Controls.Add(itemCard);
                }
            } 
        }


        private void iconButtonSettingMenu_MouseHover(object sender, EventArgs e)
        {
             var input = sender as FontAwesome.Sharp.IconButton;
            if (input != null)
            {
                input.IconColor = Color.Black;
            }

        }

        private void iconButtonSettingMenu_MouseLeave(object sender, EventArgs e)
        {
            var input = sender as FontAwesome.Sharp.IconButton;
            if (input != null)
            {
                input.IconColor = Color.Black;
            }
        }

        private void iconButtonSettingMenu_Click(object sender, EventArgs e)
        {
                var menu = new PopUpMenu(this);
                DialogResult result = menu.ShowDialog();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotation += 5;
            if(rotation == 360) rotation = 0;
            iconButtonSettingMenu.Rotation = rotation;
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void PopulateCate()
        {
            categories = pos_context.Categories.Where(x => x.Status == 1).OrderBy(x => x.Name).ToList();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name"; // Property to display
            comboBoxCategory.ValueMember = "Guid";
            if (categories.Any())
            {
                comboBoxCategory.SelectedValue = categories[0].Guid;
            }

        }
        private void GetProductByCate(Guid cateGuid = default)
        {
            // Guard clause for invalid category GUID
            if (cateGuid == Guid.Empty && cateGuid != default)
            {
                MessageBox.Show("Invalid category GUID.");
                return;
            }

            IQueryable<Product> queryProducts = pos_context.Products;

            // Filter by category GUID and status
            if (cateGuid == default)
            {
                queryProducts = queryProducts.Where(x => x.Status == 1).OrderBy(x => x.Name);
            }
            else
            {
                queryProducts = queryProducts
                    .Where(x => x.CategoryGuid == cateGuid && x.Status == 1)
                    .OrderBy(x => x.Name);
            }

            // Clear previous product cards
            productCards.Clear();

            // Retrieve products with pagination
            products = queryProducts.ToList();

            // Guard clause for no products found
            if (products.Count == 0)
            {
                MessageBox.Show("No products found for the selected category.");
                return;
            }

            // Add products to the productCards collection
            foreach (var item in products)
            {
                var order = new Order() { 
                    Qty = 0,
                    Product = item,Price = item.Price 
                };
                productCards.Add(order);
            }
            UpdateProductLsit();
           
        }


        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                ComboBox comboBox = sender as ComboBox;
                if (categories.Any() && comboBox != null && Guid.TryParse(comboBox.SelectedValue.ToString(), out Guid value))
                {
                    GetProductByCate(value);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void TotalPriceCalculation(double subTotal)
        {
            _subTotal = subTotal;
            _vat = (_subTotal * 0.10);
            _total = (_subTotal + _vat);

            labelSubTotal.Text = _subTotal.ToString("C2");
            labelTax.Text = _vat.ToString("C2"); 
            labelTotal.Text = _total.ToString("C2"); // Subtotal + Tax
        }
        private void ResetOrder(bool clearAll =false)
        {
            if (clearAll && orders != null)
            {
                orders.Clear();
            }
            _subTotal = 0.0;
            _vat = 0.0;
            _total = 0.0; 
            labelSubTotal.Text = _subTotal.ToString("C2");
            labelTax.Text = _vat.ToString("C2");
            labelTotal.Text = _total.ToString("C2"); // Subtotal + Tax

        }


        private void iconButtonPay_Click(object sender, EventArgs e)
        {
            try
            { 
                if (orders == null || !orders.Any())
                {
                    MessageBox.Show("There no order yet!");
                    return;
                }
                // Assuming `Invoice` has an auto-increment ID
                //var invoices = pos_context.Invoices.Select(x=>x.Id).ToList();
                //int newInvoiceId = invoices.Count(); // Retrieve the latest ID and increment 

                DialogResult returnMsg = MessageBox.Show("Are you sure to proceed?", "Transaction", MessageBoxButtons.YesNo);
                // Submit changes to the database
                if (returnMsg == DialogResult.Yes)
                { 
                   var resutlDia = new InvoiceForm(orders,_total).ShowDialog(); 
                    if(resutlDia == DialogResult.Cancel)
                    {
                        ResetOrder(true);  
                    }
                } 
                MessageBox.Show("Transaction Completed.", "Transaction");
                orders.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Transaction failed due to : {ex.Message}","Transaction Error");
            }
          

            GetProductByCate(cateGuid);

            UpdateOrderListUI();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            ResetOrder(true);
            //Reset Product Qty 
            GetProductByCate(cateGuid); 
            UpdateOrderListUI();
        }
    }
}
