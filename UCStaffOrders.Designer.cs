namespace CafeShopMS
{
    partial class UCStaffOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStaffOrders));
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.LbPId = new System.Windows.Forms.Label();
            this.LbPName = new System.Windows.Forms.Label();
            this.LbPPrice = new System.Windows.Forms.Label();
            this.LbPrdName = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.NumUpdownQty = new System.Windows.Forms.NumericUpDown();
            this.LbQty = new System.Windows.Forms.Label();
            this.LbPrice = new System.Windows.Forms.Label();
            this.LbPrdType = new System.Windows.Forms.Label();
            this.LbPrdId = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.LbMenu = new System.Windows.Forms.Label();
            this.DGVMenu = new System.Windows.Forms.DataGridView();
            this.Pnl3 = new System.Windows.Forms.Panel();
            this.TxtBxTenChange = new System.Windows.Forms.TextBox();
            this.TxtBxTenCash = new System.Windows.Forms.TextBox();
            this.TxtBxTPrice = new System.Windows.Forms.TextBox();
            this.LbTenChange = new System.Windows.Forms.Label();
            this.LbTenCash = new System.Windows.Forms.Label();
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.LbTPrice = new System.Windows.Forms.Label();
            this.DGVOrders = new System.Windows.Forms.DataGridView();
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.CmbBxPType = new System.Windows.Forms.ComboBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdownQty)).BeginInit();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenu)).BeginInit();
            this.Pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.Pnl1.Controls.Add(this.BtnRefresh);
            this.Pnl1.Controls.Add(this.CmbBxPType);
            this.Pnl1.Controls.Add(this.LbPId);
            this.Pnl1.Controls.Add(this.LbPName);
            this.Pnl1.Controls.Add(this.LbPPrice);
            this.Pnl1.Controls.Add(this.LbPrdName);
            this.Pnl1.Controls.Add(this.BtnClear);
            this.Pnl1.Controls.Add(this.BtnInsert);
            this.Pnl1.Controls.Add(this.BtnRemove);
            this.Pnl1.Controls.Add(this.NumUpdownQty);
            this.Pnl1.Controls.Add(this.LbQty);
            this.Pnl1.Controls.Add(this.LbPrice);
            this.Pnl1.Controls.Add(this.LbPrdType);
            this.Pnl1.Controls.Add(this.LbPrdId);
            this.Pnl1.Location = new System.Drawing.Point(10, 10);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(700, 410);
            this.Pnl1.TabIndex = 0;
            // 
            // LbPId
            // 
            this.LbPId.AutoSize = true;
            this.LbPId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPId.ForeColor = System.Drawing.Color.Linen;
            this.LbPId.Location = new System.Drawing.Point(195, 91);
            this.LbPId.Name = "LbPId";
            this.LbPId.Size = new System.Drawing.Size(76, 28);
            this.LbPId.TabIndex = 35;
            this.LbPId.Text = "--------";
            this.LbPId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPName
            // 
            this.LbPName.AutoSize = true;
            this.LbPName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPName.ForeColor = System.Drawing.Color.Linen;
            this.LbPName.Location = new System.Drawing.Point(195, 153);
            this.LbPName.Name = "LbPName";
            this.LbPName.Size = new System.Drawing.Size(76, 28);
            this.LbPName.TabIndex = 0;
            this.LbPName.Text = "--------";
            this.LbPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPPrice
            // 
            this.LbPPrice.AutoSize = true;
            this.LbPPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPPrice.ForeColor = System.Drawing.Color.Linen;
            this.LbPPrice.Location = new System.Drawing.Point(195, 214);
            this.LbPPrice.Name = "LbPPrice";
            this.LbPPrice.Size = new System.Drawing.Size(76, 28);
            this.LbPPrice.TabIndex = 0;
            this.LbPPrice.Text = "--------";
            this.LbPPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPrdName
            // 
            this.LbPrdName.AutoSize = true;
            this.LbPrdName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrdName.ForeColor = System.Drawing.Color.Tan;
            this.LbPrdName.Location = new System.Drawing.Point(25, 153);
            this.LbPrdName.Name = "LbPrdName";
            this.LbPrdName.Size = new System.Drawing.Size(143, 28);
            this.LbPrdName.TabIndex = 22;
            this.LbPrdName.Text = "Product Name";
            this.LbPrdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.Linen;
            this.BtnClear.Location = new System.Drawing.Point(334, 335);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 40);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnInsert.ForeColor = System.Drawing.Color.Linen;
            this.BtnInsert.Location = new System.Drawing.Point(35, 335);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(120, 40);
            this.BtnInsert.TabIndex = 6;
            this.BtnInsert.Text = "Add";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.ForeColor = System.Drawing.Color.Linen;
            this.BtnRemove.Location = new System.Drawing.Point(183, 335);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(123, 40);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // NumUpdownQty
            // 
            this.NumUpdownQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUpdownQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumUpdownQty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpdownQty.Location = new System.Drawing.Point(196, 272);
            this.NumUpdownQty.Name = "NumUpdownQty";
            this.NumUpdownQty.Size = new System.Drawing.Size(150, 34);
            this.NumUpdownQty.TabIndex = 4;
            // 
            // LbQty
            // 
            this.LbQty.AutoSize = true;
            this.LbQty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQty.ForeColor = System.Drawing.Color.Tan;
            this.LbQty.Location = new System.Drawing.Point(25, 276);
            this.LbQty.Name = "LbQty";
            this.LbQty.Size = new System.Drawing.Size(90, 28);
            this.LbQty.TabIndex = 33;
            this.LbQty.Text = "Quantity";
            this.LbQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPrice
            // 
            this.LbPrice.AutoSize = true;
            this.LbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrice.ForeColor = System.Drawing.Color.Tan;
            this.LbPrice.Location = new System.Drawing.Point(25, 214);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(87, 28);
            this.LbPrice.TabIndex = 30;
            this.LbPrice.Text = "Price (₹)";
            this.LbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPrdType
            // 
            this.LbPrdType.AutoSize = true;
            this.LbPrdType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrdType.ForeColor = System.Drawing.Color.Tan;
            this.LbPrdType.Location = new System.Drawing.Point(25, 22);
            this.LbPrdType.Name = "LbPrdType";
            this.LbPrdType.Size = new System.Drawing.Size(132, 28);
            this.LbPrdType.TabIndex = 23;
            this.LbPrdType.Text = "Product Type";
            this.LbPrdType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPrdId
            // 
            this.LbPrdId.AutoSize = true;
            this.LbPrdId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrdId.ForeColor = System.Drawing.Color.Tan;
            this.LbPrdId.Location = new System.Drawing.Point(25, 91);
            this.LbPrdId.Name = "LbPrdId";
            this.LbPrdId.Size = new System.Drawing.Size(107, 28);
            this.LbPrdId.TabIndex = 21;
            this.LbPrdId.Text = "Product Id";
            this.LbPrdId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Pnl2.Controls.Add(this.LbMenu);
            this.Pnl2.Controls.Add(this.DGVMenu);
            this.Pnl2.Location = new System.Drawing.Point(10, 430);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(700, 390);
            this.Pnl2.TabIndex = 0;
            // 
            // LbMenu
            // 
            this.LbMenu.AutoSize = true;
            this.LbMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMenu.ForeColor = System.Drawing.Color.Navy;
            this.LbMenu.Location = new System.Drawing.Point(10, 10);
            this.LbMenu.Name = "LbMenu";
            this.LbMenu.Size = new System.Drawing.Size(71, 30);
            this.LbMenu.TabIndex = 6;
            this.LbMenu.Text = "Menu";
            this.LbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVMenu
            // 
            this.DGVMenu.AllowUserToAddRows = false;
            this.DGVMenu.AllowUserToDeleteRows = false;
            this.DGVMenu.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMenu.ColumnHeadersHeight = 35;
            this.DGVMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVMenu.EnableHeadersVisualStyles = false;
            this.DGVMenu.Location = new System.Drawing.Point(10, 50);
            this.DGVMenu.Name = "DGVMenu";
            this.DGVMenu.RowHeadersWidth = 40;
            this.DGVMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVMenu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMenu.RowTemplate.Height = 28;
            this.DGVMenu.Size = new System.Drawing.Size(680, 330);
            this.DGVMenu.TabIndex = 5;
            this.DGVMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMenu_CellClick);
            // 
            // Pnl3
            // 
            this.Pnl3.BackColor = System.Drawing.Color.Sienna;
            this.Pnl3.Controls.Add(this.TxtBxTenChange);
            this.Pnl3.Controls.Add(this.TxtBxTenCash);
            this.Pnl3.Controls.Add(this.TxtBxTPrice);
            this.Pnl3.Controls.Add(this.LbTenChange);
            this.Pnl3.Controls.Add(this.LbTenCash);
            this.Pnl3.Controls.Add(this.BtnPay);
            this.Pnl3.Controls.Add(this.BtnReceipt);
            this.Pnl3.Controls.Add(this.LbTPrice);
            this.Pnl3.Controls.Add(this.DGVOrders);
            this.Pnl3.Location = new System.Drawing.Point(720, 10);
            this.Pnl3.Name = "Pnl3";
            this.Pnl3.Size = new System.Drawing.Size(340, 810);
            this.Pnl3.TabIndex = 0;
            // 
            // TxtBxTenChange
            // 
            this.TxtBxTenChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTenChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTenChange.Location = new System.Drawing.Point(198, 577);
            this.TxtBxTenChange.Name = "TxtBxTenChange";
            this.TxtBxTenChange.Size = new System.Drawing.Size(120, 34);
            this.TxtBxTenChange.TabIndex = 11;
            // 
            // TxtBxTenCash
            // 
            this.TxtBxTenCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTenCash.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTenCash.Location = new System.Drawing.Point(170, 511);
            this.TxtBxTenCash.Name = "TxtBxTenCash";
            this.TxtBxTenCash.Size = new System.Drawing.Size(150, 34);
            this.TxtBxTenCash.TabIndex = 10;
            this.TxtBxTenCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBxTenCash_KeyDown);
            // 
            // TxtBxTPrice
            // 
            this.TxtBxTPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTPrice.Location = new System.Drawing.Point(141, 447);
            this.TxtBxTPrice.Name = "TxtBxTPrice";
            this.TxtBxTPrice.Size = new System.Drawing.Size(150, 34);
            this.TxtBxTPrice.TabIndex = 9;
            // 
            // LbTenChange
            // 
            this.LbTenChange.AutoSize = true;
            this.LbTenChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenChange.ForeColor = System.Drawing.Color.Black;
            this.LbTenChange.Location = new System.Drawing.Point(6, 582);
            this.LbTenChange.Name = "LbTenChange";
            this.LbTenChange.Size = new System.Drawing.Size(184, 25);
            this.LbTenChange.TabIndex = 41;
            this.LbTenChange.Text = "Tendered Change (₹)";
            this.LbTenChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbTenCash
            // 
            this.LbTenCash.AutoSize = true;
            this.LbTenCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenCash.ForeColor = System.Drawing.Color.Black;
            this.LbTenCash.Location = new System.Drawing.Point(6, 516);
            this.LbTenCash.Name = "LbTenCash";
            this.LbTenCash.Size = new System.Drawing.Size(155, 25);
            this.LbTenCash.TabIndex = 40;
            this.LbTenCash.Text = "Tendered Cash(₹)";
            this.LbTenCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPay
            // 
            this.BtnPay.AutoSize = true;
            this.BtnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPay.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.ForeColor = System.Drawing.Color.Linen;
            this.BtnPay.Location = new System.Drawing.Point(82, 665);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(186, 50);
            this.BtnPay.TabIndex = 12;
            this.BtnPay.Text = "PAY ORDERS";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.AutoSize = true;
            this.BtnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceipt.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReceipt.ForeColor = System.Drawing.Color.Linen;
            this.BtnReceipt.Location = new System.Drawing.Point(82, 735);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(180, 50);
            this.BtnReceipt.TabIndex = 13;
            this.BtnReceipt.Text = "RECEIPT";
            this.BtnReceipt.UseVisualStyleBackColor = false;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // LbTPrice
            // 
            this.LbTPrice.AutoSize = true;
            this.LbTPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTPrice.ForeColor = System.Drawing.Color.Black;
            this.LbTPrice.Location = new System.Drawing.Point(6, 452);
            this.LbTPrice.Name = "LbTPrice";
            this.LbTPrice.Size = new System.Drawing.Size(125, 25);
            this.LbTPrice.TabIndex = 37;
            this.LbTPrice.Text = "Total Price (₹)";
            this.LbTPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVOrders
            // 
            this.DGVOrders.AllowUserToAddRows = false;
            this.DGVOrders.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVOrders.ColumnHeadersHeight = 35;
            this.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVOrders.EnableHeadersVisualStyles = false;
            this.DGVOrders.Location = new System.Drawing.Point(10, 10);
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.RowHeadersWidth = 40;
            this.DGVOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVOrders.RowTemplate.Height = 28;
            this.DGVOrders.Size = new System.Drawing.Size(320, 410);
            this.DGVOrders.TabIndex = 6;
            this.DGVOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrders_CellClick);
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
            // CmbBxPType
            // 
            this.CmbBxPType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxPType.ForeColor = System.Drawing.Color.Black;
            this.CmbBxPType.FormattingEnabled = true;
            this.CmbBxPType.Location = new System.Drawing.Point(187, 20);
            this.CmbBxPType.Name = "CmbBxPType";
            this.CmbBxPType.Size = new System.Drawing.Size(254, 33);
            this.CmbBxPType.TabIndex = 38;
            this.CmbBxPType.SelectedIndexChanged += new System.EventHandler(this.CmbBxPType_SelectedIndexChanged);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnRefresh.ForeColor = System.Drawing.Color.Linen;
            this.BtnRefresh.Location = new System.Drawing.Point(482, 335);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(120, 40);
            this.BtnRefresh.TabIndex = 41;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // UCStaffOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl3);
            this.Controls.Add(this.Pnl1);
            this.Name = "UCStaffOrders";
            this.Size = new System.Drawing.Size(1078, 844);
            this.Load += new System.EventHandler(this.UCStaffOrders_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdownQty)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMenu)).EndInit();
            this.Pnl3.ResumeLayout(false);
            this.Pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Panel Pnl3;
        private System.Windows.Forms.Label LbMenu;
        private System.Windows.Forms.DataGridView DGVMenu;
        private System.Windows.Forms.Label LbPrice;
        private System.Windows.Forms.Label LbPrdType;
        private System.Windows.Forms.Label LbPrdName;
        private System.Windows.Forms.Label LbPrdId;
        private System.Windows.Forms.NumericUpDown NumUpdownQty;
        private System.Windows.Forms.Label LbQty;
        private System.Windows.Forms.DataGridView DGVOrders;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Windows.Forms.Label LbTPrice;
        private System.Windows.Forms.TextBox TxtBxTenChange;
        private System.Windows.Forms.TextBox TxtBxTenCash;
        private System.Windows.Forms.TextBox TxtBxTPrice;
        private System.Windows.Forms.Label LbTenChange;
        private System.Windows.Forms.Label LbTenCash;
        private System.Windows.Forms.Label LbPName;
        private System.Windows.Forms.Label LbPPrice;
        private System.Windows.Forms.Label LbPId;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
        private System.Windows.Forms.ComboBox CmbBxPType;
        private System.Windows.Forms.Button BtnRefresh;
    }
}
