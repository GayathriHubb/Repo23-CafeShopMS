using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CafeShopMS
{
    internal class OrdersData
    {
        public OrdersData() { }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProductId { get; set; }   
        public string ProductName { get; set; }
        public string ProductType { get; set; } 
        public int ProductQty { get; set; }
        public float POrgPrice { get; set; }
        public float PTotalPrice { get; set; }
        public string OrderDate { get; set; }

        public List<OrdersData> ListOrdersData()
        {
            List<OrdersData> orderslist = new List<OrdersData>();

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    int custid = 0;
                    string selcustid = "Select MAX(CustomerId) From Orders";
                    using (SqlCommand custidcmd = new SqlCommand(selcustid, con))
                    {
                       object result = custidcmd.ExecuteScalar();

                        int maxId = 0;
                        if (result != null && result != DBNull.Value)
                        {
                            int.TryParse(result.ToString(), out maxId);
                        }
                        custid = (maxId == 0) ? 1 : maxId;

                    }
                            
                    string selectdata = "Select * From Orders Where CustomerId = @custid";

                    using (SqlCommand selcmd = new SqlCommand(selectdata, con))
                    {
                       selcmd.Parameters.AddWithValue("@custid", custid);
                       SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            OrdersData orders = new OrdersData();

                            orders.Id = (int)sdr["Id"];
                            orders.CustomerId = (int)sdr["CustomerId"];
                            orders.ProductId = sdr["ProductId"].ToString();
                            orders.ProductName = sdr["ProductName"].ToString();
                            orders.ProductType = sdr["ProductType"].ToString();
                            orders.ProductQty = (int)sdr["ProductQty"];
                            orders.PTotalPrice = Convert.ToSingle(sdr["PTotalPrice"]);
                            orders.OrderDate = (Convert.ToDateTime(sdr["OrderDate"])).ToString("dd-MM-yyyy");

                            if (sdr["POrgPrice"] != DBNull.Value)
                            {
                                orders.POrgPrice = Convert.ToSingle(sdr["POrgPrice"]);
                            }

                            orderslist.Add(orders);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "OrdersData");
                }
                finally { con.Close(); }
            }

            return orderslist;
        }
        


    }
}
