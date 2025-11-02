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
    public partial class UCAdminCashiers : UserControl
    {
        public UCAdminCashiers()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        string path = string.Empty;
        private void UCAdminCashiers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) 
            {
                try
                {
                    DisplayUsersData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex.Source}", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("All Fields are Required To be Filled", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (TxtBxPswrd.Text.Trim().Length < 8)
            {
                MessageBox.Show("Invalid Password.. Password Must be 8 characters or up", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                TxtBxPswrd.Focus();
                return;
            }
            else
            {
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("ProfilesDirectory", $"{TxtBxUsername.Text.Trim()}.jpg");
                    path = Path.Combine(basedirectory, relativepath);

                    File.Copy(PicBxProfile?.ImageLocation, path, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PicBox Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                if (con.State == ConnectionState.Closed) 
                {
                    try
                    {
                        con.Open();
                        string checkun = "Select * From Users Where Username = @un";

                        using (SqlCommand checkuncmd = new SqlCommand(checkun, con))
                        {
                            checkuncmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            SqlDataAdapter sda = new SqlDataAdapter(checkuncmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                string tempun = $"{TxtBxUsername.Text.Trim().Substring(0, 1).ToUpper()}{TxtBxUsername.Text.Trim().Substring(1)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already.. Please use a Different Name", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                            
                            else
                            {
                                string insdata = "Insert Into Users (Username, Password, Role, Status, ProfileImage, DateRegister) Values (@un, @pswd, @role, @status, @imgpath, @dtreg)";

                                using (SqlCommand insdatacmd =  new SqlCommand(insdata, con))
                                {

                                    insdatacmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                                    insdatacmd.Parameters.AddWithValue("@pswd", TxtBxPswrd.Text.Trim());
                                    insdatacmd.Parameters.AddWithValue("@role", CmbBxRole.Text.Trim());
                                    insdatacmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                    insdatacmd.Parameters.AddWithValue("@imgpath", path ?? string.Empty);
                                    insdatacmd.Parameters.AddWithValue("dtreg", DateTime.Today);

                                    int i = insdatacmd.ExecuteNonQuery();
                                    DisplayUsersData();
                                    MessageBox.Show($"{i} User Added Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally 
                    { con.Close(); }
                }
            }

            ClearFields();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("All Fields are Required To be Filled", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (TxtBxPswrd.Text.Trim().Length < 8)
            {
                MessageBox.Show("Invalid Password.. Password Must be 8 characters or up", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                TxtBxPswrd.Focus();
                return;
            }
            else
            {
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("ProfilesDirectory", $"{TxtBxUsername.Text.Trim()}.jpg");
                    path = Path.Combine(basedirectory, relativepath);

                    File.Copy(PicBxProfile?.ImageLocation, path, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PicBox Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show($"Are You Sure You Want To Update Username: {TxtBxUsername.Text.Trim()} ?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            con.Open();
                            string updatedata = "Update Users Set Password = @pswd, Role = @role, Status = @status, ProfileImage = @imgpath Where Username = @un";

                            using (SqlCommand updcmd = new SqlCommand(updatedata, con))
                            {
                                updcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                                updcmd.Parameters.AddWithValue("@pswd", TxtBxPswrd.Text.Trim());
                                updcmd.Parameters.AddWithValue("@role", CmbBxRole.Text.Trim());
                                updcmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", path ?? string.Empty);

                                updcmd.ExecuteNonQuery();
                                DisplayUsersData();

                                MessageBox.Show("User Record Updated Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }  

                ClearFields();
            }
        }
            
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("All Fields are Required To be Filled", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show($"Are You Sure You Want To Delete Username: {TxtBxUsername.Text.Trim()}", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            con.Open();
                            string deletedata = "Delete From Users Where Username = @un AND Id = @id";

                            using (SqlCommand deletecmd = new SqlCommand(deletedata, con))
                            {
                                deletecmd.Parameters.AddWithValue("@id", getid);
                                deletecmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());

                                deletecmd.ExecuteNonQuery();
                                DisplayUsersData();
                                MessageBox.Show("User Record Deleted Successfully", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally { con.Close(); }
                }

                ClearFields();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
           OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files (*.jpg, *.png) | *.jpg; *.png";
            string imgpath = string.Empty;

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgpath = ofd.FileName;
                    PicBxProfile.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
        }

       

        int getid;
        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                DataGridViewRow row = DGVUsers.Rows[e.RowIndex];

                getid = (int)row.Cells[0].Value;

                TxtBxUsername.Text = row.Cells[1].Value.ToString();
                TxtBxPswrd.Text = row.Cells[2].Value.ToString();
                CmbBxRole.Text = row.Cells[3].Value.ToString();
                CmbBxStatus.Text = row.Cells[4].Value.ToString();

                string imgpath =  row.Cells[5].Value.ToString();

                try
                {
                    if (File.Exists(imgpath))
                    {
                        PicBxProfile.ImageLocation = imgpath;
                    }
                    PicBxProfile.Image = null;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "PicBox Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private bool EmptyFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBxUsername.Text) || string.IsNullOrWhiteSpace(TxtBxPswrd.Text) || 
                CmbBxRole.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        private void ClearFields()
        {
            TxtBxUsername.Text = string.Empty;
            TxtBxPswrd.Text = string.Empty;
            CmbBxRole.SelectedIndex = -1;
            CmbBxStatus.SelectedIndex = -1;
            PicBxProfile.Image = null;
        }

        private void DisplayUsersData()
        {
            UsersData users = new UsersData();
            DGVUsers.DataSource = users.ListUsersData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayUsersData();

        }
       
    }
}
