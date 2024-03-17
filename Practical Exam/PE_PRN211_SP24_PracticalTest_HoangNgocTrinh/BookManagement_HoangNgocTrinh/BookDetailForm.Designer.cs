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
            dtpPublicationDate = new DateTimePicker();
            lblPrice = new Label();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(1784, 205);
            btnSave.Margin = new Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(306, 82);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(81, 181);
            grbBookInfo.Margin = new Padding(5, 5, 5, 5);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Padding = new Padding(5, 5, 5, 5);
            grbBookInfo.Size = new Size(1661, 920);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(476, 818);
            cboBookCategoryId.Margin = new Padding(5, 5, 5, 5);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(353, 58);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(476, 522);
            dtpPublicationDate.Margin = new Padding(5, 5, 5, 5);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(391, 56);
            dtpPublicationDate.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(1147, 621);
            lblPrice.Margin = new Padding(5, 0, 5, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(109, 50);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(476, 718);
            txtAuthor.Margin = new Padding(5, 5, 5, 5);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(1128, 56);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1285, 616);
            txtPrice.Margin = new Padding(5, 5, 5, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(319, 56);
            txtPrice.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(476, 288);
            txtDescription.Margin = new Padding(5, 5, 5, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(1128, 185);
            txtDescription.TabIndex = 2;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(476, 186);
            txtBookName.Margin = new Padding(5, 5, 5, 5);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(1128, 56);
            txtBookName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(57, 822);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(181, 50);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(57, 723);
            lblAuthor.Margin = new Padding(5, 0, 5, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(144, 50);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(57, 621);
            lblQuantity.Margin = new Padding(5, 0, 5, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(173, 50);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(57, 531);
            lblPublicationDate.Margin = new Padding(5, 0, 5, 0);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(311, 50);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(57, 293);
            lblDescription.Margin = new Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(222, 50);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(476, 616);
            txtQuantity.Margin = new Padding(5, 5, 5, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(319, 56);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(476, 91);
            txtBookId.Margin = new Padding(5, 5, 5, 5);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(1128, 56);
            txtBookId.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(57, 190);
            lblBookName.Margin = new Padding(5, 0, 5, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(226, 50);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookID.ForeColor = Color.Yellow;
            lblBookID.Location = new Point(57, 96);
            lblBookID.Margin = new Padding(5, 0, 5, 0);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(162, 50);
            lblBookID.TabIndex = 3;
            lblBookID.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(52, 34);
            lblHeader.Margin = new Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(714, 92);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(1784, 346);
            btnCancel.Margin = new Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(306, 82);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(2135, 1146);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Margin = new Padding(5, 5, 5, 5);
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
        private TextBox txtQuantity;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblBookID;
        private Label lblHeader;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblDescription;
        private Button btnCancel;
        private Label lblPrice;
        private ComboBox cboBookCategoryId;
        private DateTimePicker dtpPublicationDate;
    }
}