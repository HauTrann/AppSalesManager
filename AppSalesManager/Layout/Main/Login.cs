using AppSalesManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSalesManager
{
    public partial class Login : Form
    {
        AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ultraTextEditor2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Oke_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnameLogin.Text) && !string.IsNullOrEmpty(txtnameLogin.Text))
            {
                User user = appSalesManagerEntities1.Users.FirstOrDefault(n => n.NameLogin.ToUpper().Equals(txtnameLogin.Text.ToUpper()));
                string hashPassSHA256 = Utils.sha256(txtPassword.Text);
                if (user != null && hashPassSHA256.Equals(user.Password))
                {
                    Utils.UserLogin = user;
                    Home f = new Home();
                    f.ShowDialog(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
