namespace BookStore_HoangNT
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblAppName = new Label();
            gbLoginForm = new GroupBox();
            lblSignIn = new Label();
            gbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLogin.Location = new Point(99, 462);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(358, 70);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEmail.Location = new Point(99, 221);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 38);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblEmail.Location = new Point(89, 174);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 32);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtPassword.Location = new Point(99, 358);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(355, 38);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblPassword.Location = new Point(93, 317);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(138, 32);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblAppName.Location = new Point(260, 42);
            lblAppName.Margin = new Padding(5, 0, 5, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(397, 71);
            lblAppName.TabIndex = 15;
            lblAppName.Text = "Book Manager";
            // 
            // gbLoginForm
            // 
            gbLoginForm.BackColor = Color.LimeGreen;
            gbLoginForm.Controls.Add(lblSignIn);
            gbLoginForm.Controls.Add(txtPassword);
            gbLoginForm.Controls.Add(btnLogin);
            gbLoginForm.Controls.Add(lblPassword);
            gbLoginForm.Controls.Add(txtEmail);
            gbLoginForm.Controls.Add(lblEmail);
            gbLoginForm.FlatStyle = FlatStyle.Flat;
            gbLoginForm.Location = new Point(171, 155);
            gbLoginForm.Margin = new Padding(5);
            gbLoginForm.Name = "gbLoginForm";
            gbLoginForm.Padding = new Padding(5);
            gbLoginForm.Size = new Size(551, 581);
            gbLoginForm.TabIndex = 16;
            gbLoginForm.TabStop = false;
            gbLoginForm.Enter += gbLoginForm_Enter;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblSignIn.Location = new Point(190, 37);
            lblSignIn.Margin = new Padding(5, 0, 5, 0);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(170, 60);
            lblSignIn.TabIndex = 17;
            lblSignIn.Text = "Sign In";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(897, 840);
            Controls.Add(gbLoginForm);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            gbLoginForm.ResumeLayout(false);
            gbLoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblAppName;
        private GroupBox gbLoginForm;
        private Label lblSignIn;
    }
}