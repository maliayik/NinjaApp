using System.Data.SQLite;

namespace NinjaApp.Data.Helpers
{
    public class DbConnectionHelper
    {
        private string GetDatabasePath()
        {
            string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string databasePath = Path.Combine(baseFolder, "C:","Users","efe38","source","repos", "NinjaApp", "NinjaApp.Data", "Db", "NinjaDb.db");
            return databasePath;
        }

        public SQLiteConnection Connection => new SQLiteConnection($"Data Source={GetDatabasePath()}");

    }
}
