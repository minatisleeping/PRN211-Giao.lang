namespace BookStore_HoangNT
{
    partial class BookForm
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
            lblFormTitle = new Label();
            gbBookInfo = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboCategory = new ComboBox();
            dtpReleasedDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            gbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(86, 29);
            lblFormTitle.Margin = new Padding(5, 0, 5, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(437, 71);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Add a new book";
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
            gbBookInfo.Location = new Point(86, 162);
            gbBookInfo.Margin = new Padding(5);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(5);
            gbBookInfo.Size = new Size(835, 712);
            gbBookInfo.TabIndex = 22;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(567, 477);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(215, 476);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 39);
            txtQuantity.TabIndex = 8;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(213, 629);
            cboCategory.Margin = new Padding(5);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(571, 40);
            cboCategory.TabIndex = 7;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(213, 402);
            dtpReleasedDate.Margin = new Padding(5);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(244, 39);
            dtpReleasedDate.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(213, 549);
            txtAuthor.Margin = new Padding(5);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(571, 39);
            txtAuthor.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(213, 205);
            txtDescription.Margin = new Padding(5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(571, 161);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(213, 138);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(571, 39);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(213, 69);
            txtId.Margin = new Padding(5);
            txtId.Name = "txtId";
            txtId.Size = new Size(202, 39);
            txtId.TabIndex = 0;
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
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(769, 904);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(588, 904);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1029, 989);
            Controls.Add(lblFormTitle);
            Controls.Add(gbBookInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add | Update Book";
            Load += BookForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbBookInfo;
        private ComboBox cboCategory;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}