namespace BookManagement_HoangNgocTrinh
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
            grbSearchCriteria = new GroupBox();
            btnQuit = new Button();
            btnLogin = new Button();
            btnSearch = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblLogin = new Label();
            lblEmail = new Label();
            grbSearchCriteria.SuspendLayout();
            SuspendLayout();
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnQuit);
            grbSearchCriteria.Controls.Add(btnLogin);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtPassword);
            grbSearchCriteria.Controls.Add(txtEmail);
            grbSearchCriteria.Controls.Add(lblLogin);
            grbSearchCriteria.Controls.Add(lblEmail);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(192, 176);
            grbSearchCriteria.Margin = new Padding(5);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(5);
            grbSearchCriteria.Size = new Size(939, 408);
            grbSearchCriteria.TabIndex = 1;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = "Login";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(516, 301);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(264, 86);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(164, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 86);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(1424, 80);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(396, 82);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(425, 186);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 56);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(425, 98);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 56);
            txtEmail.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblLogin.ForeColor = Color.Yellow;
            lblLogin.Location = new Point(44, 186);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(187, 50);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Yellow;
            lblEmail.Location = new Point(44, 98);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(118, 50);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1674, 943);
            Controls.Add(grbSearchCriteria);
            ForeColor = SystemColors.ActiveCaption;
            Name = "LoginForm";
            Text = "LoginForm";
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSearchCriteria;
        private Button btnQuit;
        private Button btnLogin;
        private Button btnSearch;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblLogin;
        private Label lblEmail;
    }
}