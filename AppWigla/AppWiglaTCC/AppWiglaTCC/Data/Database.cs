using MySql.Data.MySqlClient;
using AppWiglaTCC.Models;
using System.Collections.Generic;

namespace AppWiglaTCC.Data
{
    public class SiglaDatabase
    {
        private string connectionString = "server=localhost;database=wigla_db;user=root;password=;";

        public List<Sigla> BuscarSiglas(string termo)
        {
            var lista = new List<Sigla>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new MySqlCommand("SELECT * FROM siglas WHERE sigla LIKE @termo ORDER BY sigla ASC", connection);
                cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Sigla
                    {
                        Id = reader.GetInt32("id"),
                        Abreviacao = reader.GetString("sigla"),
                        Significado = reader.GetString("significado"),
                        Descricao = reader.GetString("descricao"),
                        Categoria = reader.GetString("categoria")
                    });
                }
            }
            return lista;
        }

        public void InserirSigla(Sigla sigla)
        {
            using var conexao = new MySqlConnection(connectionString);
            conexao.Open();

            var comando = new MySqlCommand(
                "INSERT INTO siglas (sigla, significado, descricao, categoria) VALUES (@sigla, @significado, @descricao, @categoria)",
                conexao);

            comando.Parameters.AddWithValue("@sigla", sigla.Abreviacao);
            comando.Parameters.AddWithValue("@significado", sigla.Significado);
            comando.Parameters.AddWithValue("@descricao", sigla.Descricao);
            comando.Parameters.AddWithValue("@categoria", sigla.Categoria);

            comando.ExecuteNonQuery();
        }
    }
}
