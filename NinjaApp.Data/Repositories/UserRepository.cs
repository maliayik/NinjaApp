﻿using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System.Data;
using System.Data.SQLite;

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
                                ReceiptId = Convert.ToInt32(reader["ReceiptId"])
                            };

                            return user;
                        }
                        command.Parameters.Clear();
                    }

                }
                connection.Close();
            }
            return null;
        }

        public AppUser GetUserLogin(string userName, string password)
        {

            using (var connection = new DbConnectionHelper().Connection)
            {
                connection.Open();

                using (var command = new SQLiteCommand("SELECT * FROM Users WHERE UserName=@username AND Password=@password", connection))
                {
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var user = new AppUser
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Fullname = reader["Fullname"].ToString(),
                                Username = reader["UserName"].ToString(),
                                Password = reader["Password"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"]),

                            };

                            return user;
                           
                        }
                    }command.Parameters.Clear();
                }
                connection.Close();
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