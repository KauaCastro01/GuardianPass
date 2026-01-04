using Microsoft.Data.Sqlite;

namespace GuardianPass.Data
{
    public class Conexao
    {
        public SqliteDataReader dr;

        public static string GetDatabasePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dataFolder = Path.Combine(basePath, "Data");
            Directory.CreateDirectory(dataFolder);

            string dbPath = Path.Combine(dataFolder, "GuardianPass.db");

            string origem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "GuardianPass.db");

            if (!File.Exists(dbPath) && File.Exists(origem))
                File.Copy(origem, dbPath);

            return dbPath;
        }

    }
}
