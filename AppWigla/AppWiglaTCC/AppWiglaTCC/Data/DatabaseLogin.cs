using MySql.Data.MySqlClient;
using AppWiglaTCC.Models;
using System.Collections.Generic;

namespace AppWiglaTCC.Data
{
    public class UsuarioDatabase
    {
        private string connectionString = "server=localhost;database=wigla_db;user=root;password=;";

        // Inserir usuário (cadastro)
        public bool InserirUsuario(Usuario usuario)
        {
            using var conexao = new MySqlConnection(connectionString);
            conexao.Open();

            // Verifica se email já existe
            var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios WHERE email=@Email", conexao);
            checkCmd.Parameters.AddWithValue("@Email", usuario.Email);
            var count = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (count > 0) return false; // email já cadastrado

            // Insere usuário
            var comando = new MySqlCommand(
                "INSERT INTO usuarios (nome, email, senha) VALUES (@Nome, @Email, @Senha)",
                conexao);

            comando.Parameters.AddWithValue("@Nome", usuario.Nome);
            comando.Parameters.AddWithValue("@Email", usuario.Email);
            comando.Parameters.AddWithValue("@Senha", usuario.Senha);

            comando.ExecuteNonQuery();
            return true;
        }

        // Validar login
        public bool ValidarLogin(string email, string senha)
        {
            using var conexao = new MySqlConnection(connectionString);
            conexao.Open();

            var cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM usuarios WHERE email=@Email AND senha=@Senha",
                conexao);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Senha", senha);

            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        // Obter usuário pelo email (opcional)
        public Usuario ObterUsuarioPorEmail(string email)
        {
            using var conexao = new MySqlConnection(connectionString);
            conexao.Open();

            var cmd = new MySqlCommand(
                "SELECT * FROM usuarios WHERE email=@Email",
                conexao);
            cmd.Parameters.AddWithValue("@Email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Usuario
                {
                    Id = reader.GetInt32("id"),
                    Nome = reader.GetString("nome"),
                    Email = reader.GetString("email"),
                    Senha = reader.GetString("senha")
                };
            }

            return null;
        }
    }
}
