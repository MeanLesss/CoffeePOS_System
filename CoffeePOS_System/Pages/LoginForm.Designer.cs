namespace CoffeePOS_System.Pages
{
    partial class LoginForm
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.textBoxPin_4 = new System.Windows.Forms.TextBox();
            this.textBoxPin_3 = new System.Windows.Forms.TextBox();
            this.textBoxPin_2 = new System.Windows.Forms.TextBox();
            this.textBoxPin_1 = new System.Windows.Forms.TextBox();
            this.textBoxPin_0 = new System.Windows.Forms.TextBox();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.BackgroundImage = global::CoffeePOS_System.Properties.Resources.login_bg;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 567;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(852, 567);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRemember.FlatAppearance.BorderSize = 0;
            this.checkBoxRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemember.Location = new System.Drawing.Point(148, 277);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(170, 29);
            this.checkBoxRemember.TabIndex = 16;
            this.checkBoxRemember.Text = "Remember me";
            this.checkBoxRemember.UseVisualStyleBackColor = false;
            // 
            // textBoxPin_4
            // 
            this.textBoxPin_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin_4.Location = new System.Drawing.Point(329, 181);
            this.textBoxPin_4.MaxLength = 1;
            this.textBoxPin_4.Name = "textBoxPin_4";
            this.textBoxPin_4.Size = new System.Drawing.Size(51, 73);
            this.textBoxPin_4.TabIndex = 11;
            this.textBoxPin_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPin_4.TextChanged += new System.EventHandler(this.pin_input);
            this.textBoxPin_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxPin_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin_0_KeyPress);
            // 
            // textBoxPin_3
            // 
            this.textBoxPin_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin_3.Location = new System.Drawing.Point(271, 181);
            this.textBoxPin_3.MaxLength = 1;
            this.textBoxPin_3.Name = "textBoxPin_3";
            this.textBoxPin_3.Size = new System.Drawing.Size(51, 73);
            this.textBoxPin_3.TabIndex = 12;
            this.textBoxPin_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPin_3.TextChanged += new System.EventHandler(this.pin_input);
            this.textBoxPin_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxPin_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin_0_KeyPress);
            // 
            // textBoxPin_2
            // 
            this.textBoxPin_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin_2.Location = new System.Drawing.Point(211, 181);
            this.textBoxPin_2.MaxLength = 1;
            this.textBoxPin_2.Name = "textBoxPin_2";
            this.textBoxPin_2.Size = new System.Drawing.Size(51, 73);
            this.textBoxPin_2.TabIndex = 13;
            this.textBoxPin_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPin_2.TextChanged += new System.EventHandler(this.pin_input);
            this.textBoxPin_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxPin_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin_0_KeyPress);
            // 
            // textBoxPin_1
            // 
            this.textBoxPin_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin_1.Location = new System.Drawing.Point(151, 181);
            this.textBoxPin_1.MaxLength = 1;
            this.textBoxPin_1.Name = "textBoxPin_1";
            this.textBoxPin_1.Size = new System.Drawing.Size(51, 73);
            this.textBoxPin_1.TabIndex = 14;
            this.textBoxPin_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPin_1.TextChanged += new System.EventHandler(this.pin_input);
            this.textBoxPin_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxPin_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin_0_KeyPress);
            // 
            // textBoxPin_0
            // 
            this.textBoxPin_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPin_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin_0.Location = new System.Drawing.Point(91, 181);
            this.textBoxPin_0.MaxLength = 1;
            this.textBoxPin_0.Name = "textBoxPin_0";
            this.textBoxPin_0.Size = new System.Drawing.Size(51, 73);
            this.textBoxPin_0.TabIndex = 15;
            this.textBoxPin_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPin_0.TextChanged += new System.EventHandler(this.pin_input);
            this.textBoxPin_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxPin_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPin_0_KeyPress);
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButtonLogin.FlatAppearance.BorderSize = 0;
            this.iconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconButtonLogin.IconColor = System.Drawing.Color.Yellow;
            this.iconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogin.Location = new System.Drawing.Point(161, 359);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.Size = new System.Drawing.Size(143, 50);
            this.iconButtonLogin.TabIndex = 10;
            this.iconButtonLogin.Text = "Let\'s go";
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonLogin.UseVisualStyleBackColor = false;
            this.iconButtonLogin.Click += new System.EventHandler(this.iconButtonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Samona", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter your pin";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 567);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.textBoxPin_4);
            this.Controls.Add(this.textBoxPin_3);
            this.Controls.Add(this.textBoxPin_2);
            this.Controls.Add(this.textBoxPin_1);
            this.Controls.Add(this.textBoxPin_0);
            this.Controls.Add(this.iconButtonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.TextBox textBoxPin_4;
        private System.Windows.Forms.TextBox textBoxPin_3;
        private System.Windows.Forms.TextBox textBoxPin_2;
        private System.Windows.Forms.TextBox textBoxPin_1;
        private System.Windows.Forms.TextBox textBoxPin_0;
        private FontAwesome.Sharp.IconButton iconButtonLogin;
        private System.Windows.Forms.Label label2;
    }
}