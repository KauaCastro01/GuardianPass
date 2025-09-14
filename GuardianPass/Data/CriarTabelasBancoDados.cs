using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianPass.Data
{
    internal class CriarTabelasBancoDados : Conexao
    {
        public void CriarTabelaUsuarios()
        {
            string dbPath = GetDatabasePath();
            using (var conn = new SqliteConnection($"Data Source={dbPath}"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
        CREATE TABLE IF NOT EXISTS GP_Usuarios (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Usuario TEXT NOT NULL,
            Senha TEXT NOT NULL,
            ExigirSenha INTEGER NOT NULL DEFAULT 0
        );
    ";
                cmd.ExecuteNonQuery();
            }
        }

        public void CriarTabelaApps()
        {
            string dbPath = GetDatabasePath();
            using (var conn = new SqliteConnection($"Data Source={dbPath}"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
        CREATE TABLE IF NOT EXISTS GP_Apps (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            UsuarioId INTEGER NOT NULL,
            Usuario TEXT NOT NULL,
            Senha TEXT NOT NULL,
            Site TEXT,
            FOREIGN KEY (UsuarioId) REFERENCES GP_Usuarios(Id) ON DELETE CASCADE
        );
    ";
                cmd.ExecuteNonQuery();
            }
        }


    }
}
