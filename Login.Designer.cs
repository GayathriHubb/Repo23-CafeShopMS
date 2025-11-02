namespace CafeShopMS
{
    partial class Form1Login
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
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBxCafe = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtBxUserName = new System.Windows.Forms.TextBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.PicBxUser = new System.Windows.Forms.PictureBox();
            this.LbWelUser = new System.Windows.Forms.Label();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.PnlLeft.Controls.Add(this.BtnRegister);
            this.PnlLeft.Controls.Add(this.label2);
            this.PnlLeft.Controls.Add(this.label1);
            this.PnlLeft.Controls.Add(this.PicBxCafe);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(400, 644);
            this.PnlLeft.TabIndex = 0;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Linen;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnRegister.Location = new System.Drawing.Point(50, 565);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(300, 50);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(89, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create An Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(30, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAFESHOP\r\nMANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBxCafe
            // 
            this.PicBxCafe.Image = global::CafeShopMS.Properties.Resources.Cafe;
            this.PicBxCafe.Location = new System.Drawing.Point(125, 63);
            this.PicBxCafe.Name = "PicBxCafe";
            this.PicBxCafe.Size = new System.Drawing.Size(150, 150);
            this.PicBxCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxCafe.TabIndex = 0;
            this.PicBxCafe.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Linen;
            this.BtnLogin.Location = new System.Drawing.Point(558, 510);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(150, 40);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Linen;
            this.BtnClear.Location = new System.Drawing.Point(558, 568);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 40);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtBxUserName
            // 
            this.TxtBxUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUserName.Location = new System.Drawing.Point(450, 230);
            this.TxtBxUserName.Name = "TxtBxUserName";
            this.TxtBxUserName.Size = new System.Drawing.Size(300, 34);
            this.TxtBxUserName.TabIndex = 2;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(450, 330);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 34);
            this.TxtBxPswrd.TabIndex = 3;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.ChkBxPswrd.Location = new System.Drawing.Point(450, 405);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(182, 25);
            this.ChkBxPswrd.TabIndex = 4;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // PicBxUser
            // 
            this.PicBxUser.Image = global::CafeShopMS.Properties.Resources.ProfileColor;
            this.PicBxUser.Location = new System.Drawing.Point(592, 30);
            this.PicBxUser.Name = "PicBxUser";
            this.PicBxUser.Size = new System.Drawing.Size(80, 80);
            this.PicBxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxUser.TabIndex = 1;
            this.PicBxUser.TabStop = false;
            // 
            // LbWelUser
            // 
            this.LbWelUser.AutoSize = true;
            this.LbWelUser.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.LbWelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.LbWelUser.Location = new System.Drawing.Point(584, 115);
            this.LbWelUser.Name = "LbWelUser";
            this.LbWelUser.Size = new System.Drawing.Size(97, 32);
            this.LbWelUser.TabIndex = 8;
            this.LbWelUser.Text = "Login";
            this.LbWelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.LbWelUser);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.TxtBxUserName);
            this.Controls.Add(this.TxtBxPswrd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PicBxUser);
            this.Controls.Add(this.PnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1Login_Load);
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBxCafe;
        private System.Windows.Forms.PictureBox PicBxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtBxUserName;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Label LbWelUser;
    }
}