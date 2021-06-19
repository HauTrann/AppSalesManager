using AppSalesManager.Models;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AppSalesManager
{
    public partial class Home : Form
    {
        private string page;
        WaitWndFun waitForm = new WaitWndFun();
        public Home()
        {
            InitializeComponent();
            page = "HangHoa";
            labelPage.Text = "HÀNG HÓA";
            Utils.configUgrid(ultraGrid1);
            Utils.configUgrid(ultraGrid2);
            waitForm.Show(this);
            LoadMaterialGoods();
            waitForm.Close();
        }

        private void WellcomeF()
        {

        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            waitForm.Show(this);
            Thread.Sleep(200);
            page = e.Tool.Key;
            switch (e.Tool.Key)
            {
                case "HangHoa":
                    labelPage.Text = "HÀNG HÓA";
                    LoadMaterialGoods();
                    break;
                case "NhapKho":
                    labelPage.Text = "NHẬP KHO";
                    LoadRSInward();
                    break;
                case "BanHang":
                    labelPage.Text = "BÁN HÀNG";
                    LoadSales();
                    break;
                case "BaoCao":
                    labelPage.Text = "BÁO CÁO";
                    break;
                case "Home":
                    //labelPage.Text = "BÁO CÁO";
                    WellcomeF();
                    break;
                case "UserManager":
                    labelPage.Text = "NGƯỜI DÙNG";
                    LoadUsers();
                    break;
                default:
                    break;
            }
            waitForm.Close();
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
                    AddNewToWarehouse();
                    break;
                case "BanHang":
                    AddNewSales();
                    break;
                case "BaoCao":
                    break;
                case "UserManager":
                    AddNewUser();
                    break;
                default:
                    break;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case "HangHoa":
                    EditMaterialGoods();
                    break;
                case "NhapKho":
                    break;
                case "BanHang":
                    break;
                case "BaoCao":
                    break;
                case "UserManager":
                    EditUser();
                    break;
                default:
                    break;
            }
        }

        private void EditUser()
        {
            User user = ultraGrid1.ActiveRow.ListObject as User;
            int index = ultraGrid1.ActiveRow.Index;
            if (user != null)
            {
                UserManager userManager = new UserManager(Utils.UPDATE, user.ID);
                userManager.ShowDialog(this);
                LoadUsers(index);
            }
        }

        private void AddNewUser()
        {
            User user = ultraGrid1.ActiveRow.ListObject as User;
            int index = ultraGrid1.ActiveRow.Index;
            if (user != null)
            {
                UserManager userManager = new UserManager(Utils.ADD);
                userManager.ShowDialog(this);
                LoadUsers(index);
            }
        }

        private void LoadRSInward(int index = -1)
        {
            ultraSplitter1.Visible = true;
            panel6.Visible = true;
            AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
            List<Sale> sales = appSalesManagerEntities1.Sales.ToList();
            ultraGrid1.DataSource = sales;
            ultraGrid2.DataSource = new SaleDetail();
            if (index != -1)
            {
                ultraGrid1.Rows[index].Activate();
            }
        }

        private void LoadSales(int index = -1)
        {
            ultraSplitter1.Visible = true;
            panel6.Visible = true;
            AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
            List<Sale> sales = appSalesManagerEntities1.Sales.ToList();
            ultraGrid1.DataSource = sales;
            ultraGrid2.DataSource = new SaleDetail();
            if (index != -1)
            {
                ultraGrid1.Rows[index].Activate();
            }
        }

        private void AddNewMaterialGoods()
        {
            MaterialGoods materialGoods = new MaterialGoods(Utils.ADD);
            materialGoods.ShowDialog();
            LoadMaterialGoods();
        }

        private void AddNewSales()
        {
            FormSaleDetail saleDetail = new FormSaleDetail(Utils.ADD);
            saleDetail.ShowDialog(this);

        }

        private void AddNewToWarehouse()
        {
            FormRSInwardDetail formRSInward = new FormRSInwardDetail(Utils.ADD);
            formRSInward.ShowDialog(this);
        }

        private void LoadMaterialGoods(int index = -1)
        {
            ultraSplitter1.Visible = false;
            panel6.Visible = false;
            AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
            List<MaterialGood> materialGoods = appSalesManagerEntities1.MaterialGoods.ToList();
            ultraGrid1.DataSource = materialGoods;
            if (index != -1)
            {
                ultraGrid1.Rows[index].Activate();
            }
        }

        private void LoadUsers(int index = -1)
        {
            //ultraSplitter1.Visible = false;
            panel6.Visible = false;
            AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
            List<User> users = appSalesManagerEntities1.Users.ToList();
            ultraGrid1.DataSource = users;
            if (index != -1)
            {
                ultraGrid1.Rows[index].Activate();
            }
        }

        private void EditMaterialGoods(string status = null)
        {
            MaterialGood materialGood = ultraGrid1.ActiveRow.ListObject as MaterialGood;
            int index = ultraGrid1.ActiveRow.Index;
            if (materialGood != null)
            {
                MaterialGoods materialGoods = new MaterialGoods(Utils.UPDATE, materialGood.ID);
                materialGoods.ShowDialog(this);
                LoadMaterialGoods(index);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                switch (page)
                {
                    case "HangHoa":
                        DeleteMaterialGoods();
                        break;
                    case "NhapKho":
                        break;
                    case "BanHang":
                        break;
                    case "BaoCao":
                        break;
                    case "UserManager":
                        DeleteUser();
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeleteMaterialGoods()
        {

        }

        private void DeleteUser()
        {
            User user = ultraGrid1.ActiveRow.ListObject as User;
            int index = ultraGrid1.ActiveRow.Index;
            if (user != null)
            {
                AppSalesManagerEntities1 appSalesManagerEntities1 = new AppSalesManagerEntities1();
                User userDelete = appSalesManagerEntities1.Users.FirstOrDefault(n => n.ID == user.ID);
                appSalesManagerEntities1.Users.DeleteObject(userDelete);
                appSalesManagerEntities1.SaveChanges();
                LoadUsers();
            }
        }

        private void View_Click(object sender, EventArgs e)
        {

        }

        private void ultraGrid1_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            switch (page)
            {
                case "HangHoa":
                    EditMaterialGoods();
                    break;
                case "NhapKho":
                    break;
                case "BanHang":
                    break;
                case "BaoCao":
                    break;
                case "UserManager":
                    EditUser();
                    break;
                default:
                    break;
            }
        }

        private void labelPage_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
