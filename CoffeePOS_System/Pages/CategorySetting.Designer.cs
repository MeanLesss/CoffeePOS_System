namespace CoffeePOS_System.Pages
{
    partial class CategorySetting
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
            this.checkBox_active = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_Cate = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox_SearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_active
            // 
            this.checkBox_active.AutoSize = true;
            this.checkBox_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_active.Location = new System.Drawing.Point(148, 66);
            this.checkBox_active.Name = "checkBox_active";
            this.checkBox_active.Size = new System.Drawing.Size(90, 29);
            this.checkBox_active.TabIndex = 40;
            this.checkBox_active.Text = "Active";
            this.checkBox_active.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 712);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1352, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(391, 17);
            this.toolStripStatusLabel1.Text = "SU25_Kang_Sokvimean,Chhorn Pheareak,Yourk Sopheaktra,Yorn Ekpiseth";
            // 
            // dataGridView_Cate
            // 
            this.dataGridView_Cate.AllowUserToOrderColumns = true;
            this.dataGridView_Cate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Cate.Location = new System.Drawing.Point(3, 116);
            this.dataGridView_Cate.Name = "dataGridView_Cate";
            this.dataGridView_Cate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Cate.Size = new System.Drawing.Size(1346, 358);
            this.dataGridView_Cate.TabIndex = 27;
            this.dataGridView_Cate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Cate_CellClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(36, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(216, 31);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox_SearchBox
            // 
            this.textBox_SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchBox.Location = new System.Drawing.Point(47, 39);
            this.textBox_SearchBox.Name = "textBox_SearchBox";
            this.textBox_SearchBox.Size = new System.Drawing.Size(382, 31);
            this.textBox_SearchBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(42, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Click on the cell to show category detail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Cate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_SearchBox);
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Location = new System.Drawing.Point(0, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 477);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category list";
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(452, 39);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(105, 31);
            this.button_Search.TabIndex = 23;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.Black;
            this.button_Clear.Location = new System.Drawing.Point(36, 132);
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
            this.button_Add.Location = new System.Drawing.Point(148, 132);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(105, 31);
            this.button_Add.TabIndex = 23;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(147, 16);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(382, 31);
            this.textBox_Name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.checkBox_active);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 710);
            this.panel1.TabIndex = 15;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(CoffeePOS_System.DB_Context.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CoffeePOS_System.DB_Context.Product);
            // 
            // CategorySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 734);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "CategorySetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Setting";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CategorySetting_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.CheckBox checkBox_active;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView_Cate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox_SearchBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}