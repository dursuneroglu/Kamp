using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori ekleme
            //Console.Write("Eklemek istediğiniz katagori adı: ");
            //string categoryName=Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LGMB6VN\\EDWARD;initial Catalog=DbEgitimKampi;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine( "Başarılı");
            #endregion

            #region Ürüne ekleme
            //string ProductName;
            //decimal ProductPrice;

            //Console.Write("Ürün Adı: ");
            //ProductName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //ProductPrice =decimal.Parse(Console.ReadLine());
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LGMB6VN\\EDWARD; initial Catalog=DbEgitimKampi; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@ProductName, @ProductPrice, @ProductStatus)",conn);
            //cmd.Parameters.AddWithValue("@ProductName",ProductName);
            //cmd.Parameters.AddWithValue("@ProductPrice",ProductPrice);
            //cmd.Parameters.AddWithValue("@ProductStatus", true);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine( "Ürün Eklemesi Başarılı");
            #endregion

            #region Ürün listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LGMB6VN\\EDWARD;initial Catalog=DbEgitimKampi;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün silme

            //Console.Write("Silenecek Ürün Id: ");
            //int UrunId=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LGMB6VN\\EDWARD;initial Catalog=DbEgitimKampi;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", UrunId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("silme işlemi başarılı");
            #endregion

            #region Güncelleme
           
            //Console.Write("Güncellenecek Ürün Id:");
            //int ProductId=int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı:");
            //string ProductName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı:");
            //decimal ProductPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LGMB6VN\\EDWARD;initial Catalog=DbEgitimKampi;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName",ProductName);
            //command.Parameters.AddWithValue("@productPrice",ProductPrice);
            //command.Parameters.AddWithValue("@productId",ProductId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Güncellendi");
            #endregion

            Console.Read();
        }
    }
}
