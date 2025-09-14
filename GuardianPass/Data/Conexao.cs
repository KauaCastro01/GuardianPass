using GuardianPass.Controller;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Reflection.PortableExecutable;

namespace GuardianPass.Data
{
    public class Conexao
    {
        public SqliteDataReader dr;

        public string GetDatabasePath()
        {
#if DEBUG
            string dbPath = Path.Combine("C:\Projetos\GuardianPass\GuardianPass\Data", "gdb.db");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
#else
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(folder, "GuardianPass", "Data");
            Directory.CreateDirectory(appFolder);

            string dbPath = Path.Combine(appFolder, "gdb.db");

            if (!File.Exists(dbPath))
            {
                string origem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "gdb.db");
                if (File.Exists(origem))
                    File.Copy(origem, dbPath);
            }
#endif

            return dbPath;
        }

        public SqliteConnection GetConnection()
        {
            Batteries.Init();
            string con = $"Data Source={GetDatabasePath()};";
            return new SqliteConnection(con);
        }


        public bool Login(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM GP_Usuarios WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool PegarExigirSenha(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT ExigirSenha FROM GP_Usuarios WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    using (var dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            bool Exigir = Convert.ToBoolean(dr["ExigirSenha"]);
                            return Exigir;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }

        public int PegarId(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT Id FROM GP_Usuarios WHERE Usuario = @usuario AND Senha = @senha;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    using (var dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int Id = Convert.ToInt32(dr["Id"]);
                            return Id;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }


        public bool Cadastro(string usuario, string senha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    if (Login(usuario, senha))
                    {
                        MessageBox.Show("Usuário já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        command.Parameters.Clear();
                        command.CommandText = "INSERT INTO GP_Usuarios (Usuario, Senha, ExigirSenha) VALUES (@usuario, @senha, true);";
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@senha", senha);
                        int linhasAfetadas = command.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }

        public void AtualizarExigir(DadosUsuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE GP_Usuarios SET ExigirSenha = @exigir WHERE Usuario = @usuario;";
                    command.Parameters.AddWithValue("@usuario", user.Usuario);
                    command.Parameters.AddWithValue("@exigir", user.Exigir);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool AtualizarSenha(string senhaNova, DadosUsuario user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE GP_Usuarios SET Senha = @senhaNova WHERE Usuario = @usuario;";
                    command.Parameters.AddWithValue("@usuario", user.Usuario);
                    command.Parameters.AddWithValue("@senhaNova", senhaNova);
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
