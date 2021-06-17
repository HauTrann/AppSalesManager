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
    public partial class Home : Form
    {
        private string page;
        public Home()
        {
            InitializeComponent();
            page = "HangHoa";
            ultraGroupBox2.Text = "Danh sách hàng hóa";
            ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            page = e.Tool.Key;
            switch (e.Tool.Key)
            {
                case "HangHoa":
                    ultraGroupBox2.Text = "Danh sách hàng hóa";
                    LoadMaterialGoods();
                    break;
                case "NhapKho":
                    ultraGroupBox2.Text = "Danh sách nhập kho";
                    break;
                case "BanHang":
                    ultraGroupBox2.Text = "Danh sách bán hàng";
                    break;
                case "BaoCao":
                    ultraGroupBox2.Text = "Danh sách báo cáo";
                    break;
                default:
                    break;
            }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case "HangHoa":
                    AddNewMaterialGoods();
                    break;
                case "NhapKho":
                    break;
                case "BanHang":
                    break;
                case "BaoCao":
                    break;
                default:
                    break;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void AddNewMaterialGoods()
        {
            MaterialGoods materialGoods = new MaterialGoods();
            materialGoods.ShowDialog();
        }

        private void LoadMaterialGoods()
        {
            AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
            List<MaterialGood> materialGoods = appSalesManagerEntities1.MaterialGoods.ToList();
            ultraGrid1.DataSource = materialGoods;
        }
    }
}
