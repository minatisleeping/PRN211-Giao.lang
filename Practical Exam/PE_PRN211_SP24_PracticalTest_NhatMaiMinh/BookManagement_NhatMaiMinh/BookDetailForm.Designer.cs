namespace BookManagement_NhatMaiMinh
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
            dtpPuclicationDate = new DateTimePicker();
            lblPrice = new Label();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            lblAuthor = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookId = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Info;
            btnSave.Location = new Point(1108, 265);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 86);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPuclicationDate);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookId);
            grbBookInfo.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            grbBookInfo.ForeColor = SystemColors.HotTrack;
            grbBookInfo.Location = new Point(12, 129);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(1072, 733);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "Book Info";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(363, 656);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(323, 58);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPuclicationDate
            // 
            dtpPuclicationDate.Format = DateTimePickerFormat.Short;
            dtpPuclicationDate.Location = new Point(363, 413);
            dtpPuclicationDate.Name = "dtpPuclicationDate";
            dtpPuclicationDate.Size = new Size(323, 57);
            dtpPuclicationDate.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Cyan;
            lblPrice.Location = new Point(670, 498);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(109, 50);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "Price";
            lblPrice.Click += label8_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(363, 248);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(672, 129);
            txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(363, 577);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(672, 57);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(803, 498);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(232, 57);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(363, 492);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(251, 57);
            txtQuantity.TabIndex = 4;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.ForeColor = Color.Cyan;
            lblAuthor.Location = new Point(6, 577);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(144, 50);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Cyan;
            lblCategory.Location = new Point(6, 656);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(181, 50);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Cyan;
            lblQuantity.Location = new Point(0, 492);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(173, 50);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublicationDate.ForeColor = Color.Cyan;
            lblPublicationDate.Location = new Point(6, 413);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(311, 50);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Cyan;
            lblDescription.Location = new Point(6, 251);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(222, 50);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(363, 165);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(672, 57);
            txtBookName.TabIndex = 1;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(363, 79);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(672, 57);
            txtBookId.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.ForeColor = Color.Cyan;
            lblBookName.Location = new Point(6, 165);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(226, 50);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            lblBookName.Click += lblBookDescription_Click;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookId.ForeColor = Color.Cyan;
            lblBookId.Location = new Point(6, 79);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(162, 50);
            lblBookId.TabIndex = 3;
            lblBookId.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.DodgerBlue;
            lblHeader.Location = new Point(375, 32);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(677, 78);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "ADD | UPDATE A BOOK";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Info;
            btnCancel.Location = new Point(1108, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(201, 93);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1352, 884);
            Controls.Add(btnCancel);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Name = "BookDetailForm";
            Text = "Add/Update a book";
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
        private Label lblBookId;
        private Label lblHeader;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label lblAuthor;
        private Label lblCategory;
        private Label lblPrice;
        private ComboBox cboBookCategoryId;
        private DateTimePicker dtpPuclicationDate;
        private Button btnCancel;
    }
}