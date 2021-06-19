using AppSalesManager.Models;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppSalesManager
{
    public static class Utils
    {
        public static User UserLogin { set; get; }
        public static Color DefaultRowSelectedColor { get { return Color.Black; } }
        public static Color DefaultRowUnRecordedColor { get { return Color.Green; } }
        public static Color DisableColumnBorderColor { get { return Color.White; } }
        public static Color EnableColumnBorderColor { get { return Color.FromArgb(218, 220, 221); } }
        public static Color DisableColumnColor { get { return Color.FromArgb(225, 225, 225); } }
        public static Color EnableColumnColor { get { return Color.Transparent; } }

        public static string VIEW { get { return "VIEW"; } }
        public static string UPDATE { get { return "UPDATE"; } }
        public static string ADD { get { return "EDIT"; } }
        public static string ADMIN { get { return "ADMIN"; } }
        public static string USER { get { return "ADMIN"; } }


        public static string sha256(string text)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(text));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        public static void configUgrid(UltraGrid ultraGrid)
        {
            ultraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGrid.DisplayLayout.Override.RowSelectorStyle = Infragistics.Win.HeaderStyle.WindowsVista;
            ultraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            ultraGrid.DisplayLayout.UseFixedHeaders = false;
            //ultraGrid.DisplayLayout.Override.RowSelectors = DefaultableBoolean.False;
            //ultraGrid.DisplayLayout.GroupByBox.Prompt = resSystem.GRID_TitleGroupByBox;
            //Hiện những dòng trống?
            ultraGrid.DisplayLayout.Override.TipStyleCell = TipStyle.Show;
            ultraGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
            ultraGrid.DisplayLayout.EmptyRowSettings.Style = EmptyRowStyle.ExtendFirstCell;
            ultraGrid.DisplayLayout.Override.ActiveRowAppearance.ForeColor = Utils.DefaultRowSelectedColor;
            ultraGrid.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Utils.DefaultRowSelectedColor;
            //tắt tiêu đề
            ultraGrid.DisplayLayout.CaptionVisible = DefaultableBoolean.False;
            ultraGrid.DisplayLayout.BorderStyle = UIElementBorderStyle.None;
            ultraGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

            ultraGrid.DisplayLayout.MaxColScrollRegions = 1;
            ultraGrid.DisplayLayout.MaxRowScrollRegions = 1;
            ultraGrid.DisplayLayout.ViewStyle = ViewStyle.SingleBand;
            UltraGridBand band = ultraGrid.DisplayLayout.Bands[0];
            ultraGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;
            ultraGrid.DisplayLayout.Override.RowFilterMode = RowFilterMode.AllRowsInBand;
            band.HeaderVisible = false;
            //Border các ô các dòng
            //band.Override.BorderStyleRow = UIElementBorderStyle.WindowsVista;
            //band.Override.BorderStyleCell = UIElementBorderStyle.WindowsVista;
            ////Tiêu đề cột
            string headerCaptionFirst = string.Empty;
            var dicVisiblePosition = new Dictionary<int, int>();   //[vị trí trong list band.Columns] - [vị trí VisiblePosition]

            foreach (var item in band.Columns)
            {
                //Set màu Header
                //item.Header.Appearance.BorderAlpha = Alpha.Transparent;

                //item.Header.Appearance.TextHAlign = HAlign.Center;
                //item.Header.Enabled = !temp.IsReadOnly;
                //item.MaskInput = "{LOC}dd/mm/yyyy";
                ////item.MaskInput = "##/##/####";
                //item.Format = Constants.DdMMyyyy;
                //item.MaskDisplayMode = MaskMode.IncludeLiterals;
                //item.CellAppearance.TextHAlign = HAlign.Center;
                //item.CellAppearance.TextVAlign = VAlign.Middle;
            }
            ultraGrid.DisplayLayout.Override.AllowRowSummaries = AllowRowSummaries.Default; //Ẩn ký hiệu tổng trên Header Caption
            ultraGrid.DisplayLayout.Override.CellAppearance.TextTrimming = TextTrimming.EllipsisWord;
        }

    }
}
