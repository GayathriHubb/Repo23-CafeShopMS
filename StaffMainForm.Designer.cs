namespace CafeShopMS
{
    partial class StaffMainForm
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
            this.LbCashPortal = new System.Windows.Forms.Label();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.LbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.PicBxCafe = new System.Windows.Forms.PictureBox();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.UCDashBoard1 = new CafeShopMS.UCDashBoard();
            this.UCProducts1 = new CafeShopMS.UCProducts();
            this.UCStaffOrders1 = new CafeShopMS.UCStaffOrders();
            this.UCCustomers1 = new CafeShopMS.UCCustomers();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxCafe)).BeginInit();
            this.PnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbCashPortal
            // 
            this.LbCashPortal.AutoSize = true;
            this.LbCashPortal.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCashPortal.ForeColor = System.Drawing.Color.Linen;
            this.LbCashPortal.Location = new System.Drawing.Point(57, 140);
            this.LbCashPortal.Name = "LbCashPortal";
            this.LbCashPortal.Size = new System.Drawing.Size(187, 25);
            this.LbCashPortal.TabIndex = 2;
            this.LbCashPortal.Text = "Cashier\'s Portal";
            this.LbCashPortal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.PnlLeft.Controls.Add(this.LbUser);
            this.PnlLeft.Controls.Add(this.label1);
            this.PnlLeft.Controls.Add(this.BtnDashboard);
            this.PnlLeft.Controls.Add(this.BtnProducts);
            this.PnlLeft.Controls.Add(this.BtnCustomers);
            this.PnlLeft.Controls.Add(this.BtnLogout);
            this.PnlLeft.Controls.Add(this.LbCashPortal);
            this.PnlLeft.Controls.Add(this.PicBxCafe);
            this.PnlLeft.Controls.Add(this.BtnOrders);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(300, 844);
            this.PnlLeft.TabIndex = 1;
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.LbUser.ForeColor = System.Drawing.Color.Linen;
            this.LbUser.Location = new System.Drawing.Point(125, 180);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(19, 21);
            this.LbUser.TabIndex = 6;
            this.LbUser.Text = "?";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(8, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.Sienna;
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Linen;
            this.BtnDashboard.Location = new System.Drawing.Point(25, 235);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(250, 50);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Tag = "MainBtns";
            this.BtnDashboard.Text = "DASHBOARD";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.AutoSize = true;
            this.BtnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.Linen;
            this.BtnProducts.Location = new System.Drawing.Point(25, 307);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(250, 50);
            this.BtnProducts.TabIndex = 2;
            this.BtnProducts.Tag = "MainBtns";
            this.BtnProducts.Text = "PRODUCTS";
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.AutoSize = true;
            this.BtnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.Linen;
            this.BtnCustomers.Location = new System.Drawing.Point(25, 451);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(250, 50);
            this.BtnCustomers.TabIndex = 4;
            this.BtnCustomers.Tag = "MainBtns";
            this.BtnCustomers.Text = "CUSTOMERS";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogout.AutoSize = true;
            this.BtnLogout.BackColor = System.Drawing.Color.Linen;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnLogout.Location = new System.Drawing.Point(25, 700);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(250, 50);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PicBxCafe
            // 
            this.PicBxCafe.Image = global::CafeShopMS.Properties.Resources.Cafe;
            this.PicBxCafe.Location = new System.Drawing.Point(100, 30);
            this.PicBxCafe.Name = "PicBxCafe";
            this.PicBxCafe.Size = new System.Drawing.Size(100, 100);
            this.PicBxCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxCafe.TabIndex = 1;
            this.PicBxCafe.TabStop = false;
            // 
            // BtnOrders
            // 
            this.BtnOrders.AutoSize = true;
            this.BtnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.BtnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrders.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.ForeColor = System.Drawing.Color.Linen;
            this.BtnOrders.Location = new System.Drawing.Point(25, 379);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(250, 50);
            this.BtnOrders.TabIndex = 3;
            this.BtnOrders.Tag = "MainBtns";
            this.BtnOrders.Text = "ORDERS";
            this.BtnOrders.UseVisualStyleBackColor = false;
            this.BtnOrders.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // PnlRight
            // 
            this.PnlRight.Controls.Add(this.UCDashBoard1);
            this.PnlRight.Controls.Add(this.UCProducts1);
            this.PnlRight.Controls.Add(this.UCStaffOrders1);
            this.PnlRight.Controls.Add(this.UCCustomers1);
            this.PnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRight.Location = new System.Drawing.Point(300, 0);
            this.PnlRight.Name = "PnlRight";
            this.PnlRight.Size = new System.Drawing.Size(1078, 844);
            this.PnlRight.TabIndex = 3;
            // 
            // UCDashBoard1
            // 
            this.UCDashBoard1.AutoScroll = true;
            this.UCDashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCDashBoard1.Location = new System.Drawing.Point(0, 0);
            this.UCDashBoard1.Name = "UCDashBoard1";
            this.UCDashBoard1.Size = new System.Drawing.Size(1078, 844);
            this.UCDashBoard1.TabIndex = 4;
            // 
            // UCProducts1
            // 
            this.UCProducts1.AutoScroll = true;
            this.UCProducts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCProducts1.Location = new System.Drawing.Point(0, 0);
            this.UCProducts1.Name = "UCProducts1";
            this.UCProducts1.Size = new System.Drawing.Size(1078, 844);
            this.UCProducts1.TabIndex = 4;
            // 
            // UCStaffOrders1
            // 
            this.UCStaffOrders1.AutoScroll = true;
            this.UCStaffOrders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCStaffOrders1.Location = new System.Drawing.Point(0, 0);
            this.UCStaffOrders1.Name = "UCStaffOrders1";
            this.UCStaffOrders1.Size = new System.Drawing.Size(1078, 844);
            this.UCStaffOrders1.TabIndex = 4;
            // 
            // UCCustomers1
            // 
            this.UCCustomers1.AutoScroll = true;
            this.UCCustomers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCCustomers1.Location = new System.Drawing.Point(0, 0);
            this.UCCustomers1.Name = "UCCustomers1";
            this.UCCustomers1.Size = new System.Drawing.Size(1078, 844);
            this.UCCustomers1.TabIndex = 0;
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.PnlRight);
            this.Controls.Add(this.PnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StaffMainForm";
            this.Text = "StaffMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffMainForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffMainForm_Load);
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxCafe)).EndInit();
            this.PnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbCashPortal;
        private System.Windows.Forms.PictureBox PicBxCafe;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlRight;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.Label label1;
        private UCCustomers UCCustomers1;
        private UCProducts UCProducts1;
        private UCStaffOrders UCStaffOrders1;
        private UCDashBoard UCDashBoard1;
    }
}