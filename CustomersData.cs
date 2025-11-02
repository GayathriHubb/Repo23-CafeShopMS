using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace CafeShopMS
{
    internal class CustomersData
    {
        public CustomersData() { }

        readonly SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\CafeShopMS\CafeShop.mdf;Integrated Security = True");

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public float TotalPrice { get; set; }
        public float TenderedCash { get; set; }
        public float TenderedChange { get; set; }
        public string OrderDate { get; set; }   

        public List<CustomersData> ListCustomersData()
        {
            List<CustomersData> custs = new List<CustomersData>();

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string seldata = "Select * From Customers";

                    using (SqlCommand selcmd = new SqlCommand(seldata, con))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        {
                            while (sdr.Read())
                            {
                                CustomersData cd = new CustomersData();

                                cd.Id = (int)sdr["Id"];
                                cd.CustomerId = (int)sdr["CustomerId"];
                                cd.TotalPrice = Convert.ToSingle(sdr["TotalPrice"]);
                                cd.TenderedCash = Convert.ToSingle(sdr["Amount"]);
                                cd.TenderedChange = Convert.ToSingle(sdr["Change"]);
                                cd.OrderDate = (Convert.ToDateTime(sdr["OrderDate"])).ToString("dd-MM-yyyy");

                                custs.Add(cd);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustomersData");
                }
                finally { con.Close(); }
            }
            return custs;

        }
    }
}
