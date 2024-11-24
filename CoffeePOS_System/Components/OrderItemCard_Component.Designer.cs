namespace CoffeePOS_System.Components
{
    partial class OrderItemCard_Component
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
            this.label_title = new System.Windows.Forms.Label();
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxItem = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arvo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(36, 262);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(44, 18);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonMinus
            // 
            this.iconButtonMinus.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinus.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonMinus.IconColor = System.Drawing.Color.Black;
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinus.IconSize = 32;
            this.iconButtonMinus.Location = new System.Drawing.Point(39, 300);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Size = new System.Drawing.Size(47, 27);
            this.iconButtonMinus.TabIndex = 2;
            this.iconButtonMinus.UseVisualStyleBackColor = false;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 32;
            this.iconButtonAdd.Location = new System.Drawing.Point(164, 300);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(47, 27);
            this.iconButtonAdd.TabIndex = 2;
            this.iconButtonAdd.UseVisualStyleBackColor = false;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // iconPictureBoxItem
            // 
            this.iconPictureBoxItem.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxItem.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBoxItem.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxItem.IconSize = 175;
            this.iconPictureBoxItem.Location = new System.Drawing.Point(39, 25);
            this.iconPictureBoxItem.Name = "iconPictureBoxItem";
            this.iconPictureBoxItem.Size = new System.Drawing.Size(175, 202);
            this.iconPictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxItem.TabIndex = 3;
            this.iconPictureBoxItem.TabStop = false;
            // 
            // textBoxCount
            // 
            this.textBoxCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCount.Font = new System.Drawing.Font("Arvo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(89, 300);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(72, 26);
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arvo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(178, 262);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 18);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "$0.00";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderItemCard_Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.iconPictureBoxItem);
            this.Controls.Add(this.iconButtonAdd);
            this.Controls.Add(this.iconButtonMinus);
            this.Controls.Add(this.label_title);
            this.Name = "OrderItemCard_Component";
            this.Size = new System.Drawing.Size(255, 344);
            this.Load += new System.EventHandler(this.OrderItemCard_Component_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxItem;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelPrice;
    }
}
