namespace BookManagement_HoangNgocTrinh
{
    partial class BookDetailForm
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
            btnSave = new Button();
            grbBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpPublicationDate = new DateTimePicker();
            txtDescription = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPublicationDate = new Label();
            lblQuantity = new Label();
            lblDescription = new Label();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            lblHeader = new Label();
            btnClose = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(1571, 226);
            btnSave.Margin = new Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(280, 67);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(34, 203);
            grbBookInfo.Margin = new Padding(5, 5, 5, 5);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Padding = new Padding(5, 5, 5, 5);
            grbBookInfo.Size = new Size(1492, 968);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(388, 872);
            cboBookCategoryId.Margin = new Padding(5, 5, 5, 5);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(532, 58);
            cboBookCategoryId.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(388, 768);
            txtAuthor.Margin = new Padding(5, 5, 5, 5);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(1068, 56);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1098, 669);
            txtPrice.Margin = new Padding(5, 5, 5, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(358, 56);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(388, 669);
            txtQuantity.Margin = new Padding(5, 5, 5, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(358, 56);
            txtQuantity.TabIndex = 4;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(388, 574);
            dtpPublicationDate.Margin = new Padding(5, 5, 5, 5);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(288, 56);
            dtpPublicationDate.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(388, 266);
            txtDescription.Margin = new Padding(5, 5, 5, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(1068, 274);
            txtDescription.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Red;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(980, 674);
            lblPrice.Margin = new Padding(5, 0, 5, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(109, 50);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Red;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(34, 877);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(181, 50);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.Red;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(34, 773);
            lblAuthor.Margin = new Padding(5, 0, 5, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(144, 50);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.BackColor = Color.Red;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(34, 584);
            lblPublicationDate.Margin = new Padding(5, 0, 5, 0);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(311, 50);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Red;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(34, 674);
            lblQuantity.Margin = new Padding(5, 0, 5, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(173, 50);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Red;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(34, 266);
            lblDescription.Margin = new Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(222, 50);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(388, 176);
            txtBookName.Margin = new Padding(5, 5, 5, 5);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(1068, 56);
            txtBookName.TabIndex = 1;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(388, 86);
            txtBookId.Margin = new Padding(5, 5, 5, 5);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(358, 56);
            txtBookId.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Red;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(34, 181);
            lblBookName.Margin = new Padding(5, 0, 5, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(226, 50);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.BackColor = Color.Red;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookID.ForeColor = Color.Yellow;
            lblBookID.Location = new Point(34, 91);
            lblBookID.Margin = new Padding(5, 0, 5, 0);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(162, 50);
            lblBookID.TabIndex = 2;
            lblBookID.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Red;
            lblHeader.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(20, 40);
            lblHeader.Margin = new Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(827, 106);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Yellow;
            btnClose.Location = new Point(1571, 342);
            btnClose.Margin = new Padding(5, 5, 5, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(280, 67);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(2243, 1211);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "BookDetailForm";
            Text = "Add | Update a Book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grbBookInfo;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblBookID;
        private Label lblHeader;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPublicationDate;
        private Label lblQuantity;
        private Label lblDescription;
        private TextBox txtDescription;
        private ComboBox cboBookCategoryId;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DateTimePicker dtpPublicationDate;
        private Button btnClose;
    }
}