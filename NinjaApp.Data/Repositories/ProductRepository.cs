using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System.Data;
using System.Data.SQLite;

namespace NinjaApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "SELECT  * FROM Products";

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(reader[0]);
                product.ProductName = Convert.ToString(reader[1]);
                product.CategoryName = Convert.ToString(reader[2]);
                product.Unit = Convert.ToString(reader[3]);
                product.Price = Convert.ToDecimal(reader[4]);
                product.Stock = Convert.ToInt32(reader[5]);
                product.CategoryId = Convert.ToInt32(reader[6]);
                product.SuplierId = Convert.ToInt32(reader[7]);

                products.Add(product);

            }

            reader.Close();
            connection.Close();


            return products;
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            List<Product> products = new List<Product>();

            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Products WHERE CategoryName = @CategoryName";
            command.Parameters.AddWithValue("@CategoryName", categoryName);

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(reader[0]);
                product.ProductName = Convert.ToString(reader[1]);
                product.CategoryName = Convert.ToString(reader[2]);
                product.Unit = Convert.ToString(reader[3]);
                product.Price = Convert.ToDecimal(reader[4]);
                product.Stock = Convert.ToInt32(reader[5]);
                product.CategoryId = Convert.ToInt32(reader[6]);
                product.SuplierId = Convert.ToInt32(reader[7]);

                products.Add(product);
            }

            reader.Close();
            command.Parameters.Clear();
            connection.Close();

            return products;
        }

        public void UpdateProductStock(string productName, int newStock)
        {
            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "UPDATE Products SET Stock = Stock + @NewStock WHERE ProductName = @ProductName";

            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@NewStock", newStock);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }

        public void UpdateProductPrice(int productId, decimal newPrice)
        {
            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "UPDATE Products SET Price = @Price WHERE Id = @Id";

            command.Parameters.AddWithValue("@Id", productId);
            command.Parameters.AddWithValue("@Price", newPrice);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }



    }

}


