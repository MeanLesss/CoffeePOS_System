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
    public partial class SubReportForm : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext();
        string _invoiceNo = string.Empty;
        public SubReportForm(string invoiceNo)
        {
            InitializeComponent();
            this._invoiceNo = invoiceNo;
        }

        private void SubReportForm_Load(object sender, EventArgs e)
        {
            var orders = pos_context.Orders.Where(x=>x.InvoiceNo == _invoiceNo).ToList();

            // Clear the DataGridView before adding new data (if needed)
            dataGridViewItems.Rows.Clear();

            for (int i = 0; i < orders.Count; i++)
            {
                var order = orders[i];

                // Create a new row (this will add a new row to the DataGridView)
                int rowIndex = dataGridViewItems.Rows.Add();

                // Set the values for each cell in the new row
                dataGridViewItems.Rows[rowIndex].Cells["Product"].Value = order.ProductName ?? "Unknown";  // Product Name
                dataGridViewItems.Rows[rowIndex].Cells["Price"].Value = order.Price ?? 0;           // Price
                dataGridViewItems.Rows[rowIndex].Cells["Qty"].Value = order.Qty;                             // Quantity
                dataGridViewItems.Rows[rowIndex].Cells["SubTotal"].Value = (order.Price ?? 0) * order.Qty;  // SubTotal = Price * Qty

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
        }
    }
}
