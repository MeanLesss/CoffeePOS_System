namespace CoffeePOS_System
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.panel_top = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonSettingMenu = new FontAwesome.Sharp.IconButton();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel_item = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.iconButtonPay = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanelOrdered = new System.Windows.Forms.FlowLayoutPanel();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_top.Controls.Add(this.comboBoxCategory);
            this.panel_top.Controls.Add(this.label3);
            this.panel_top.Controls.Add(this.iconButtonSettingMenu);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1899, 70);
            this.panel_top.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "Name", true));
            this.comboBoxCategory.Font = new System.Drawing.Font("Samona", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(307, 22);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(268, 32);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(CoffeePOS_System.DB_Context.Category);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categories:";
            // 
            // iconButtonSettingMenu
            // 
            this.iconButtonSettingMenu.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonSettingMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonSettingMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButtonSettingMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButtonSettingMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettingMenu.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButtonSettingMenu.IconColor = System.Drawing.Color.Black;
            this.iconButtonSettingMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettingMenu.Location = new System.Drawing.Point(28, 11);
            this.iconButtonSettingMenu.Name = "iconButtonSettingMenu";
            this.iconButtonSettingMenu.Size = new System.Drawing.Size(49, 52);
            this.iconButtonSettingMenu.TabIndex = 0;
            this.iconButtonSettingMenu.UseVisualStyleBackColor = false;
            this.iconButtonSettingMenu.Click += new System.EventHandler(this.iconButtonSettingMenu_Click);
            this.iconButtonSettingMenu.MouseLeave += new System.EventHandler(this.iconButtonSettingMenu_MouseLeave);
            this.iconButtonSettingMenu.MouseHover += new System.EventHandler(this.iconButtonSettingMenu_MouseHover);
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataSource = typeof(CoffeePOS_System.DB_Context.Category);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 808);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1899, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_time
            // 
            this.toolStripStatusLabel_time.Name = "toolStripStatusLabel_time";
            this.toolStripStatusLabel_time.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel_time.Text = "Time";
            this.toolStripStatusLabel_time.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // flowLayoutPanel_item
            // 
            this.flowLayoutPanel_item.AutoScroll = true;
            this.flowLayoutPanel_item.BackColor = System.Drawing.Color.FloralWhite;
            this.flowLayoutPanel_item.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_item.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel_item.Name = "flowLayoutPanel_item";
            this.flowLayoutPanel_item.Size = new System.Drawing.Size(1311, 738);
            this.flowLayoutPanel_item.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelTotal);
            this.panel1.Controls.Add(this.flowLayoutPanelOrdered);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1314, 70);
            this.panel1.MaximumSize = new System.Drawing.Size(585, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(585, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 738);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(171, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 65);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arvo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Orders";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Lavender;
            this.panelTotal.Controls.Add(this.iconButtonPay);
            this.panelTotal.Controls.Add(this.iconButtonCancel);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.label5);
            this.panelTotal.Controls.Add(this.labelTax);
            this.panelTotal.Controls.Add(this.label6);
            this.panelTotal.Controls.Add(this.labelSubTotal);
            this.panelTotal.Controls.Add(this.label4);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(0, 549);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(585, 189);
            this.panelTotal.TabIndex = 1;
            // 
            // iconButtonPay
            // 
            this.iconButtonPay.BackColor = System.Drawing.Color.PaleGreen;
            this.iconButtonPay.FlatAppearance.BorderSize = 0;
            this.iconButtonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPay.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconButtonPay.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPay.Location = new System.Drawing.Point(372, 124);
            this.iconButtonPay.Name = "iconButtonPay";
            this.iconButtonPay.Size = new System.Drawing.Size(137, 47);
            this.iconButtonPay.TabIndex = 1;
            this.iconButtonPay.Text = "Pay Now";
            this.iconButtonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPay.UseVisualStyleBackColor = false;
            this.iconButtonPay.Click += new System.EventHandler(this.iconButtonPay_Click);
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
            this.iconButtonCancel.Location = new System.Drawing.Point(32, 124);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(137, 47);
            this.iconButtonCancel.TabIndex = 1;
            this.iconButtonCancel.Text = "Cancel";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTotal.Location = new System.Drawing.Point(433, 72);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(76, 29);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "$0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(28, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(454, 41);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(55, 24);
            this.labelTax.TabIndex = 0;
            this.labelTax.Text = "$0.00";
            this.labelTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "VAT(10%)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(454, 13);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(55, 24);
            this.labelSubTotal.TabIndex = 0;
            this.labelSubTotal.Text = "$0.00";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sub Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelOrdered
            // 
            this.flowLayoutPanelOrdered.AutoScroll = true;
            this.flowLayoutPanelOrdered.Location = new System.Drawing.Point(0, 89);
            this.flowLayoutPanelOrdered.Name = "flowLayoutPanelOrdered";
            this.flowLayoutPanelOrdered.Size = new System.Drawing.Size(584, 700);
            this.flowLayoutPanelOrdered.TabIndex = 2;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(1311, 70);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 738);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 830);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.flowLayoutPanel_item);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_top);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kvae Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrdered;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton iconButtonSettingMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private FontAwesome.Sharp.IconButton iconButtonPay;
    }
}

