using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void grbSearchCriteria_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccService service = new();
            UserAccount acc = service.CheckLogin(txtEmail.Text, txtEmail.Text);
            if (acc == null)
            {
                MessageBox.Show("Email doesn't exist!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // khác null thì có 2 case xảy ra: đúng user&pass; đúng user|pass
            if (acc.Role == -1)
            {
                MessageBox.Show("Wrong password! Try again", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BookManagerMainUI f = new();
            f.Show();
            this.Hide();
                
        }
    }
}
