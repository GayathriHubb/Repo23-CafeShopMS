using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopMS
{
    public partial class UCCustomers : UserControl
    {
        public UCCustomers()
        {
            InitializeComponent();
        }

        private void UCCustomers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayCustomersData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\n{ex.Source}", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void DisplayCustomersData()
        {
            CustomersData cd = new CustomersData();
            DGVCustomers.DataSource = cd.ListCustomersData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayCustomersData();
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            PPD1.ShowDialog();
        }


        DataGridViewRow row;
        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            { 
                row = DGVCustomers.Rows[e.RowIndex];
            }
        }

        private void PD1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int centrex1 = (int)(e.PageBounds.Width - g.MeasureString("MoonLight Cafe Shop", new Font("Cambria", 18, FontStyle.Bold)).Width) / 2;
            int centrex2 = (int)(e.PageBounds.Width - g.MeasureString("------------  HAVE A NICE DAY  ------------", new Font("Cambria", 16, FontStyle.Bold)).Width) / 2;
            int heading1y = 100;
            int remdatay = heading1y + 100;
            int remdatax = 50;
            
            Font f = new Font("Lucida Sans", 13, FontStyle.Bold);

            g.DrawString("MoonLight Cafe Shop", new Font("Cambria", 16, FontStyle.Bold), Brushes.Firebrick, new Point(centrex1, heading1y));

            g.DrawString($"Customer Id:  {row.Cells[1].Value}", f, Brushes.Black, new Point(remdatax, remdatay + 50));
            g.DrawString($"Total Price:  {row.Cells[2].Value}", f, Brushes.Black, new Point(remdatax, remdatay + 100));
            g.DrawString($"Tendered Cash:   {row.Cells[3].Value}", f, Brushes.Black, new Point(remdatax, remdatay + 150));
            g.DrawString($"Tendered Change: {row.Cells[4].Value}", f, Brushes.Black, new Point(remdatax, remdatay + 200));
            g.DrawString($"Order Date:  {row.Cells[5].Value}", f, Brushes.Black, new Point(remdatax, remdatay + 250));


            g.DrawString("------------  HAVE A NICE DAY  ------------", f, Brushes.Firebrick, new Point(centrex2, remdatay + 400));

            
        }
    }
}
