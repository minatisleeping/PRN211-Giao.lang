namespace BookManagement_HoangNgocTrinh
{
    partial class BookManagerMainUI
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
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            lblCopyright = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(11, 10);
            lblHeader.Margin = new Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(717, 128);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(37, 162);
            grbSearchCriteria.Margin = new Padding(5);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(5);
            grbSearchCriteria.Size = new Size(1892, 208);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            grbSearchCriteria.Enter += grbSearchCriteria_Enter;
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
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(1006, 91);
            txtDescription.Margin = new Padding(5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(319, 56);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(280, 91);
            txtBookName.Margin = new Padding(5);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(319, 56);
            txtBookName.TabIndex = 0;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(671, 96);
            lblBookDescription.Margin = new Padding(5, 0, 5, 0);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(323, 50);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(42, 96);
            lblBookName.Margin = new Padding(5, 0, 5, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(226, 50);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblCopyright.ForeColor = Color.Yellow;
            lblCopyright.Location = new Point(44, 995);
            lblCopyright.Margin = new Padding(5, 0, 5, 0);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(329, 40);
            lblCopyright.TabIndex = 2;
            lblCopyright.Text = "© minatisleeping 2024";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(1461, 478);
            btnCreate.Margin = new Padding(5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(396, 82);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(1461, 608);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(396, 82);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(1461, 741);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(396, 82);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(1461, 883);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(396, 82);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(44, 494);
            dgvBookList.Margin = new Padding(5);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(1375, 470);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(37, 427);
            lblBookList.Margin = new Padding(5, 0, 5, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(180, 50);
            lblBookList.TabIndex = 13;
            lblBookList.Text = "Book List";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1987, 1069);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblCopyright);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Margin = new Padding(5);
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblBookDescription;
        private Label lblBookName;
        private Label lblCopyright;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label lblBookList;
    }
}
