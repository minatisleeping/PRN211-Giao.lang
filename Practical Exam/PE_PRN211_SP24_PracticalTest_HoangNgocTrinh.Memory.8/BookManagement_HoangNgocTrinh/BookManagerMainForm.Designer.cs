namespace BookManagement_HoangNgocTrinh
{
    partial class BookManagerMainForm
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
            lblHeader = new Label();
            lblCopyright = new Label();
            grbSearchCriteria = new GroupBox();
            txtDescription = new TextBox();
            btnSearch = new Button();
            txtBookName = new TextBox();
            lblDescription = new Label();
            lblBookName = new Label();
            btnCreate = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            picBookLogo = new PictureBox();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBookLogo).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Red;
            lblHeader.Font = new Font("Segoe UI", 39F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(485, 87);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.Red;
            lblCopyright.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyright.ForeColor = Color.Yellow;
            lblCopyright.Location = new Point(25, 619);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(150, 23);
            lblCopyright.TabIndex = 1;
            lblCopyright.Text = "© 2024 giáo.làng";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(30, 127);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1234, 107);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(692, 47);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(221, 38);
            txtDescription.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(1011, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(165, 47);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(222, 38);
            txtBookName.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Red;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(476, 50);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(200, 31);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Red;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(12, 50);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Book Name";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(1041, 312);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 42);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Add a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(30, 312);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(957, 296);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Red;
            lblBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(24, 268);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(112, 31);
            lblBookList.TabIndex = 8;
            lblBookList.Text = "Book List";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(1041, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 42);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(1041, 444);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(1041, 566);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(200, 42);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // picBookLogo
            // 
            picBookLogo.Image = Properties.Resources.Books_icon_icons_com_76879;
            picBookLogo.Location = new Point(1169, 18);
            picBookLogo.Name = "picBookLogo";
            picBookLogo.Size = new Size(95, 95);
            picBookLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picBookLogo.TabIndex = 12;
            picBookLogo.TabStop = false;
            // 
            // BookManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1291, 656);
            Controls.Add(picBookLogo);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnCreate);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblCopyright);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookManagerMainForm";
            Text = "Book Manager";
            Load += BookManagerMainForm_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBookLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblCopyright;
        private GroupBox grbSearchCriteria;
        private TextBox txtBookName;
        private Label lblDescription;
        private Label lblBookName;
        private Button btnSearch;
        private TextBox txtDescription;
        private Button btnCreate;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
        private PictureBox picBookLogo;
    }
}
