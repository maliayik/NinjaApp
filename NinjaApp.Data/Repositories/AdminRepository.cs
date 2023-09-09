using NinjaApp.Data.Helpers;
using NinjaApp.Data.Interfaces;
using NinjaApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp.Data.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public Admin GetAdminLogin(string userName, string password)
        {
            using (var connection = new DbConnectionHelper().Connection)
            {
                connection.Open();

                using (var command = new SQLiteCommand("SELECT * FROM Admins WHERE UserName=@username AND Password=@password", connection))
                {
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var admin = new Admin
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Username = reader["UserName"].ToString(),
                                Password = reader["Password"].ToString(),
                                Fullname = reader["Fullname"].ToString(),
                            };

                            return admin;
                            
                        }
                        command.Parameters.Clear();
                    }
                }
                
                connection.Close();
            }
            return null;
        }
    }
}
