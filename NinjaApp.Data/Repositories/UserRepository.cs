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
    public class UserRepository : IUserRepository
    {

        public AppUser GetAppUserById(int id)
        {
            using (var connection = new DbConnectionHelper().Connection)
            {
                connection.Open();

                using (var command = new SQLiteCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE Id = @Id";


                    command.Parameters.Add(new SQLiteParameter("@Id", id));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var user = new AppUser
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Fullname = reader["Fullname"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"]),
                                ShopId = Convert.ToInt32(reader["ShopId"]),
                                ReceiptId = Convert.ToInt32(reader["ReceiptId"])
                            };

                            return user;
                        }
                    }

                }
            }
            return null;
        }





        public void UpdateUserBalance(int userId, decimal balance)
        {

            using (var connection = new DbConnectionHelper().Connection)

            {
                connection.Open();

                using (var command = new SQLiteCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users SET Balance = @NewBalance WHERE Id = @UserId";

                    command.Parameters.Add(new SQLiteParameter("@NewBalance", balance));
                    command.Parameters.Add(new SQLiteParameter("@UserId", userId));

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();
                }



            }
        }

        public void UpdateUserPassword(int userId, string password)
        {
            using (var connection = new DbConnectionHelper().Connection)

            {
                connection.Open();

                using (var command = new SQLiteCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users SET Password = @NewPassword WHERE Id = @UserId";

                    command.Parameters.Add(new SQLiteParameter("@NewPassword", password));
                    command.Parameters.Add(new SQLiteParameter("@UserId", userId));

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }
    }
}