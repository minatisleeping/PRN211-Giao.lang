namespace Zodiac
{
    partial class ZodiacManager
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
            lblWelcome = new Label();
            btnShowImage = new Button();
            picImage = new PictureBox();
            pnlImage = new Panel();
            btnCheckZodiac = new Button();
            btnExit = new Button();
            lblDay = new Label();
            label1 = new Label();
            lblYourZodiac = new Label();
            txtDay = new TextBox();
            textMonth = new TextBox();
            label2 = new Label();
            lblCopyright = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.SkyBlue;
            lblWelcome.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(129, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(653, 100);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Zodiac Calculator";
            // 
            // btnShowImage
            // 
            btnShowImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowImage.Location = new Point(204, 591);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(261, 82);
            btnShowImage.TabIndex = 2;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.DarkCyan;
            picImage.Location = new Point(190, 81);
            picImage.Name = "picImage";
            picImage.Size = new Size(500, 750);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            picImage.Click += picImage_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.PaleTurquoise;
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(882, 100);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(864, 888);
            pnlImage.TabIndex = 3;
            pnlImage.Paint += pnlImage_Paint;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckZodiac.Location = new Point(501, 591);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(261, 82);
            btnCheckZodiac.TabIndex = 3;
            btnCheckZodiac.Text = "Check ✅";
            btnCheckZodiac.UseVisualStyleBackColor = true;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Snow;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1517, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(261, 82);
            btnExit.TabIndex = 4;
            btnExit.Text = "Quit \U0001f9d0";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.SkyBlue;
            lblDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.Location = new Point(160, 420);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(305, 45);
            lblDay.TabIndex = 6;
            lblDay.Text = "Your date of birth: ";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            lblDay.Click += lblDay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 500);
            label1.Name = "label1";
            label1.Size = new Size(338, 45);
            label1.TabIndex = 7;
            label1.Text = "Your month of birth: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += lblMonth_Click;
            // 
            // lblYourZodiac
            // 
            lblYourZodiac.AutoSize = true;
            lblYourZodiac.BackColor = Color.SkyBlue;
            lblYourZodiac.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblYourZodiac.Location = new Point(127, 1060);
            lblYourZodiac.Name = "lblYourZodiac";
            lblYourZodiac.Size = new Size(515, 71);
            lblYourZodiac.TabIndex = 8;
            lblYourZodiac.Text = "Your zodiac sign is..";
            lblYourZodiac.TextAlign = ContentAlignment.MiddleCenter;
            lblYourZodiac.Click += lblYourZodiac_Click;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDay.Location = new Point(534, 417);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(200, 50);
            txtDay.TabIndex = 0;
            txtDay.Text = "1";
            // 
            // textMonth
            // 
            textMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textMonth.Location = new Point(534, 500);
            textMonth.Name = "textMonth";
            textMonth.Size = new Size(200, 50);
            textMonth.TabIndex = 1;
            textMonth.Text = "1";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.SkyBlue;
            lblCopyright.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCopyright.Location = new Point(54, 1190);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(367, 45);
            lblCopyright.TabIndex = 9;
            lblCopyright.Text = "© minatisleeping 2024 ";
            lblCopyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1938, 1272);
            Controls.Add(lblCopyright);
            Controls.Add(label2);
            Controls.Add(textMonth);
            Controls.Add(txtDay);
            Controls.Add(lblYourZodiac);
            Controls.Add(label1);
            Controls.Add(lblDay);
            Controls.Add(btnExit);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblWelcome);
            ForeColor = Color.FromArgb(0, 0, 0, 0);
            Name = "ZodiacManager";
            Text = "Welcome to Zodiac Calculator";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShowImage;
        private PictureBox picImage;
        private Panel pnlImage;
        private Button btnCheckZodiac;
        private Button btnExit;
        private Label lblDay;
        private Label label1;
        private Label lblYourZodiac;
        private TextBox txtDay;
        private TextBox textMonth;
        private Label label2;
        private Label lblCopyright;
    }
}
