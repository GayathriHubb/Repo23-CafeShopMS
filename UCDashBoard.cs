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

namespace CafeShopMS
{
    public partial class UCDashBoard : UserControl
    {
        public UCDashBoard()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        private void UCDashBoard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayTotalCashiers();
                    DisplayTotalCustms();
                    DisplayTodayIncome();
                    DisplayTotalIncome();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex.Source}", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        public void DisplayTotalCashiers()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();

                    string totcashiers = "Select Count(*) From Users Where Role = @role AND Status = @status";

                    using (SqlCommand cashierscmd = new SqlCommand(totcashiers, con))
                    {
                        cashierscmd.Parameters.AddWithValue("@role", "Cashier");
                        cashierscmd.Parameters.AddWithValue("@status", "Active");

                        object result = cashierscmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            LbCashiers.Text = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DTotCashiers - ErrorMessage", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }
        }

        public void DisplayTotalCustms()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();

                    string totcustms = "Select Count(*) From Customers";

                    using (SqlCommand totcustmscmd = new SqlCommand(totcustms, con))
                    {

                        object result = totcustmscmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            LbCustms.Text = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DTotCustms - ErrorMessage", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }
        }

        public void DisplayTodayIncome()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();

                    string todinc = "Select SUM(TotalPrice) From Customers Where OrderDate = @orddt";

                    using (SqlCommand todinccmd = new SqlCommand(todinc, con))
                    {
                        todinccmd.Parameters.AddWithValue("@orddt", DateTime.Today);
                        object result = todinccmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int tod = Convert.ToInt32(result);
                            LbTodIncome.Text = tod.ToString("0.##");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DTodInc - ErrorMessage", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally { con.Close(); }

            }
        }

        public void DisplayTotalIncome()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();

                    string totinc = "Select SUM(TotalPrice) From Customers";

                    using (SqlCommand totinccmd = new SqlCommand(totinc, con))
                    {
                        object result = totinccmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int tot = Convert.ToInt32(result);
                            LbTotIncome.Text = tot.ToString("0.##");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DTotInc - ErrorMessage", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally { con.Close(); }

            }
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayTotalCashiers();
            DisplayTotalCustms();
            DisplayTodayIncome();
            DisplayTotalIncome();
        }
    }
}
