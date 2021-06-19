namespace AppSalesManager
{
    partial class UserManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.txtID = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txtAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtEmail = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtNameLogin = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelRole = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelUserID = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.Oke = new Infragistics.Win.Misc.UltraButton();
            this.Close = new Infragistics.Win.Misc.UltraButton();
            this.txtuserID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraComboRole = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboRole)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.txtID);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(666, 37);
            this.ultraPanel1.TabIndex = 0;
            // 
            // txtID
            // 
            appearance1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance1.FontData.BoldAsString = "True";
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.txtID.Appearance = appearance1;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(666, 37);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "NGƯỜI DÙNG";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraLabel2.Location = new System.Drawing.Point(0, 37);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(666, 201);
            this.ultraLabel2.TabIndex = 1;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraLabel3.Location = new System.Drawing.Point(0, 202);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(666, 36);
            this.ultraLabel3.TabIndex = 2;
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraComboRole);
            this.ultraGroupBox1.Controls.Add(this.txtAddress);
            this.ultraGroupBox1.Controls.Add(this.txtPassword);
            this.ultraGroupBox1.Controls.Add(this.txtEmail);
            this.ultraGroupBox1.Controls.Add(this.txtuserID);
            this.ultraGroupBox1.Controls.Add(this.txtNameLogin);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel8);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel7);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel6);
            this.ultraGroupBox1.Controls.Add(this.ultraLabelRole);
            this.ultraGroupBox1.Controls.Add(this.ultraLabelUserID);
            this.ultraGroupBox1.Controls.Add(this.ultraLabel5);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 37);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(666, 165);
            this.ultraGroupBox1.TabIndex = 4;
            this.ultraGroupBox1.Text = "Thông tin chi tiết";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(410, 106);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 21);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.ValueChanged += new System.EventHandler(this.ultraTextEditor4_ValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(410, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(205, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.ValueChanged += new System.EventHandler(this.ultraTextEditor4_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Location = new System.Drawing.Point(152, 73);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(178, 21);
            this.txtNameLogin.TabIndex = 4;
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Location = new System.Drawing.Point(336, 110);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(54, 17);
            this.ultraLabel8.TabIndex = 3;
            this.ultraLabel8.Text = "Địa chỉ";
            this.ultraLabel8.Click += new System.EventHandler(this.ultraLabel7_Click_1);
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Location = new System.Drawing.Point(37, 110);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(54, 17);
            this.ultraLabel7.TabIndex = 3;
            this.ultraLabel7.Text = "Email";
            this.ultraLabel7.Click += new System.EventHandler(this.ultraLabel7_Click_1);
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Location = new System.Drawing.Point(336, 77);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(69, 13);
            this.ultraLabel6.TabIndex = 3;
            this.ultraLabel6.Text = "Password";
            // 
            // ultraLabelRole
            // 
            this.ultraLabelRole.Location = new System.Drawing.Point(336, 44);
            this.ultraLabelRole.Name = "ultraLabelRole";
            this.ultraLabelRole.Size = new System.Drawing.Size(69, 13);
            this.ultraLabelRole.TabIndex = 3;
            this.ultraLabelRole.Text = "Quyền";
            // 
            // ultraLabelUserID
            // 
            this.ultraLabelUserID.Location = new System.Drawing.Point(37, 44);
            this.ultraLabelUserID.Name = "ultraLabelUserID";
            this.ultraLabelUserID.Size = new System.Drawing.Size(109, 13);
            this.ultraLabelUserID.TabIndex = 3;
            this.ultraLabelUserID.Text = "UserID";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Location = new System.Drawing.Point(37, 77);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(109, 13);
            this.ultraLabel5.TabIndex = 3;
            this.ultraLabel5.Text = "Tên người dùng";
            // 
            // Oke
            // 
            this.Oke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance14.Image = global::AppSalesManager.Properties.Resources.apply_32;
            this.Oke.Appearance = appearance14;
            this.Oke.Location = new System.Drawing.Point(578, 208);
            this.Oke.Name = "Oke";
            this.Oke.Size = new System.Drawing.Size(75, 23);
            this.Oke.TabIndex = 5;
            this.Oke.Text = "Đông ý";
            this.Oke.Click += new System.EventHandler(this.Oke_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance15.Image = global::AppSalesManager.Properties.Resources.close1;
            this.Close.Appearance = appearance15;
            this.Close.Location = new System.Drawing.Point(497, 208);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Hủy";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // txtuserID
            // 
            this.txtuserID.Enabled = false;
            this.txtuserID.Location = new System.Drawing.Point(152, 40);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(178, 21);
            this.txtuserID.TabIndex = 4;
            // 
            // ultraComboRole
            // 
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraComboRole.DisplayLayout.Appearance = appearance2;
            this.ultraComboRole.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboRole.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboRole.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboRole.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.ultraComboRole.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboRole.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.ultraComboRole.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboRole.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraComboRole.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Highlight;
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraComboRole.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.ultraComboRole.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboRole.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboRole.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraComboRole.DisplayLayout.Override.CellAppearance = appearance9;
            this.ultraComboRole.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboRole.DisplayLayout.Override.CellPadding = 0;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboRole.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.TextHAlignAsString = "Left";
            this.ultraComboRole.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.ultraComboRole.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboRole.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboRole.DisplayLayout.Override.RowAppearance = appearance12;
            this.ultraComboRole.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboRole.DisplayLayout.Override.TemplateAddRowAppearance = appearance13;
            this.ultraComboRole.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboRole.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboRole.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboRole.Location = new System.Drawing.Point(410, 40);
            this.ultraComboRole.Name = "ultraComboRole";
            this.ultraComboRole.Size = new System.Drawing.Size(205, 22);
            this.ultraComboRole.TabIndex = 5;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 238);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Oke);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialGoods";
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraLabel txtID;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtNameLogin;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraButton Oke;
        private Infragistics.Win.Misc.UltraButton Close;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtAddress;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtEmail;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabelUserID;
        private Infragistics.Win.Misc.UltraLabel ultraLabelRole;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtuserID;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboRole;
    }
}