using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopMS
{
    public partial class StaffMainForm : Form
    {
        public StaffMainForm()
        {
            InitializeComponent();
        }

        private void StaffMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Close ? ", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else { Application.ExitThread(); }
        }

        private void StaffMainForm_Load(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.Sienna;

            UCDashBoard1.Show();
            UCProducts1.Hide();
            UCStaffOrders1.Hide();
            UCCustomers1.Hide();

            string un = CafeShopData.Username;
            LbUser.Text = $"{un.Substring(0, 1).ToUpper()}{un.Substring(1)}";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Logout ?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Form1Login loginform = new Form1Login();
                loginform.Show();
                Hide();
            }
        }
        private void MainButtons_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            foreach (Button b in PnlLeft.Controls.OfType<Button>())
            {
                if ((string)b.Tag == "MainBtns")
                { b.BackColor = Color.FromArgb(100, 30, 90); }
            }

            btn.BackColor = Color.Sienna;

            switch (btn.Name)
            {
                case "BtnDashboard":
                    UCDashBoard1.Show();
                    UCProducts1.Hide();
                    UCStaffOrders1.Hide();
                    UCCustomers1.Hide();

                    UCDashBoard ucdashboard = UCDashBoard1 as UCDashBoard;
                    ucdashboard?.RefreshData();
                    break;
                case "BtnProducts":
                    UCDashBoard1.Hide();
                    UCProducts1.Show();
                    UCStaffOrders1.Hide();
                    UCCustomers1.Hide();

                    UCProducts ucproducts = UCProducts1 as UCProducts;
                    ucproducts?.RefreshData();
                    break;
                case "BtnOrders":
                    UCDashBoard1.Hide();
                    UCProducts1.Hide();
                    UCStaffOrders1.Show();
                    UCCustomers1.Hide();

                    UCStaffOrders ucstforders = UCStaffOrders1 as UCStaffOrders;
                    ucstforders?.RefreshData();
                    break;
                case "BtnCustomers":
                    UCDashBoard1.Hide();
                    UCProducts1.Hide();
                    UCStaffOrders1.Hide();
                    UCCustomers1.Show();

                    UCCustomers uccustomers = UCCustomers1 as UCCustomers;
                    uccustomers?.RefreshData();
                    break;
                default: UCDashBoard1.Show(); break;
            }
        }

       
    }
}
