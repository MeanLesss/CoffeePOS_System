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
            dataGridViewItems.DataSource = _orders;

        }

        private void iconButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            { 
                // Create and insert the invoice
                Invoice invoice = new Invoice
                {
                    Guid = Guid.NewGuid(),
                    Total = (decimal)_total,
                    Status = 1,
                };
                pos_context.Invoices.InsertOnSubmit(invoice);
                pos_context.SubmitChanges(); // Save the invoice to get InvoiceNo

                // Retrieve the inserted invoice to confirm the InvoiceNo
                invoice = pos_context.Invoices.FirstOrDefault(x => x.Guid == invoice.Guid);
                if (invoice == null)
                {
                    throw new Exception("Failed to retrieve the inserted invoice.");
                }

                // Update all orders with the new InvoiceNo
                foreach (var order in _orders)
                {
                    order.InvoiceNo = invoice.InvoiceNo;
                    order.InvoiceGuid = invoice.Guid;
                }
                    
                // Use SubmitChanges to save all modified orders
                pos_context.SubmitChanges(); // LINQ-to-SQL tracks changes automatically


                // Inform the user of success
                MessageBox.Show("Transaction completed successfully.", "Success");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show($"Transaction failed due to: {ex.Message}", "Transaction Error");
            }
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            _orders.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
