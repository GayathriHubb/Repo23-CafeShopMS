namespace CafeShopMS
{
    partial class UCAdminCashiers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnImport = new System.Windows.Forms.Button();
            this.PnlPhoto = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.CmbBxRole = new System.Windows.Forms.ComboBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.LbStatus = new System.Windows.Forms.Label();
            this.LbRole = new System.Windows.Forms.Label();
            this.LbPswrd = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.LbCashiersData = new System.Windows.Forms.Label();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.PicBxProfile = new System.Windows.Forms.PictureBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.PnlTop.SuspendLayout();
            this.PnlPhoto.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.PnlTop.Controls.Add(this.BtnRemove);
            this.PnlTop.Controls.Add(this.BtnImport);
            this.PnlTop.Controls.Add(this.PnlPhoto);
            this.PnlTop.Controls.Add(this.BtnClear);
            this.PnlTop.Controls.Add(this.BtnDelete);
            this.PnlTop.Controls.Add(this.BtnUpdate);
            this.PnlTop.Controls.Add(this.BtnInsert);
            this.PnlTop.Controls.Add(this.CmbBxStatus);
            this.PnlTop.Controls.Add(this.CmbBxRole);
            this.PnlTop.Controls.Add(this.TxtBxPswrd);
            this.PnlTop.Controls.Add(this.TxtBxUsername);
            this.PnlTop.Controls.Add(this.LbStatus);
            this.PnlTop.Controls.Add(this.LbRole);
            this.PnlTop.Controls.Add(this.LbPswrd);
            this.PnlTop.Controls.Add(this.LbUsername);
            this.PnlTop.Location = new System.Drawing.Point(14, 10);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1050, 300);
            this.PnlTop.TabIndex = 0;
            // 
            // BtnImport
            // 
            this.BtnImport.AutoSize = true;
            this.BtnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImport.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.BtnImport.ForeColor = System.Drawing.Color.Linen;
            this.BtnImport.Location = new System.Drawing.Point(794, 186);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(167, 45);
            this.BtnImport.TabIndex = 16;
            this.BtnImport.Text = "Upload Image";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // PnlPhoto
            // 
            this.PnlPhoto.Controls.Add(this.PicBxProfile);
            this.PnlPhoto.Location = new System.Drawing.Point(804, 20);
            this.PnlPhoto.Name = "PnlPhoto";
            this.PnlPhoto.Size = new System.Drawing.Size(150, 150);
            this.PnlPhoto.TabIndex = 2;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Linen;
            this.BtnClear.Location = new System.Drawing.Point(505, 224);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 50);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Linen;
            this.BtnDelete.Location = new System.Drawing.Point(505, 158);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 50);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.Linen;
            this.BtnUpdate.Location = new System.Drawing.Point(505, 92);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(200, 50);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.Linen;
            this.BtnInsert.Location = new System.Drawing.Point(505, 26);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(200, 50);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.CmbBxStatus.Location = new System.Drawing.Point(123, 233);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(200, 36);
            this.CmbBxStatus.TabIndex = 4;
            // 
            // CmbBxRole
            // 
            this.CmbBxRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxRole.FormattingEnabled = true;
            this.CmbBxRole.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.CmbBxRole.Location = new System.Drawing.Point(123, 167);
            this.CmbBxRole.Name = "CmbBxRole";
            this.CmbBxRole.Size = new System.Drawing.Size(200, 36);
            this.CmbBxRole.TabIndex = 3;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(144, 99);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 34);
            this.TxtBxPswrd.TabIndex = 2;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(144, 35);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 34);
            this.TxtBxUsername.TabIndex = 1;
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.ForeColor = System.Drawing.Color.Linen;
            this.LbStatus.Location = new System.Drawing.Point(25, 237);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(67, 28);
            this.LbStatus.TabIndex = 7;
            this.LbStatus.Text = "Status";
            this.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbRole
            // 
            this.LbRole.AutoSize = true;
            this.LbRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRole.ForeColor = System.Drawing.Color.Linen;
            this.LbRole.Location = new System.Drawing.Point(25, 171);
            this.LbRole.Name = "LbRole";
            this.LbRole.Size = new System.Drawing.Size(51, 28);
            this.LbRole.TabIndex = 6;
            this.LbRole.Text = "Role";
            this.LbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPswrd
            // 
            this.LbPswrd.AutoSize = true;
            this.LbPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPswrd.ForeColor = System.Drawing.Color.Linen;
            this.LbPswrd.Location = new System.Drawing.Point(25, 102);
            this.LbPswrd.Name = "LbPswrd";
            this.LbPswrd.Size = new System.Drawing.Size(97, 28);
            this.LbPswrd.TabIndex = 5;
            this.LbPswrd.Text = "Password";
            this.LbPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.ForeColor = System.Drawing.Color.Linen;
            this.LbUsername.Location = new System.Drawing.Point(25, 38);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(107, 28);
            this.LbUsername.TabIndex = 4;
            this.LbUsername.Text = "UserName";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlBottom.Controls.Add(this.LbCashiersData);
            this.PnlBottom.Controls.Add(this.DGVUsers);
            this.PnlBottom.Location = new System.Drawing.Point(14, 330);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(1050, 490);
            this.PnlBottom.TabIndex = 1;
            // 
            // LbCashiersData
            // 
            this.LbCashiersData.AutoSize = true;
            this.LbCashiersData.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCashiersData.ForeColor = System.Drawing.Color.Navy;
            this.LbCashiersData.Location = new System.Drawing.Point(10, 20);
            this.LbCashiersData.Name = "LbCashiersData";
            this.LbCashiersData.Size = new System.Drawing.Size(152, 30);
            this.LbCashiersData.TabIndex = 4;
            this.LbCashiersData.Text = "Cashier\'s Data";
            this.LbCashiersData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVUsers
            // 
            this.DGVUsers.AllowUserToAddRows = false;
            this.DGVUsers.AllowUserToDeleteRows = false;
            this.DGVUsers.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUsers.ColumnHeadersHeight = 35;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.Location = new System.Drawing.Point(10, 60);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersWidth = 40;
            this.DGVUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVUsers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUsers.RowTemplate.Height = 28;
            this.DGVUsers.Size = new System.Drawing.Size(1030, 410);
            this.DGVUsers.TabIndex = 0;
            this.DGVUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellClick);
            // 
            // PicBxProfile
            // 
            this.PicBxProfile.BackColor = System.Drawing.Color.DimGray;
            this.PicBxProfile.Location = new System.Drawing.Point(0, 0);
            this.PicBxProfile.Name = "PicBxProfile";
            this.PicBxProfile.Size = new System.Drawing.Size(150, 150);
            this.PicBxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxProfile.TabIndex = 0;
            this.PicBxProfile.TabStop = false;
            // 
            // BtnRemove
            // 
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.ForeColor = System.Drawing.Color.Linen;
            this.BtnRemove.Location = new System.Drawing.Point(790, 235);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(175, 45);
            this.BtnRemove.TabIndex = 17;
            this.BtnRemove.Text = "Remove Image";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Visible = false;
            // 
            // UCAdminCashiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.Name = "UCAdminCashiers";
            this.Size = new System.Drawing.Size(1078, 844);
            this.Load += new System.EventHandler(this.UCAdminCashiers_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.PnlPhoto.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.Label LbRole;
        private System.Windows.Forms.Label LbPswrd;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbCashiersData;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.ComboBox CmbBxRole;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Panel PnlPhoto;
        private System.Windows.Forms.PictureBox PicBxProfile;
        private System.Windows.Forms.Button BtnRemove;
    }
}
