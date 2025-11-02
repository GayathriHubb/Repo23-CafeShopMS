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
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        private void Form1Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(TxtBxUserName.Text) || string.IsNullOrWhiteSpace(TxtBxPswrd.Text))
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
                        string selectdata = "Select * From Users Where (Username = @un AND Password = @pswd) AND Status = 'Active' OR Status = 'Approval'";
                        using (SqlCommand selectdatacmd = new SqlCommand(selectdata, con))
                        {
                            selectdatacmd.Parameters.AddWithValue("@un", TxtBxUserName.Text.Trim());
                            selectdatacmd.Parameters.AddWithValue("@pswd", TxtBxPswrd.Text.Trim());

                            SqlDataAdapter sda = new SqlDataAdapter(selectdatacmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfull", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                string role1 = "Select Role From Users Where Username = @un";
                                using (SqlCommand rolecmd = new SqlCommand(role1, con))
                                {
                                    rolecmd.Parameters.AddWithValue("@un", TxtBxUserName.Text.Trim());
                                    string role2 = rolecmd.ExecuteScalar() as string;

                                    if (role2 == "Admin")
                                    {
                                        AdminMainForm adminform = new AdminMainForm();
                                        adminform.Show();
                                        Hide();
                                    }
                                    if (role2 == "Cashier")
                                    {
                                        CafeShopData.Username = TxtBxUserName.Text.Trim();
                                        StaffMainForm staffMainForm = new StaffMainForm();
                                        staffMainForm.Show();
                                        Hide();
                                    }

                                }
                            }
                            else 
                            {
                                MessageBox.Show("Incorrect Username/Password Or There is no Admin's Approval", "Error Massage", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Form2Register registerform = new Form2Register();
            registerform.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
