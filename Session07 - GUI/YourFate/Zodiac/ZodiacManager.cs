using Services;
using System.Diagnostics.Contracts;

namespace Zodiac
{
    // Class Form1 chính là kế thừa (inherit/inheritance) cái class gốc mà Windows cung
    //cấp đê render ra cửa sổ tương tác
    // Form là Class Cha/Parent, class gốc có khả năng render 1 HCN ~ web page để cung cấp mặt sàn 
    //tương tác với user
    // Ta lập trình app GUI, app Desktop, tức là app chạy trên nền Desktop, có icon biểu tượng trên thanh 
    //Taskbar, chính là tạo ra 1 app kế thừa class Form
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"signs/HotGirl.jpg");

            picImage.Image = img;
        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(textMonth.Text);

            string zodiacEN = ZodiacCalculator.GetZodiacEnglish(month, day);

            string zodiacVN = ZodiacCalculator.GetZodiacVietnamese(zodiacEN);

            //string zodiacImage = "signs\\" + zodiacEN + ".jpg";

            string zodiacImage = @"signs\" + zodiacEN + ".jpg";

            // load ảnh và cập nhật status - cung gì
            Image img = Image.FromFile(zodiacImage); // đường dẫn ảnh

            picImage.Image = img;

            lblYourZodiac.Text = "Your zodiac sign is - Cung hoàng đạo của bạn là: " + zodiacEN + " | " + zodiacVN;
        }

        public void picImage_Click(object sender, EventArgs e) { }
        public void pnlImage_Paint(object sender, PaintEventArgs e) { }
        public void btnExit_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận
            DialogResult rs =  MessageBox.Show("Are you sure ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }
        public void lblDay_Click(object sender, EventArgs e) { }
        public void lblMonth_Click(object sender, EventArgs e) { }
        public void lblYourZodiac_Click(object sender, EventArgs e) { }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
