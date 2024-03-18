namespace minat.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello sir", "Greeting!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Goodbye. Are u sure?", "NOTIFICATION!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (rs == DialogResult.Yes) { this.Close(); }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            DialogResult rs = dlgOpenFile.ShowDialog();
            if (rs == DialogResult.OK)
            {
                //MessageBox.Show(dlgOpenFile.FileName);
                lblFileName.Text = "Image: " + dlgOpenFile.FileName;

                picAvatar.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void LoadData(object sender, EventArgs e)
        {
            List<Student> arr = new List<Student>();
            arr.Add(new Student() { Id = "SE1", Name = "minat", Address = "Bà Điểm" });
            arr.Add(new Student() { Id = "SE2", Name = "chanpun", Address = "Song Hành" });
            arr.Add(new Student() { Id = "SE3", Name = "Lê Điêp", Address = "Chợ Lạc Quang" });
            arr.Add(new Student() { Id = "SE4", Name = "Tân Trần", Address = "Biên Hòa" });

            dgvStudentList.DataSource = arr;

        }
    }
}
