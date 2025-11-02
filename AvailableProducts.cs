using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopMS
{
    internal class AvailableProducts
    {
        public AvailableProducts() { }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ProductStock { get; set; }
        public float ProductPrice { get; set; }
        public string ProductStatus { get; set; }

        public List<AvailableProducts> AvailableProductsData()
        {
            List<AvailableProducts> avlpdlist = new List<AvailableProducts>();

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string selectdata = "Select * From Products Where ProductStatus = @status AND DateDelete is NULL";

                    using (SqlCommand selectcmd = new SqlCommand(selectdata, con))
                    {
                        selectcmd.Parameters.AddWithValue("@status", "Available");
                        SqlDataReader sdr = selectcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            AvailableProducts prods = new AvailableProducts();

                            prods.Id = (int)sdr["Id"];
                            prods.ProductId = sdr["ProductId"].ToString();
                            prods.ProductName = sdr["ProductName"].ToString();
                            prods.ProductType = sdr["ProductType"].ToString();
                            prods.ProductStock = (int)sdr["ProductStock"];
                            prods.ProductPrice = Convert.ToSingle(sdr["ProductPrice"]);
                            prods.ProductStatus = sdr["ProductStatus"].ToString();

                            avlpdlist.Add(prods);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "Error Message");
                }
                finally { con.Close(); }
            }

            return avlpdlist;
        }
    }
}
