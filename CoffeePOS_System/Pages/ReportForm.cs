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
    public partial class ReportForm : Form
    {
        Coffee_POSDataContext pos_context = new Coffee_POSDataContext();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {  
            dataGridViewReport.DataSource = pos_context.Invoices.OrderBy(x=>x.Id); 
        }

        private void dataGridViewReport_CellClick(object sender, DataGridViewCellEventArgs e)
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
             
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = dataGridViewReport.Rows[e.RowIndex];
                //ID = row.Cells["ID"].Value
                new SubReportForm(row.Cells["InvoiceNo"].Value.ToString()).ShowDialog();
                // Create an object to store the data

            }
        }
    }
}
