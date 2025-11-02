using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeShopMS
{
    public partial class Form2Register : Form
    {
        public Form2Register()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");
        private void Form2Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBxUserName.Text) || string.IsNullOrWhiteSpace(TxtBxPswrd.Text) || string.IsNullOrWhiteSpace(TxtBxCnfrmPswrd.Text))
            {
                MessageBox.Show("Please Enter both Username and Password.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();

                        string checkusername = "Select * from Users Where Username = @un";
                        using (SqlCommand checkuncmd = new SqlCommand(checkusername, con))
                        {
                            checkuncmd.Parameters.AddWithValue("@un", TxtBxUserName.Text.Trim());
                            SqlDataAdapter sda = new SqlDataAdapter(checkuncmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                string tempun = $"{TxtBxUserName.Text.Trim().Substring(0, 1).ToUpper()}{TxtBxUserName.Text.Trim().Substring(1)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else if (TxtBxPswrd.Text.Trim().Length < 8)
                            {
                                MessageBox.Show("Invalid Password.. Password Must be 8 Characters or up", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else if (TxtBxPswrd.Text.Trim() != TxtBxCnfrmPswrd.Text.Trim())
                            {
                                MessageBox.Show("Passwords Does Not Match", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertdata = "Insert Into Users (Username, Password, ProfileImage, Role, Status, DateRegister) Values (@un, @pswd, @prfimg, @role, @status, @dtreg)";

                                using (SqlCommand insdatacmd = new SqlCommand(insertdata, con))
                                {
                                    insdatacmd.Parameters.AddWithValue("@un", TxtBxUserName.Text.Trim());
                                    insdatacmd.Parameters.AddWithValue("@pswd", TxtBxPswrd.Text.Trim());
                                    insdatacmd.Parameters.AddWithValue("@prfimg", string.Empty);
                                    insdatacmd.Parameters.AddWithValue("@role", "Cashier");
                                    insdatacmd.Parameters.AddWithValue("@status", "Approval");
                                    insdatacmd.Parameters.AddWithValue("@dtreg", DateTime.Today);

                                    int i = insdatacmd.ExecuteNonQuery();

                                    MessageBox.Show($"{i} Registration Succssfull", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUserName.Text = string.Empty;
            TxtBxPswrd.Text = string.Empty;
            TxtBxCnfrmPswrd.Text = string.Empty;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Form1Login loginform = new Form1Login();
            loginform.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfrmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
