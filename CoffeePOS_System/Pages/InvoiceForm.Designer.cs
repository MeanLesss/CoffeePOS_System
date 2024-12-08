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
            this.panelItemList = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.iconButtonConfirm = new FontAwesome.Sharp.IconButton();
            this.panelQr.SuspendLayout();
            this.panelItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQr
            // 
            this.panelQr.Controls.Add(this.pictureBox1);
            this.panelQr.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelQr.Location = new System.Drawing.Point(0, 0);
            this.panelQr.Name = "panelQr";
            this.panelQr.Size = new System.Drawing.Size(328, 608);
            this.panelQr.TabIndex = 0;
            // 
            // panelItemList
            // 
            this.panelItemList.Controls.Add(this.iconButtonConfirm);
            this.panelItemList.Controls.Add(this.iconButtonCancel);
            this.panelItemList.Controls.Add(this.label1);
            this.panelItemList.Controls.Add(this.dataGridViewItems);
            this.panelItemList.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelItemList.Location = new System.Drawing.Point(327, 0);
            this.panelItemList.Name = "panelItemList";
            this.panelItemList.Size = new System.Drawing.Size(417, 608);
            this.panelItemList.TabIndex = 1;
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
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewItems.Size = new System.Drawing.Size(417, 452);
            this.dataGridViewItems.TabIndex = 0;
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
            // iconButtonCancel
            // 
            this.iconButtonCancel.BackColor = System.Drawing.Color.Salmon;
            this.iconButtonCancel.FlatAppearance.BorderSize = 0;
            this.iconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.iconButtonCancel.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancel.Location = new System.Drawing.Point(7, 549);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(137, 47);
            this.iconButtonCancel.TabIndex = 2;
            this.iconButtonCancel.Text = "Cancel";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
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
            this.iconButtonConfirm.Location = new System.Drawing.Point(268, 549);
            this.iconButtonConfirm.Name = "iconButtonConfirm";
            this.iconButtonConfirm.Size = new System.Drawing.Size(137, 47);
            this.iconButtonConfirm.TabIndex = 3;
            this.iconButtonConfirm.Text = "Confirm";
            this.iconButtonConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonConfirm.UseVisualStyleBackColor = false;
            this.iconButtonConfirm.Click += new System.EventHandler(this.iconButtonConfirm_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 608);
            this.Controls.Add(this.panelItemList);
            this.Controls.Add(this.panelQr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoiceForm";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.panelQr.ResumeLayout(false);
            this.panelItemList.ResumeLayout(false);
            this.panelItemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}