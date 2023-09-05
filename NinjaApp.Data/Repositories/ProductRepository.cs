﻿using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

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
                product.ShopId = Convert.ToInt32(reader[6]);
                product.CategoryId = Convert.ToInt32(reader[7]);
                product.SuplierId = Convert.ToInt32(reader[8]);

                products.Add(product);

            }

            reader.Close();
            connection.Close();


            return products;
        }

       

        public void UpdateProduct(int productId, decimal newPrice)
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
            connection.Close();
        }

      
    }
}
