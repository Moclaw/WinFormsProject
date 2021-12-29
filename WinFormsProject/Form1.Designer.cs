
namespace WinFormsProject
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox textBox1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bthClose = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.CausesValidation = false;
            textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(126, 150);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(100, 26);
            textBox1.TabIndex = 1;
            textBox1.Text = "Login";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsProject.Properties.Resources.Moclaw;
            this.pictureBox1.Location = new System.Drawing.Point(54, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(54, 231);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(54, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 3;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(54, 300);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(54, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(93, 239);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(211, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.AllowDrop = true;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(93, 309);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(211, 16);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(54, 363);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // bthClose
            // 
            this.bthClose.Location = new System.Drawing.Point(136, 437);
            this.bthClose.Name = "bthClose";
            this.bthClose.Size = new System.Drawing.Size(75, 23);
            this.bthClose.TabIndex = 4;
            this.bthClose.Text = "Close";
            this.bthClose.UseVisualStyleBackColor = true;
            this.bthClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.bthClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bthClose;
    }
}

