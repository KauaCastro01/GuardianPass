using GuardianPass.Data;


namespace GuardianPass
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            string dbPath = Conexao.GetDatabasePath();
            var db = new AppDbContext(dbPath);

            Application.Run(new Form1(db));
        }
    }
}