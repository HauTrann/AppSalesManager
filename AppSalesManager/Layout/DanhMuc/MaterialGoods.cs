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
    public partial class MaterialGoods : Form
    {
        AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
        private string status;
        MaterialGood materialGood;
        public MaterialGoods(string status, long id = -1)
        {
            this.status = status;
            InitializeComponent();
            if (status.Equals(Utils.VIEW))
            {

            }
            else if (status.Equals(Utils.UPDATE))
            {
                materialGood = appSalesManagerEntities1.MaterialGoods.FirstOrDefault(n => n.ID == id);
                if (materialGood != null)
                {
                    txtCode.Text = materialGood.Code;
                    txtID.Text = materialGood.ID.ToString();
                    txtName.Text = materialGood.Name;
                    txtDescription.Text = materialGood.Description;
                }
            }
            else
            {
                materialGood = new MaterialGood();
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
                materialGood.Code = txtCode.Text;
                materialGood.Name = txtName.Text;
                materialGood.Description = txtDescription.Text;
            }
            else
            {
                materialGood.Code = txtCode.Text;
                materialGood.Name = txtName.Text;
                materialGood.Description = txtDescription.Text;
                appSalesManagerEntities1.MaterialGoods.Add(materialGood);
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
