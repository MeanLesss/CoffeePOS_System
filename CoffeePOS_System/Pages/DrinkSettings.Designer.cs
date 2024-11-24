namespace CoffeePOS_System.Pages
{
    partial class DrinkSettings
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.textBox_SearchBox = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_active = new System.Windows.Forms.CheckBox();
            this.textBox_remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.Black;
            this.button_Clear.Location = new System.Drawing.Point(1221, 282);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(105, 31);
            this.button_Clear.TabIndex = 25;
            this.button_Clear.Text = "Clear All";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(1110, 283);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(105, 31);
            this.button_Add.TabIndex = 23;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(151, 158);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(382, 31);
            this.dateTimePicker_Date.TabIndex = 22;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(151, 11);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(382, 31);
            this.textBox_Name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(3, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Click on the cell to show product detail";
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AllowUserToOrderColumns = true;
            this.dataGridView_Product.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Product.Location = new System.Drawing.Point(3, 107);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Product.Size = new System.Drawing.Size(1424, 340);
            this.dataGridView_Product.TabIndex = 27;
            this.dataGridView_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Product_CellClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(1177, 53);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(32, 25);
            this.label_id.TabIndex = 31;
            this.label_id.Text = "ID";
            this.label_id.Visible = false;
            // 
            // textBox_stock
            // 
            this.textBox_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stock.Location = new System.Drawing.Point(151, 94);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(382, 31);
            this.textBox_stock.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Stock AMT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Category);
            this.groupBox1.Controls.Add(this.dataGridView_Product);
            this.groupBox1.Controls.Add(this.textBox_SearchBox);
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1430, 450);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product list";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(20, 49);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(359, 33);
            this.comboBox_Category.TabIndex = 28;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // textBox_SearchBox
            // 
            this.textBox_SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchBox.Location = new System.Drawing.Point(457, 49);
            this.textBox_SearchBox.Name = "textBox_SearchBox";
            this.textBox_SearchBox.Size = new System.Drawing.Size(382, 31);
            this.textBox_SearchBox.TabIndex = 16;
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(862, 49);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(105, 31);
            this.button_Search.TabIndex = 23;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.Location = new System.Drawing.Point(45, 107);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(129, 25);
            this.labelImage.TabIndex = 34;
            this.labelImage.Text = "Insert image";
            this.labelImage.Click += new System.EventHandler(this.labelImage_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(204, 217);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 32;
            this.pictureBoxProduct.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1110, 320);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(216, 31);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelImage);
            this.groupBox2.Controls.Add(this.pictureBoxProduct);
            this.groupBox2.Location = new System.Drawing.Point(1110, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 245);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Image";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(391, 17);
            this.toolStripStatusLabel1.Text = "SU25_Kang_Sokvimean,Chhorn Pheareak,Yourk Sopheaktra,Yorn Ekpiseth";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 839);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1430, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.checkBox_active);
            this.panel1.Controls.Add(this.textBox_remark);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_description);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.textBox_stock);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.dateTimePicker_Date);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 835);
            this.panel1.TabIndex = 13;
            // 
            // checkBox_active
            // 
            this.checkBox_active.AutoSize = true;
            this.checkBox_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_active.Location = new System.Drawing.Point(151, 241);
            this.checkBox_active.Name = "checkBox_active";
            this.checkBox_active.Size = new System.Drawing.Size(90, 29);
            this.checkBox_active.TabIndex = 40;
            this.checkBox_active.Text = "Active";
            this.checkBox_active.UseVisualStyleBackColor = true;
            // 
            // textBox_remark
            // 
            this.textBox_remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_remark.Location = new System.Drawing.Point(681, 228);
            this.textBox_remark.Multiline = true;
            this.textBox_remark.Name = "textBox_remark";
            this.textBox_remark.ShortcutsEnabled = false;
            this.textBox_remark.Size = new System.Drawing.Size(382, 123);
            this.textBox_remark.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Remark";
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(681, 91);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ShortcutsEnabled = false;
            this.textBox_description.Size = new System.Drawing.Size(382, 123);
            this.textBox_description.TabIndex = 37;
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(681, 14);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ShortcutsEnabled = false;
            this.textBox_price.Size = new System.Drawing.Size(382, 31);
            this.textBox_price.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Price";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CoffeePOS_System.DB_Context.Product);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(CoffeePOS_System.DB_Context.Product);
            // 
            // DrinkSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 861);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DrinkSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drink Settings";
            this.Load += new System.EventHandler(this.DrinkSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.TextBox textBox_SearchBox;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_remark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_active;
    }
}