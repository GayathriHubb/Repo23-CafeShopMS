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
using System.IO;

namespace CafeShopMS
{
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        bool pstockbool, ppricebool;
        string path = string.Empty;

        private void UCProducts_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayProductsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex.Source}", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
           pstockbool = int.TryParse(TxtBxStock.Text, out int stval);
           ppricebool = float.TryParse(TxtBxPrice.Text, out float prval);

           if (EmptyFields())
           {
                MessageBox.Show("All Fields are Required To be Filled", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
           }
           else if (!pstockbool || stval < 0)
           {
                MessageBox.Show("Please Enter Valid Stock Value", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                TxtBxStock.Focus();
           }
           else if (!ppricebool || prval < 0)
           {
                MessageBox.Show("Please Enter Valid Price", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                TxtBxPrice.Focus();
                return;
           }
           else
           {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();
                        string checkpid = "Select * From Products Where ProductId = @pid";

                        using (SqlCommand pidcmd = new SqlCommand(checkpid, con))
                        {
                            pidcmd.Parameters.AddWithValue("@pid", TxtBxPId.Text.Trim());
                            SqlDataAdapter sda = new SqlDataAdapter(pidcmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show($"Product Id: {TxtBxPId.Text.Trim()} is Existing Already.. Please Use a Different Id", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                            else
                            {
                               try
                               {
                                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                                    string relativepath = Path.Combine("ProductsDirectory", $"{TxtBxPId.Text.Trim().ToUpper()}.jpg");
                                    path = Path.Combine(basedirectory, relativepath);
                                    string directorypath = Path.GetDirectoryName(path);

                                    if (!Directory.Exists(directorypath))
                                    {
                                        Directory.CreateDirectory(directorypath);
                                    }

                                    File.Copy(PicBxProduct?.ImageLocation, path, true);
                               }
                               catch (Exception ex)
                               { 
                                    MessageBox.Show(ex.Message, "PicBox Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); 
                               }

                               string insdata = "Insert Into Products (ProductId, ProductName, ProductType, ProductStock, ProductPrice, ProductStatus, ProductImage, DateInsert) " +
                                                 "Values (@pid, @pname, @ptype, @pstock, @pprice, @pstatus, @pimg, @dtins)";

                                using (SqlCommand inscmd = new SqlCommand(insdata, con))
                                {
                                    inscmd.Parameters.AddWithValue("@pid", TxtBxPId.Text.Trim().ToUpper());
                                    inscmd.Parameters.AddWithValue("@pname", TxtBxPName.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@ptype", CmbBxPType.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@pstock", stval);
                                    inscmd.Parameters.AddWithValue("@pprice", $"{prval:0.##}");
                                    inscmd.Parameters.AddWithValue("@pstatus", CmbBxStatus.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@pimg", path ?? string.Empty);
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    int i = inscmd.ExecuteNonQuery();
                                    DisplayProductsData();
                                    CafeShopData.PStock = stval;
                                    MessageBox.Show("Product Record Added Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }
           }

           ClearFields();   
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            pstockbool = int.TryParse(TxtBxStock.Text, out int stval);
            ppricebool = float.TryParse(TxtBxPrice.Text, out float prval);

            if (EmptyFields())
            {
                MessageBox.Show("All Fields are Required To be Filled", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (!pstockbool || stval < 0)
            {
                MessageBox.Show("Please Enter Valid Stock Value", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                TxtBxStock.Focus();
            }
            else if (!ppricebool || prval < 0)
            {
                MessageBox.Show("Please Enter Valid Price", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                TxtBxPrice.Focus();
                return;
            }
            else
            {
               
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show($"Are you sure you want to Update Product Id: {TxtBxPId.Text.Trim()} ?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            try
                            {
                                string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                                string relativepath = Path.Combine("ProductsDirectory", $"{TxtBxPId.Text.Trim().ToUpper()}.jpg");
                                path = Path.Combine(basedirectory, relativepath);

                                File.Copy(PicBxProduct?.ImageLocation, path, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "PicBox Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            con.Open();
                            string updatedata = "Update Products Set ProductName = @pname, ProductType = @ptype, ProductStock = @pstock, ProductPrice = @pprice, " +
                                "ProductStatus = @pstatus, ProductImage = @pimg, DateUpdate = @dtupd Where ProductId = @pid";

                            using (SqlCommand updcmd = new SqlCommand(updatedata, con))
                            {
                                updcmd.Parameters.AddWithValue("@pid", TxtBxPId.Text.Trim().ToUpper());
                                updcmd.Parameters.AddWithValue("@pname", TxtBxPName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@ptype", CmbBxPType.Text.Trim());
                                updcmd.Parameters.AddWithValue("@pstock", stval);
                                updcmd.Parameters.AddWithValue("@pprice", $"{prval:0.##}");
                                updcmd.Parameters.AddWithValue("@pstatus", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@pimg", path ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);

                                int i = updcmd.ExecuteNonQuery();
                                DisplayProductsData();
                                MessageBox.Show("Product Record Updated Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }
            }

            ClearFields();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("All Fields are Required To be Filled", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you sure you want to Delete Product Id: {TxtBxPId.Text.Trim()} ?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        string deldata = "Update Products Set DateDelete = @dtdlt Where ProductId = @pid AND Id = @id";

                        using (SqlCommand delcmd = new SqlCommand(deldata, con))
                        {
                            delcmd.Parameters.AddWithValue("@id", getid);
                            delcmd.Parameters.AddWithValue("@pid", TxtBxPId.Text.Trim());
                            delcmd.Parameters.AddWithValue("@dtdlt", DateTime.Today);

                            int i = delcmd.ExecuteNonQuery();
                            DisplayProductsData();
                            MessageBox.Show("Product Record Deleted Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        }
                    }
                }
            }

            ClearFields();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            ofd.Title = "Select Image";
            string imgpath = string.Empty;

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgpath = ofd.FileName;
                    PicBxProduct.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }

        }

        int getid;
        private void DGVProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DGVProducts.Rows[e.RowIndex];

                getid = (int)row.Cells[0].Value;

                TxtBxPId.Text = row.Cells[1].Value.ToString();
                TxtBxPName.Text = row.Cells[2].Value.ToString();
                CmbBxPType.Text = row.Cells[3].Value.ToString();
                TxtBxStock.Text = row.Cells[4].Value.ToString();
                TxtBxPrice.Text = row.Cells[5].Value.ToString();
                CmbBxStatus.Text = row.Cells[6].Value.ToString();

                string imgpath = row.Cells[7].Value.ToString();

                try
                {
                    if (File.Exists(imgpath))
                    {
                        PicBxProduct.ImageLocation = imgpath;
                    }
                    PicBxProduct.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PicBox Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

        }

        private void ClearFields()
        {
            TxtBxPId.Text = string.Empty;
            TxtBxPName.Text = string.Empty;
            TxtBxStock.Text = string.Empty;
            TxtBxPrice.Text = string.Empty;
            CmbBxPType.Text = string.Empty;
            CmbBxStatus.Text = string.Empty;
            PicBxProduct.Image = null;
        }

        private bool EmptyFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxPId.Text) || string.IsNullOrWhiteSpace(TxtBxPName.Text) || string.IsNullOrWhiteSpace(TxtBxPrice.Text) ||
                string.IsNullOrWhiteSpace(TxtBxStock.Text) || CmbBxPType.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1)
            {
                return true;
            }

            return false;
        }

        private void DisplayProductsData()
        {
            ProductsData prods = new ProductsData();
            DGVProducts.DataSource = prods.ListProductsData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayProductsData();

        }
    }
}
