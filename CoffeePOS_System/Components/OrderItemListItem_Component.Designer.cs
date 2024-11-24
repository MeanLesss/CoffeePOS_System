namespace CoffeePOS_System.Components
{
    partial class OrderItemListItem_Component
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Item_Name = new System.Windows.Forms.Label();
            this.iconPictureBoxProd = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonPlus = new FontAwesome.Sharp.IconButton();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.iconButtonRemove = new FontAwesome.Sharp.IconButton();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Item_Name
            // 
            this.label_Item_Name.AutoSize = true;
            this.label_Item_Name.Font = new System.Drawing.Font("Arvo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Item_Name.Location = new System.Drawing.Point(127, 14);
            this.label_Item_Name.Name = "label_Item_Name";
            this.label_Item_Name.Size = new System.Drawing.Size(127, 25);
            this.label_Item_Name.TabIndex = 0;
            this.label_Item_Name.Text = "Prod Name";
            // 
            // iconPictureBoxProd
            // 
            this.iconPictureBoxProd.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxProd.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.iconPictureBoxProd.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxProd.IconSize = 96;
            this.iconPictureBoxProd.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxProd.Name = "iconPictureBoxProd";
            this.iconPictureBoxProd.Size = new System.Drawing.Size(104, 96);
            this.iconPictureBoxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxProd.TabIndex = 1;
            this.iconPictureBoxProd.TabStop = false;
            this.iconPictureBoxProd.UseGdi = true;
            this.iconPictureBoxProd.UseIconCache = true;
            // 
            // iconButtonMinus
            // 
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonMinus.IconColor = System.Drawing.Color.Black;
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinus.IconSize = 30;
            this.iconButtonMinus.Location = new System.Drawing.Point(417, 36);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Size = new System.Drawing.Size(32, 32);
            this.iconButtonMinus.TabIndex = 2;
            this.iconButtonMinus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMinus.UseVisualStyleBackColor = false;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            // 
            // iconButtonPlus
            // 
            this.iconButtonPlus.FlatAppearance.BorderSize = 0;
            this.iconButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPlus.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButtonPlus.IconColor = System.Drawing.Color.Black;
            this.iconButtonPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPlus.IconSize = 30;
            this.iconButtonPlus.Location = new System.Drawing.Point(534, 36);
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.Size = new System.Drawing.Size(32, 32);
            this.iconButtonPlus.TabIndex = 2;
            this.iconButtonPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPlus.UseVisualStyleBackColor = false;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // textBoxQty
            // 
            this.textBoxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQty.Location = new System.Drawing.Point(462, 34);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(66, 31);
            this.textBoxQty.TabIndex = 3;
            this.textBoxQty.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // iconButtonRemove
            // 
            this.iconButtonRemove.FlatAppearance.BorderSize = 0;
            this.iconButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonRemove.IconColor = System.Drawing.Color.IndianRed;
            this.iconButtonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRemove.IconSize = 30;
            this.iconButtonRemove.Location = new System.Drawing.Point(373, 36);
            this.iconButtonRemove.Name = "iconButtonRemove";
            this.iconButtonRemove.Size = new System.Drawing.Size(32, 32);
            this.iconButtonRemove.TabIndex = 2;
            this.iconButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRemove.UseVisualStyleBackColor = false;
            this.iconButtonRemove.Click += new System.EventHandler(this.iconButtonRemove_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(127, 53);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(98, 19);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Prod Name";
            // 
            // OrderItemListItem_Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.iconButtonPlus);
            this.Controls.Add(this.iconButtonRemove);
            this.Controls.Add(this.iconButtonMinus);
            this.Controls.Add(this.iconPictureBoxProd);
            this.Controls.Add(this.label_Item_Name);
            this.Name = "OrderItemListItem_Component";
            this.Size = new System.Drawing.Size(578, 96);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Item_Name;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxProd;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonPlus;
        private System.Windows.Forms.TextBox textBoxQty;
        private FontAwesome.Sharp.IconButton iconButtonRemove;
        private System.Windows.Forms.Label labelPrice;
    }
}
