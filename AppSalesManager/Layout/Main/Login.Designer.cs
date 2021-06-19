namespace AppSalesManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.txtnameLogin = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.Oke = new Infragistics.Win.Misc.UltraButton();
            this.Close = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtnameLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            appearance1.FontData.BoldAsString = "True";
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ultraLabel1.Appearance = appearance1;
            this.ultraLabel1.Location = new System.Drawing.Point(12, 12);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(282, 23);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "ĐĂNG NHẬP";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(12, 63);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(87, 23);
            this.ultraLabel2.TabIndex = 0;
            this.ultraLabel2.Text = "Tên đăng nhập:";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(12, 92);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(87, 23);
            this.ultraLabel3.TabIndex = 0;
            this.ultraLabel3.Text = "Password:";
            // 
            // txtnameLogin
            // 
            this.txtnameLogin.Location = new System.Drawing.Point(105, 59);
            this.txtnameLogin.Name = "txtnameLogin";
            this.txtnameLogin.NullText = "Nhập tên đăng nhập ...";
            this.txtnameLogin.Size = new System.Drawing.Size(189, 21);
            this.txtnameLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Nhập password ...";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(189, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // Oke
            // 
            appearance2.Image = global::AppSalesManager.Properties.Resources.apply_32;
            this.Oke.Appearance = appearance2;
            this.Oke.Location = new System.Drawing.Point(157, 152);
            this.Oke.Name = "Oke";
            this.Oke.Size = new System.Drawing.Size(137, 23);
            this.Oke.TabIndex = 3;
            this.Oke.Text = "Login";
            this.Oke.Click += new System.EventHandler(this.Oke_Click);
            // 
            // Close
            // 
            appearance3.Image = global::AppSalesManager.Properties.Resources.close;
            this.Close.Appearance = appearance3;
            this.Close.Location = new System.Drawing.Point(12, 152);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(139, 23);
            this.Close.TabIndex = 4;
            this.Close.Text = "Đóng";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 203);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Oke);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtnameLogin);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtnameLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtnameLogin;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassword;
        private Infragistics.Win.Misc.UltraButton Oke;
        private Infragistics.Win.Misc.UltraButton Close;
    }
}