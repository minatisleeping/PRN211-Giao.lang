namespace minat.FAP.StudentMgt
{
    partial class StudentListForm
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
            btnSayHello = new Button();
            btnExit = new Button();
            dlgOpenFile = new OpenFileDialog();
            button1 = new Button();
            btnImage = new Button();
            picAvatar = new PictureBox();
            lblFileName = new Label();
            pnlImage = new Panel();
            dgvStudentList = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(33, 40);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(251, 100);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hellooooo";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1183, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(512, 201);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "JPEG files |*.jpg;*.jpeg|PNG files|*.png";
            dlgOpenFile.Multiselect = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(346, 160);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(204, 117);
            btnImage.TabIndex = 2;
            btnImage.Text = "Choose image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(30, 46);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(730, 583);
            picAvatar.TabIndex = 3;
            picAvatar.TabStop = false;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileName.Location = new Point(109, 231);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(175, 59);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "Image: ";
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.Controls.Add(picAvatar);
            pnlImage.Location = new Point(94, 293);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(774, 614);
            pnlImage.TabIndex = 5;
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(1006, 283);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 82;
            dgvStudentList.RowTemplate.Height = 41;
            dgvStudentList.Size = new Size(833, 656);
            dgvStudentList.TabIndex = 6;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(665, 31);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(251, 100);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += LoadData;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 962);
            Controls.Add(btnLoad);
            Controls.Add(dgvStudentList);
            Controls.Add(pnlImage);
            Controls.Add(lblFileName);
            Controls.Add(btnImage);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(btnSayHello);
            Name = "StudentListForm";
            Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button btnExit;
        private OpenFileDialog dlgOpenFile;
        private Button button1;
        private Button btnImage;
        private PictureBox picAvatar;
        private Label lblFileName;
        private Panel pnlImage;
        private DataGridView dgvStudentList;
        private Button btnLoad;
    }
}
