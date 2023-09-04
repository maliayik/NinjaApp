using Microsoft.Data.Sqlite;
using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System.Data;
using System.Data.SQLite;

namespace NinjaApp.Data.Repositories
{
    public class TestRepository:ITestRepository
    {
        public List<Test> GetProducts()
        {            

            List<Test> products = new List<Test>();

            var connection = new DbConnectionHelper().Connection;
            
                SQLiteCommand command = new SQLiteCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "SELECT  * FROM Products";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var product = new Test();

                    product.Id = Convert.ToInt32(reader[0]);
                    product.ProductName = Convert.ToString(reader[1]);

                    products.Add(product);

                }

                reader.Close();
                connection.Close();

                       


            return products;

        }

        
    }
}
