namespace BookManagement_NhatMaiMinh
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
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            label1 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblCopyright = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.Cyan;
            lblHeader.Location = new Point(408, -15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(559, 100);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            lblHeader.Click += lblHeader_Click;
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            grbSearchCriteria.ForeColor = SystemColors.HotTrack;
            grbSearchCriteria.Location = new Point(58, 88);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1180, 282);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.ForeColor = SystemColors.Info;
            btnSearch.Location = new Point(850, 102);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 98);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(395, 165);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(319, 57);
            txtBookDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(395, 76);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(319, 57);
            txtBookName.TabIndex = 0;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookDescription.ForeColor = Color.Cyan;
            lblBookDescription.Location = new Point(19, 165);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(323, 50);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Book Description";
            lblBookDescription.Click += label3_Click;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.ForeColor = Color.Cyan;
            lblBookName.Location = new Point(19, 79);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(226, 50);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(58, 35);
            label1.Name = "label1";
            label1.Size = new Size(278, 50);
            label1.TabIndex = 2;
            label1.Text = "Book Manager";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.Info;
            btnCreate.Location = new Point(926, 403);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(330, 78);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Info;
            btnUpdate.Location = new Point(926, 505);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(330, 78);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Info;
            btnDelete.Location = new Point(926, 600);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(330, 78);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.Info;
            btnExit.Location = new Point(926, 698);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(330, 78);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(36, 403);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 82;
            dgvBookList.RowTemplate.Height = 41;
            dgvBookList.Size = new Size(838, 373);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCopyright.ForeColor = Color.Cyan;
            lblCopyright.Location = new Point(0, 779);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(418, 50);
            lblCopyright.TabIndex = 13;
            lblCopyright.Text = "© 2024 minatisleeping";
            lblCopyright.Click += label2_Click;
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1320, 837);
            Controls.Add(lblCopyright);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            ForeColor = SystemColors.MenuHighlight;
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
        private Label lblBookDescription;
        private Label lblBookName;
        private Label label1;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label lblCopyright;
    }
}
