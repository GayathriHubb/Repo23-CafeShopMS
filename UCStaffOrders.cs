using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CafeShopMS
{
    public partial class UCStaffOrders : UserControl
    {
        public UCStaffOrders()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True";

        public static int getcustid;
        private void UCStaffOrders_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayAvailProdsData();
                    DisplayOrdersData();
                    DisplayTotalPrice();
                    DisplayProductTypes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex.Source}", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void CmbBxPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedtype = CmbBxPType.SelectedItem.ToString();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Id, ProductId, ProductName, ProductType, ProductStock, ProductPrice, ProductStatus From Products Where ProductType = @ptype AND ProductStatus = @status AND DateDelete is NULL";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@ptype", selectedtype);
                        selcmd.Parameters.AddWithValue("@status", "Available");
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVMenu.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CmbBxPType - Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayProductTypes()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seltype = "Select DISTINCT ProductType From Products Where DateDelete is NULL";
                    using (SqlCommand typecmd = new SqlCommand(seltype, sqlcon))
                    {
                        SqlDataReader sdr = typecmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            CmbBxPType.Items.Add(sdr["ProductType"].ToString());
                        }
                        sdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DisplayProductTypes - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        

        private void DisplayAvailProdsData()
        {
            AvailableProducts prods = new AvailableProducts();
            DGVMenu.DataSource = prods.AvailableProductsData();
        }

        int getid, getpstock;
        private void DGVMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVMenu.Rows[e.RowIndex];
                    getid = (int)row.Cells[0].Value;
                    getpstock = (int)row.Cells[4].Value;

                    LbPId.Text = row.Cells[1].Value.ToString();
                    LbPName.Text = row.Cells[2].Value.ToString();
                    CmbBxPType.Text = row.Cells[3].Value.ToString();
                    LbPPrice.Text = row.Cells[5].Value.ToString();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

            

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            if (LbPId.Text == string.Empty || CmbBxPType.Text == string.Empty || LbPName.Text == string.Empty || LbPPrice.Text == string.Empty || NumUpdownQty.Value == 0)
            {
                MessageBox.Show("Please Select Product And Quantity", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    IdGenerator();
                    GetPrice();

                    string insdata = "Insert Into Orders (CustomerId, ProductId, ProductName, ProductType, ProductQty, POrgPrice, PTotalPrice, OrderDate) " +
                                     "Values (@custid, @pid, @pname, @ptype, @pqty, @porprice, @ptprice, @orddt)";


                    using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                    {
                        float totalprice = (getprice * (int)NumUpdownQty.Value);

                        inscmd.Parameters.AddWithValue("@custid", idgen);
                        inscmd.Parameters.AddWithValue("@pid", LbPId.Text);
                        inscmd.Parameters.AddWithValue("@pname", LbPName.Text);
                        inscmd.Parameters.AddWithValue("@ptype", CmbBxPType.Text);
                        inscmd.Parameters.AddWithValue("@pqty", NumUpdownQty.Value);
                        inscmd.Parameters.AddWithValue("@porprice", getprice);
                        inscmd.Parameters.AddWithValue("@ptprice", totalprice);
                        inscmd.Parameters.AddWithValue("@orddt", DateTime.Today);

                        inscmd.ExecuteNonQuery();
                        DisplayOrdersData();
                        DisplayTotalPrice();
                        UpdateStockWhenAdd();
                        

                        MessageBox.Show("Order Added Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "BtnInsert - Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
               
            }

        }

        float getprice;
        private void GetPrice()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string selectorder = "Select * From Products Where ProductId = @pid";

                    using (SqlCommand ordcmd = new SqlCommand(selectorder, sqlcon))
                    {
                        ordcmd.Parameters.AddWithValue("@pid", LbPId.Text);

                        SqlDataReader sdr = ordcmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            object rawvalue = sdr["ProductPrice"];
                            if (rawvalue != DBNull.Value)
                            {
                                getprice = Convert.ToSingle(sdr["ProductPrice"]);
                            }
                        }
                        sdr.Close();
                    }
                }
                catch (SqlException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (idord == 0)
            {
                MessageBox.Show("Please Select Item First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        DialogResult dr = MessageBox.Show($"Are You Sure You Want To Remove ProductId: {prodid} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            string remdata = "Delete From Orders Where Id = @id";

                            using (SqlCommand remcmd = new SqlCommand(remdata, sqlcon))
                            {
                                remcmd.Parameters.AddWithValue("@id", idord);

                                remcmd.ExecuteNonQuery();
                                DisplayOrdersData();
                                DisplayTotalPrice();
                                UpdateStockWhenRemove();
                                MessageBox.Show("Order Removed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

        }   

        

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (NUDCash.Text == string.Empty || DGVOrders.Rows.Count == 0)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
               
                DialogResult dr = MessageBox.Show("Are You Sure For Paying ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            IdGenerator();
                            DisplayTotalPrice();

                            string insdata = "Insert Into Customers (CustomerId, TotalPrice, Amount, Change, OrderDate) Values (@custid, @totprice, @amnt, @change, @orddt)";

                            using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@custid", idgen);
                                inscmd.Parameters.AddWithValue("@totprice", totalprice);
                                inscmd.Parameters.AddWithValue("@amnt", NUDCash.Value);
                                inscmd.Parameters.AddWithValue("@change", TxtBxTenChange.Text.Trim());
                                inscmd.Parameters.AddWithValue("@orddt", DateTime.Today);

                                inscmd.ExecuteNonQuery();

                                MessageBox.Show("Paid Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "BtnPay - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
        }
        
        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                if (NUDCash.Text == string.Empty || DGVOrders.Rows.Count < 0)
                {
                    MessageBox.Show("Please Order First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                PPD1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BtnReceipt - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        

        private void ClearFields()
        {
            CmbBxPType.Text = string.Empty;
            LbPId.Text = "--------";
            LbPName.Text = "--------";
            LbPPrice.Text = "--------";
            NumUpdownQty.Value = 0;
        }

        float totalprice;
        public void DisplayTotalPrice()
        {
           using (SqlConnection sqlcon = new SqlConnection(constring))
            try
            {
                sqlcon.Open();
                IdGenerator();
                string sumprice = "Select SUM(PTotalPrice) From Orders Where CustomerId = @custid";

                using (SqlCommand pricecmd = new SqlCommand(sumprice, sqlcon))
                {
                    pricecmd.Parameters.AddWithValue("@custid", idgen);

                    object result = pricecmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalprice = Convert.ToSingle(result);
                        TxtBxTPrice.Text = totalprice.ToString("0.##");
                    }

                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DisplayTotalPrice - Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
               
        }

        int rowindex;
        private void PD1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DisplayTotalPrice();
            IdGenerator();
            GetPrice();

            int y = 50;
            int left = 50;
            int colwidth = 120;

            Font headerfont = new Font("Cambria", 18, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Font smallfont = new Font("Segoe UI", 10, FontStyle.Bold);

            int centrex1 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("MoonLight Cafe Shop", headerfont).Width) / 2;
            int centrex2 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Thank You for Shopping!", font).Width) / 2;
            int centrex3 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Visit Again!", font).Width) / 2;

            // ✅ Store Header
            e.Graphics.DrawString("MoonLight Cafe Shop", headerfont, Brushes.Firebrick, centrex1, y);
            y += 80;

            string date = $"Date: {DateTime.Now:dd/MM/yyyy hh:mm tt}";
            int datex = (int)((left + 720) - e.Graphics.MeasureString(date, font).Width);

            // ✅ Date + Bill No
            e.Graphics.DrawString($"Bill No: {idgen - 1}", font, Brushes.Black, left, y);
            e.Graphics.DrawString(date, font, Brushes.Black, datex, y);
            y += 30;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 720, y);
            y += 20;

            // ✅ Table Headers
            string[] headers = { "Product Id", "ProductName", "ProductType", "Quantity", "Price", "Total" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], font, Brushes.Navy, left + (i * colwidth), y);
            }
            y += 25;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 720, y);
            y += 10;

            // ✅ Table Rows
            while (rowindex < DGVOrders.Rows.Count)
            {
                DataGridViewRow row = DGVOrders.Rows[rowindex];

                e.Graphics.DrawString(row.Cells[2].Value.ToString(), smallfont, Brushes.Black, left + 0, y);

                string pname = row.Cells[3].Value.ToString();

                // Limit text width so it wraps
                int textwidth = 120;
                SizeF textsize = e.Graphics.MeasureString(pname, smallfont, textwidth);

                // Draw wrapped product name
                e.Graphics.DrawString(pname, smallfont, Brushes.Black, new RectangleF(left + 120, y, textwidth, textsize.Height));

                e.Graphics.DrawString(row.Cells[4].Value.ToString(), smallfont, Brushes.Black, left + 240, y);
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), smallfont, Brushes.Black, left + 360, y);
                e.Graphics.DrawString(row.Cells[6].Value.ToString(), smallfont, Brushes.Black, left + 480, y);
                e.Graphics.DrawString(row.Cells[7].Value.ToString(), smallfont, Brushes.Black, left + 600, y);

                y += (int)textsize.Height > 25 ? (int)textsize.Height : 25;
                rowindex++;

                if (y > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            y += 20;
            e.Graphics.DrawLine(Pens.Black, left, y, left + 720, y);
            y += 20;

            // ✅ Summary Price Section
            DrawRightAligned(e.Graphics, "TotalPrice(₹):", $"{totalprice: 0.00}", font, left, ref y);
            DrawRightAligned(e.Graphics, "TenderedCash(₹):", $"{NUDCash.Value: 0.00}", font, left, ref y);
            DrawRightAligned(e.Graphics, "TenderedChange(₹):", $"{TxtBxTenChange.Text: 0.00}", font, left, ref y);

            y += 30;
            e.Graphics.DrawLine(Pens.Black, left, y, left + 720, y);
            y += 30;

            // ✅ Footer
            e.Graphics.DrawString("Thank You for Shopping!", font, Brushes.Black, centrex2, y);
            y += 25;
            e.Graphics.DrawString("Visit Again!", smallfont, Brushes.Black, centrex3, y);

            e.HasMorePages = false;

        }

        private void DrawRightAligned(Graphics g, string label, string value, Font font, int left, ref int y)
        {
            g.DrawString(label, font, Brushes.Black, left + 300, y);
            g.DrawString(value, font, Brushes.Black, left + 520, y);
            y += 25;
        }

        private void DisplayOrdersData()
        {
            OrdersData orders = new OrdersData();
            DGVOrders.DataSource = orders.ListOrdersData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayAvailProdsData();
            DisplayOrdersData();
            DisplayTotalPrice();
        }

        int idgen;
        public void IdGenerator()
        {

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    // Use ISNULL to ensure we always get an integer back (0 when table empty).
                    string selectid = "SELECT ISNULL(MAX(CustomerId), 0) FROM Customers";

                    using (SqlCommand idcmd = new SqlCommand(selectid, sqlcon))
                    {
                        object result = idcmd.ExecuteScalar();

                        int maxId = 0;
                        if (result != null && result != DBNull.Value)
                        {
                            int.TryParse(result.ToString(), out maxId);
                        }

                        // If maxId is 0, start ids at 1; otherwise increment.
                        idgen = (maxId == 0) ? 1 : (maxId + 1);
                        getcustid = idgen;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "IdGenerator - Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
         
       
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAvailProdsData();
            ClearFields();
            
        }

        int idord, getpqty;
        string prodid;
        private void DGVOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVOrders.Rows[e.RowIndex];

                    idord = (int)row.Cells[0].Value;
                    prodid = row.Cells[2].Value.ToString();
                    getpqty = (int)row.Cells[5].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        int stockafteradd;

        private void NUDCash_ValueChanged(object sender, EventArgs e)
        {
            float getamount = Convert.ToSingle(NUDCash.Value); 
            float change = getamount - totalprice;

            if (change <= -1)
            {
                NUDCash.Text = string.Empty;
                TxtBxTenChange.Text = string.Empty;
                MessageBox.Show("Insufficient Cash", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                NUDCash.Focus();    
            }
            else
            {
                TxtBxTenChange.Text = change.ToString();
            }
        }

        private void UpdateStockWhenAdd()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();

                string seldata = "Update Products Set ProductStock = @pstock Where ProductId = @pid";
                int stockupd1 = getpstock - (int)NumUpdownQty.Value;
               
                using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                {
                    selcmd.Parameters.AddWithValue("@pid", LbPId.Text);
                    selcmd.Parameters.AddWithValue("@pstock", stockupd1);

                    selcmd.ExecuteNonQuery();

                    stockafteradd = stockupd1;
                }
            }
        }

        private void UpdateStockWhenRemove()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();

                string seldata = "Update Products Set ProductStock = @pstock Where ProductId = @pid";
                int stockupd2 = stockafteradd + getpqty;
                using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                {
                    selcmd.Parameters.AddWithValue("@pid", prodid);
                    selcmd.Parameters.AddWithValue("@pstock", stockupd2);

                    selcmd.ExecuteNonQuery();
                }
            }
        }

        
    }
}
