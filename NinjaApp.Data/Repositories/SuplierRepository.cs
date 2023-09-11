using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Data.Repositories
{
    public class SuplierRepository : ISuplierRepository
    {
        public List<Supliers> GetSupliersByCategory(string categoryName)
        {
            List<Supliers> supliers = new List<Supliers>();

            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Supliers WHERE CategoryName = @CategoryName";
            command.Parameters.AddWithValue("@CategoryName", categoryName);

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var suplier = new Supliers();

                suplier.Id = Convert.ToInt32(reader[0]);
                suplier.ProductName = Convert.ToString(reader[1]);
                suplier.CategoryName = Convert.ToString(reader[2]);
                suplier.Unit = Convert.ToString(reader[3]);
                suplier.Stock = Convert.ToInt32(reader[4]);
                suplier.Price = Convert.ToDecimal(reader[5]);
                suplier.CategoryId = Convert.ToInt32(reader[6]);

                supliers.Add(suplier);
            }

            reader.Close();
            command.Parameters.Clear();
            connection.Close();

            return supliers;
        }
    }
}

