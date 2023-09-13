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
    public class InboxRepository : IInboxRepository
    {
        public List<InBox> GetListAll()
        {
            List<InBox> messages = new List<InBox>();

            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "SELECT  * FROM InBoxes";

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var ınBox = new InBox();

                ınBox.Id = Convert.ToInt32(reader[0]);
                ınBox.Description = Convert.ToString(reader[1]);

                messages.Add(ınBox);

            }

            reader.Close();
            connection.Close();


            return messages;
        }


        public void AddMessage(string message)
        {
            var connection = new DbConnectionHelper().Connection;

            SQLiteCommand command = new SQLiteCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "INSERT INTO InBoxes (Description) VALUES (@Message)";

            command.Parameters.AddWithValue("@Message", message);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
    }
}
