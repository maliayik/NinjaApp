using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System.Data;
using System.Data.SQLite;

namespace NinjaApp.Data.Repositories
{
    public class ReceiptRepository : IReceiptRepository
    {
        public List<Receipt> GetTopSellingReceipts(int count)
        {
            List<Receipt> products = new List<Receipt>();

            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.CommandText = "SELECT ProductName, COUNT(*) AS SaleCount FROM Receipts GROUP BY ProductName ORDER BY SaleCount DESC LIMIT @Count;";
            command.Parameters.AddWithValue("@Count", count);

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var productName = reader["ProductName"].ToString();
                var saleCount = Convert.ToInt32(reader["SaleCount"]);

                var receipt = new Receipt
                {
                    ProductName = productName,
                    SaleCount = saleCount
                };

                products.Add(receipt);
            }
            command.Parameters.Clear();
            connection.Close();
            return products;
        }
    }
}

