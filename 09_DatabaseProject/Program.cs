using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tabloNumber;
            Console.WriteLine("1 Katagoriler");
            Console.WriteLine("2 Ürünler");
            Console.WriteLine("3 Siparişler");
            Console.WriteLine("4 Çıkış Yap");
            Console.Write("Getirmek istediğiniz tablo numarasını giriniz: ");
            tabloNumber = Console.ReadLine();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LGMB6VN\\EDWARD;initial Catalog=DbEgitimKampi;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);  
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            connection.Close();
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();


        }
    }
}
