namespace BookStore_HoangNT
{
    partial class BookManagerForm
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
            lblId = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblReleasedDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            cboCategory = new ComboBox();
            gbBookInfo = new GroupBox();
            txtKeyword = new TextBox();
            lblKeyword = new Label();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            lblFormTitle = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            gbBookInfo.SuspendLayout();
            gbTask.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(28, 72);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 32);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 142);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(28, 210);
            lblDesc.Margin = new Padding(5, 0, 5, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(135, 32);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(28, 410);
            lblReleasedDate.Margin = new Padding(5, 0, 5, 0);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(165, 32);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(28, 483);
            lblQuantity.Margin = new Padding(5, 0, 5, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(106, 32);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(468, 477);
            lblPrice.Margin = new Padding(5, 0, 5, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 32);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(28, 554);
            lblAuthor.Margin = new Padding(5, 0, 5, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(87, 32);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(28, 634);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(110, 32);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(213, 69);
            txtId.Margin = new Padding(5, 5, 5, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(202, 39);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(213, 138);
            txtName.Margin = new Padding(5, 5, 5, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(571, 39);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(213, 205);
            txtDescription.Margin = new Padding(5, 5, 5, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(571, 161);
            txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(213, 549);
            txtAuthor.Margin = new Padding(5, 5, 5, 5);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(571, 39);
            txtAuthor.TabIndex = 6;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(213, 402);
            dtpReleasedDate.Margin = new Padding(5, 5, 5, 5);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(244, 39);
            dtpReleasedDate.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(213, 629);
            cboCategory.Margin = new Padding(5, 5, 5, 5);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(571, 40);
            cboCategory.TabIndex = 7;
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(txtPrice);
            gbBookInfo.Controls.Add(txtQuantity);
            gbBookInfo.Controls.Add(cboCategory);
            gbBookInfo.Controls.Add(dtpReleasedDate);
            gbBookInfo.Controls.Add(txtAuthor);
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblPrice);
            gbBookInfo.Controls.Add(lblQuantity);
            gbBookInfo.Controls.Add(lblReleasedDate);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Yellow;
            gbBookInfo.Location = new Point(41, 114);
            gbBookInfo.Margin = new Padding(5, 5, 5, 5);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(5, 5, 5, 5);
            gbBookInfo.Size = new Size(812, 712);
            gbBookInfo.TabIndex = 18;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(148, 54);
            txtKeyword.Margin = new Padding(5, 5, 5, 5);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(357, 39);
            txtKeyword.TabIndex = 0;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(29, 59);
            lblKeyword.Margin = new Padding(5, 0, 5, 0);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(106, 32);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(41, 845);
            gbTask.Margin = new Padding(5, 5, 5, 5);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(5, 5, 5, 5);
            gbTask.Size = new Size(812, 128);
            gbTask.TabIndex = 20;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(630, 56);
            btnExit.Margin = new Padding(5, 5, 5, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(429, 56);
            btnDelete.Margin = new Padding(5, 5, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(153, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(229, 56);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(28, 56);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(893, 77);
            gbSearch.Margin = new Padding(5, 5, 5, 5);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(5, 5, 5, 5);
            gbSearch.Size = new Size(711, 128);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(538, 53);
            btnSearch.Margin = new Padding(5, 5, 5, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = Color.White;
            dgvBookList.BorderStyle = BorderStyle.Fixed3D;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(886, 288);
            dgvBookList.Margin = new Padding(5, 5, 5, 5);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(718, 675);
            dgvBookList.TabIndex = 0;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(898, 237);
            lblBookList.Margin = new Padding(5, 0, 5, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(110, 32);
            lblBookList.TabIndex = 23;
            lblBookList.Text = "Book List";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(41, 29);
            lblFormTitle.Margin = new Padding(5, 0, 5, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(397, 71);
            lblFormTitle.TabIndex = 18;
            lblFormTitle.Text = "Book Manager";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(213, 476);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 39);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(565, 477);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 5;
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1668, 1032);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            Load += BookManagerForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblDesc;
        private Label lblReleasedDate;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;     
        private TextBox txtAuthor;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategory;
        private GroupBox gbBookInfo;
        private TextBox txtKeyword;
        private Label lblKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Button btnSearch;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Label lblFormTitle;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}