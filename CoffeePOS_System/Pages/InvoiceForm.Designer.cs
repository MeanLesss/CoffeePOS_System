namespace CoffeePOS_System.Pages
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelQr = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelItemList = new System.Windows.Forms.Panel();
            this.iconButtonConfirm = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_changes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQr
            // 
            this.panelQr.Controls.Add(this.pictureBox1);
            this.panelQr.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelQr.Location = new System.Drawing.Point(0, 0);
            this.panelQr.Name = "panelQr";
            this.panelQr.Size = new System.Drawing.Size(328, 730);
            this.panelQr.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeePOS_System.Properties.Resources.qr;
            this.pictureBox1.Location = new System.Drawing.Point(60, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelItemList
            // 
            this.panelItemList.Controls.Add(this.label_error);
            this.panelItemList.Controls.Add(this.label_total);
            this.panelItemList.Controls.Add(this.label4);
            this.panelItemList.Controls.Add(this.label3);
            this.panelItemList.Controls.Add(this.textBox_changes);
            this.panelItemList.Controls.Add(this.label2);
            this.panelItemList.Controls.Add(this.textBox_receive);
            this.panelItemList.Controls.Add(this.iconButtonConfirm);
            this.panelItemList.Controls.Add(this.iconButtonCancel);
            this.panelItemList.Controls.Add(this.label1);
            this.panelItemList.Controls.Add(this.dataGridViewItems);
            this.panelItemList.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelItemList.Location = new System.Drawing.Point(327, 0);
            this.panelItemList.Name = "panelItemList";
            this.panelItemList.Size = new System.Drawing.Size(417, 730);
            this.panelItemList.TabIndex = 1;
            // 
            // iconButtonConfirm
            // 
            this.iconButtonConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.iconButtonConfirm.FlatAppearance.BorderSize = 0;
            this.iconButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonConfirm.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfirm.Location = new System.Drawing.Point(272, 671);
            this.iconButtonConfirm.Name = "iconButtonConfirm";
            this.iconButtonConfirm.Size = new System.Drawing.Size(137, 47);
            this.iconButtonConfirm.TabIndex = 3;
            this.iconButtonConfirm.Text = "Confirm";
            this.iconButtonConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonConfirm.UseVisualStyleBackColor = false;
            this.iconButtonConfirm.Click += new System.EventHandler(this.iconButtonConfirm_Click);
            // 
            // iconButtonCancel
            // 
            this.iconButtonCancel.BackColor = System.Drawing.Color.Salmon;
            this.iconButtonCancel.FlatAppearance.BorderSize = 0;
            this.iconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButtonCancel.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancel.Location = new System.Drawing.Point(11, 671);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(137, 47);
            this.iconButtonCancel.TabIndex = 2;
            this.iconButtonCancel.Text = "Cancel";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kvae Shop";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Qty,
            this.SubTotal});
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewItems.Size = new System.Drawing.Size(417, 452);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // textBox_receive
            // 
            this.textBox_receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_receive.Location = new System.Drawing.Point(139, 584);
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.Size = new System.Drawing.Size(266, 26);
            this.textBox_receive.TabIndex = 4;
            this.textBox_receive.TextChanged += new System.EventHandler(this.textBox_receive_TextChanged);
            this.textBox_receive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_receive_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Receive amt $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change amt $";
            // 
            // textBox_changes
            // 
            this.textBox_changes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_changes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_changes.Location = new System.Drawing.Point(139, 630);
            this.textBox_changes.Name = "textBox_changes";
            this.textBox_changes.ReadOnly = true;
            this.textBox_changes.Size = new System.Drawing.Size(266, 26);
            this.textBox_changes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total + VAT";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(345, 556);
            this.label_total.Name = "label_total";
            this.label_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_total.Size = new System.Drawing.Size(64, 20);
            this.label_total.TabIndex = 8;
            this.label_total.Text = "Total $";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_error.Location = new System.Drawing.Point(136, 613);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(169, 13);
            this.label_error.TabIndex = 9;
            this.label_error.Text = "Please Input the received amount!";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 730);
            this.Controls.Add(this.panelItemList);
            this.Controls.Add(this.panelQr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.panelQr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelItemList.ResumeLayout(false);
            this.panelItemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private FontAwesome.Sharp.IconButton iconButtonConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_changes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}