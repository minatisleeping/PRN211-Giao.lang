using Repositories.Entities;
using Services;

namespace BookStore_HoangNT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BookManagementService service = new();
            BookManagementMember acc = service.CheckLogin(txtEmail.Text, txtPassword.Text);

            if (acc == null)
            {
                MessageBox.Show("Login failed! Pls check your credentials", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (acc.MemberRole != 1)
            {
                MessageBox.Show("You have no permission to access here", "Problem related to authorization!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // đi được tới đây thì ngon rồi
            BookManagerForm bookMgt = new();
            bookMgt.Show();
            this.Hide();
        }
    }
}