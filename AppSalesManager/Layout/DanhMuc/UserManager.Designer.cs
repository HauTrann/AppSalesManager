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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.txtID = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtNameLogin = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.Oke = new Infragistics.Win.Misc.UltraButton();
            this.Close = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.txtEmail = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabelUserID = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelRole = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
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
            this.ultraGroupBox1.Controls.Add(this.txtAddress);
            this.ultraGroupBox1.Controls.Add(this.txtPassword);
            this.ultraGroupBox1.Controls.Add(this.txtEmail);
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
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(410, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(205, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.ValueChanged += new System.EventHandler(this.ultraTextEditor4_ValueChanged);
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Location = new System.Drawing.Point(152, 73);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(178, 21);
            this.txtNameLogin.TabIndex = 4;
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
            appearance2.Image = global::AppSalesManager.Properties.Resources.apply_32;
            this.Oke.Appearance = appearance2;
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
            appearance3.Image = global::AppSalesManager.Properties.Resources.close1;
            this.Close.Appearance = appearance3;
            this.Close.Location = new System.Drawing.Point(497, 208);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Hủy";
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(410, 106);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 21);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.ValueChanged += new System.EventHandler(this.ultraTextEditor4_ValueChanged);
            // 
            // ultraLabelUserID
            // 
            this.ultraLabelUserID.Location = new System.Drawing.Point(167, 30);
            this.ultraLabelUserID.Name = "ultraLabelUserID";
            this.ultraLabelUserID.Size = new System.Drawing.Size(109, 13);
            this.ultraLabelUserID.TabIndex = 3;
            this.ultraLabelUserID.Text = "UserID :";
            // 
            // ultraLabelRole
            // 
            this.ultraLabelRole.Location = new System.Drawing.Point(336, 30);
            this.ultraLabelRole.Name = "ultraLabelRole";
            this.ultraLabelRole.Size = new System.Drawing.Size(109, 13);
            this.ultraLabelRole.TabIndex = 3;
            this.ultraLabelRole.Text = "UserID :";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
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
    }
}