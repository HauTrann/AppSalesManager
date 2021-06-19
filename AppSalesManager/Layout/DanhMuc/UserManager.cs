﻿using AppSalesManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppSalesManager
{
    public partial class UserManager : Form
    {
        AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
        private string status;
        User user;
        public UserManager(string status, long id = -1)
        {
            this.status = status;
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            if (status.Equals(Utils.VIEW))
            {

            }
            else if (status.Equals(Utils.UPDATE))
            {
                user = appSalesManagerEntities1.Users.FirstOrDefault(n => n.ID == id);
                if (user != null)
                {
                    txtNameLogin.Text = user.NameLogin;
                    ultraLabelUserID.Text = "UserID : " + user.ID.ToString();
                    txtAddress.Text = user.Address;
                    txtEmail.Text = user.Email;
                    ultraLabelRole.Text = "ROLE : " + user.Role.RoleName;
                }
            }
            else
            {
                user = new User();
            }
        }

        private void ultraTextEditor4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Oke_Click(object sender, EventArgs e)
        {
            if (status.Equals(Utils.UPDATE))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    user.NameLogin = txtNameLogin.Text;
                    user.Password = Utils.sha256(txtPassword.Text);
                    user.Email = txtEmail.Text;
                    user.Address = txtAddress.Text;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Chưa nhập mật khẩu");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {

                    user.NameLogin = txtNameLogin.Text;
                    user.Password = Utils.sha256(txtPassword.Text);
                    user.Email = txtEmail.Text;
                    user.Address = txtAddress.Text;
                    appSalesManagerEntities1.Users.AddObject(user);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Chưa nhập mật khẩu");
                }
            }
            appSalesManagerEntities1.SaveChanges();
            this.Close();
        }

        private void ultraLabel7_Click(object sender, EventArgs e)
        {

        }

        private void ultraLabel7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
