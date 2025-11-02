using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CafeShopMS
{
    internal class ProductsData
    {
        public ProductsData() { }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ProductStock { get; set; }
        public float ProductPrice { get; set; }
        public string ProductStatus { get; set; }
        public string ProductImage { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }
        public string DateDelete { get; set; }

        public List<ProductsData> ListProductsData()
        {
            List<ProductsData> pdlist = new List<ProductsData>();

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string selectdata = "Select * From Products Where DateDelete is NULL";

                    using (SqlCommand selectcmd = new SqlCommand(selectdata, con)) 
                    { 
                        SqlDataReader sdr = selectcmd.ExecuteReader();
                        while (sdr.Read()) 
                        { 
                            ProductsData prods = new ProductsData();

                            prods.Id = (int)sdr["Id"];
                            prods.ProductId = sdr["ProductId"].ToString();
                            prods.ProductName = sdr["ProductName"].ToString();
                            prods.ProductType = sdr["ProductType"].ToString();
                            prods.ProductStock = (int)sdr["ProductStock"];
                            prods.ProductPrice = Convert.ToSingle(sdr["ProductPrice"]);
                            prods.ProductStatus = sdr["ProductStatus"].ToString();
                            prods.ProductImage = sdr["ProductImage"].ToString();
                            prods.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy");
                            prods.DateUpdate = sdr["DateUpdate"].ToString();

                            if (sdr["DateUpdate"] != DBNull.Value)
                            {
                                prods.DateUpdate = (Convert.ToDateTime(sdr["DateUpdate"])).ToString("dd-MM-yyyy");
                            }
                            prods.DateDelete = sdr["DateDelete"].ToString();

                            pdlist.Add(prods);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "Error Message");
                }
                finally { con.Close(); }
            }

            return pdlist;
        }

        
    }
}
