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
    public partial class InvoiceForm : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext();
        List<Order> _orders = new List<Order>();
        double recived =  0.0;
        double change = 0.0;
        double _total = 0;
        public InvoiceForm(List<Order> orders,double total)
        {
            InitializeComponent();
            _orders = orders;
            _total = total;
        }
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            var newOrders = new List<Order>();
            // Clear the DataGridView before adding new data (if needed)
            dataGridViewItems.Rows.Clear();

            for (int i = 0; i < _orders.Count; i++)
            {
                var order = _orders[i];

                // Create a new row (this will add a new row to the DataGridView)
                int rowIndex = dataGridViewItems.Rows.Add();

                // Set the values for each cell in the new row
                dataGridViewItems.Rows[rowIndex].Cells["Product"].Value = order.Product?.Name ?? "Unknown";  // Product Name
                dataGridViewItems.Rows[rowIndex].Cells["Price"].Value = order.Product?.Price ?? 0;           // Price
                dataGridViewItems.Rows[rowIndex].Cells["Qty"].Value = order.Qty;                             // Quantity
                dataGridViewItems.Rows[rowIndex].Cells["SubTotal"].Value = (order.Product?.Price ?? 0) * order.Qty;  // SubTotal = Price * Qty

                // Apply striping: alternate row colors
                dataGridViewItems.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;  // Set light gray for even rows
                if (i % 2 == 0) // Even rows (0, 2, 4, ...)
                {
                    dataGridViewItems.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;  // Set light gray for even rows
                }
                else // Odd rows (1, 3, 5, ...)
                {
                    dataGridViewItems.Rows[rowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;     // Set white for odd rows
                }
            }
            //RenderTable();
            label_total.Text = _total.ToString("C");

        }
        private void RenderTable()
        { 
            HashSet<string> showColumns = new HashSet<string> { "" };
            for (int i = 0; i < dataGridViewItems.Columns.Count; i++)
            {
                var columnName = dataGridViewItems.Columns[i].Name;
                if (showColumns.Contains(columnName.ToLower()))
                {
                    // Hide the column if it's in the ignore list
                    dataGridViewItems.Columns[i].Visible = true;
                    dataGridViewItems.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dataGridViewItems.Columns[i].Visible = false; 
                }
            }
        }

        private void iconButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(textBox_receive.Text) || !decimal.TryParse(textBox_receive.Text, out decimal receivedAmount))
                {
                    label_error.Text = "Please input a valid received amount!";
                    label_error.Visible = true;
                    return;
                }

                // Ensure received amount is enough
                if (receivedAmount < (decimal)_total)
                {
                    label_error.Text = "Received amount is less than the total.";
                    label_error.Visible = true;
                    return;
                }

                // Calculate change
                decimal change = receivedAmount - (decimal)_total;

                // Use a single DataContext instance
                using (var pos_context = new Coffee_POSDataContext())
                {
                    // Create and insert the invoice
                    Invoice invoice = new Invoice
                    {
                        Guid = Guid.NewGuid(),
                        Total = (decimal)_total,
                        Status = 1,
                        ChangeAmount = change,
                        OrderByCode = Properties.Settings.Default.usercode,
                        PaidDate = DateTime.Now
                    };
                    pos_context.Invoices.InsertOnSubmit(invoice);
                    pos_context.SubmitChanges(); // Save the invoice to get InvoiceNo

                    // Retrieve the inserted invoice to confirm the InvoiceNo
                    invoice = pos_context.Invoices.FirstOrDefault(x => x.Guid == invoice.Guid);
                    if (invoice == null)
                    {
                        throw new Exception("Failed to retrieve the inserted invoice.");
                    }

                    var newOrders = new List<Order>();

                    foreach (var order in _orders)
                    {
                        // Create a new Order object without the Product reference
                        var newOrder = order;
                        newOrder.Guid = Guid.NewGuid();
                        newOrder.OrderDate = DateTime.Now;
                        newOrder.ProductGuid = order.ProductGuid;
                        newOrder.ProductName = order.Product.Name;
                        newOrder.Price = order.Product.Price;
                        newOrder.Status = (byte)1;
                        newOrder.OrderBy = Properties.Settings.Default.username;
                        newOrder.OrderByCode = Properties.Settings.Default.usercode;
                        newOrder.InvoiceGuid = invoice.Guid;
                        newOrder.InvoiceNo = invoice.Id.ToString();

                        // Add the new order to the new list
                        newOrder.Product = null;
                        newOrders.Add(newOrder);
                    }

                    // Insert the new list of orders in a batch
                    pos_context.Orders.InsertAllOnSubmit(newOrders);
                    pos_context.SubmitChanges(); // Save all new orders
                }

                // Inform the user of success
                MessageBox.Show($"Transaction completed successfully.\nChange: {change:C}", "Success");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"Transaction failed due to: {ex.Message}", "Transaction Error");
            }

        }


        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            _orders.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox_receive_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, a control key, or a decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
            else
            {
                // Allow only one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_receive_TextChanged(object sender, EventArgs e)
        {
            recived = double.TryParse(textBox_receive.Text, out double parsed) ? parsed : 0.0;
            change = 0.0;
            if (_total <= recived)
            {
                change = recived - _total;
                textBox_changes.Text = change.ToString("N2");
                label_error.Visible = false;

            }
            else
            {
                change = 0;
                textBox_changes.Text = change.ToString("N2");
                label_error.Text = ("The receive amount is not enough!");
                label_error.Visible = true;
            }
        }
    }
}
