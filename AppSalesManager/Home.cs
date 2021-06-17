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
        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            page = e.Tool.Key;
            switch (e.Tool.Key)
            {
                case "HangHoa":
                    ultraGroupBox2.Text = "Danh sách hàng hóa";
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
    }
}
