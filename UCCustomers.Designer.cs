namespace CafeShopMS
{
    partial class UCCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomers));
            this.PnlCust = new System.Windows.Forms.Panel();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.LbCustData = new System.Windows.Forms.Label();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PnlCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCust
            // 
            this.PnlCust.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlCust.Controls.Add(this.BtnReceipt);
            this.PnlCust.Controls.Add(this.LbCustData);
            this.PnlCust.Controls.Add(this.DGVCustomers);
            this.PnlCust.Location = new System.Drawing.Point(14, 10);
            this.PnlCust.Name = "PnlCust";
            this.PnlCust.Size = new System.Drawing.Size(1050, 810);
            this.PnlCust.TabIndex = 0;
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.AutoSize = true;
            this.BtnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(40)))), ((int)(((byte)(5)))));
            this.BtnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceipt.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.BtnReceipt.ForeColor = System.Drawing.Color.Linen;
            this.BtnReceipt.Location = new System.Drawing.Point(445, 765);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(160, 40);
            this.BtnReceipt.TabIndex = 7;
            this.BtnReceipt.Text = "Receipt";
            this.BtnReceipt.UseVisualStyleBackColor = false;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // LbCustData
            // 
            this.LbCustData.AutoSize = true;
            this.LbCustData.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCustData.ForeColor = System.Drawing.Color.Navy;
            this.LbCustData.Location = new System.Drawing.Point(10, 20);
            this.LbCustData.Name = "LbCustData";
            this.LbCustData.Size = new System.Drawing.Size(175, 30);
            this.LbCustData.TabIndex = 6;
            this.LbCustData.Text = "Customer\'s Data";
            this.LbCustData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.AllowUserToAddRows = false;
            this.DGVCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCustomers.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCustomers.ColumnHeadersHeight = 35;
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCustomers.EnableHeadersVisualStyles = false;
            this.DGVCustomers.Location = new System.Drawing.Point(10, 60);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowHeadersWidth = 40;
            this.DGVCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCustomers.RowTemplate.Height = 28;
            this.DGVCustomers.Size = new System.Drawing.Size(1030, 700);
            this.DGVCustomers.TabIndex = 5;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellClick);
            // 
            // PD1
            // 
            this.PD1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD1_PrintPage);
            // 
            // PPD1
            // 
            this.PPD1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD1.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD1.Document = this.PD1;
            this.PPD1.Enabled = true;
            this.PPD1.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD1.Icon")));
            this.PPD1.Name = "PPD1";
            this.PPD1.Visible = false;
            // 
            // UCCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlCust);
            this.Name = "UCCustomers";
            this.Size = new System.Drawing.Size(1078, 844);
            this.Load += new System.EventHandler(this.UCCustomers_Load);
            this.PnlCust.ResumeLayout(false);
            this.PnlCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCust;
        private System.Windows.Forms.Label LbCustData;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
    }
}
