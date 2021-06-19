using AppSalesManager.Models;
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
    public partial class FormRSInwardDetail : Form
    {
        AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
        private string status;
        User user;
        List<SaleDetail> saleDetails = new List<SaleDetail>();
        public FormRSInwardDetail(string status, long id = -1)
        {
            this.status = status;
            InitializeComponent();
            Utils.configUgrid(ultraGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            if (status.Equals(Utils.VIEW))
            {

            }
            else if (status.Equals(Utils.UPDATE))
            {
                user = appSalesManagerEntities1.Users.FirstOrDefault(n => n.ID == id);
                if (user != null)
                {
                    txtName.Text = user.NameLogin;
                    txtEmail.Text = user.Email;
                }
            }
            else
            {
                user = new User();
                ultraGrid1.DataSource = saleDetails;
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
            }
            else
            {
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
