using System.Collections.Generic;
using MySqlConnector;

namespace HotelSys.Models
{
    public class QuartoRepo : Repository
    {
        public List<Quarto> Listar()
        {
            conexao.Open();

            string sql = "SELECT * FROM Quartos ORDER BY Numero";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Quarto> lista = new List<Quarto>();
            while (reader.Read())
            {
                Quarto quarto = new Quarto();
                quarto.idQuarto = reader.GetInt32("idQuarto");
                quarto.Numero = reader.GetInt32("Numero");
                quarto.Status = reader.GetString("Status");
                quarto.Descricao = reader.GetString("Descricao");
                ClienteRepo cr = new ClienteRepo();
                if (!reader.IsDBNull(reader.GetOrdinal("idCliente")))
                    quarto.cliente = cr.BuscarPorId(reader.GetInt32("idCliente"));
                else
                    quarto.cliente = null;
                if (!reader.IsDBNull(reader.GetOrdinal("CheckIn")))
                    quarto.CheckIn = reader.GetDateTime("CheckIn");
                else
                    quarto.CheckIn = null;
                if (!reader.IsDBNull(reader.GetOrdinal("CheckOut")))
                    quarto.CheckOut = reader.GetDateTime("CheckOut");
                else
                    quarto.CheckOut = null;

                lista.Add(quarto);
            }

            conexao.Close();

            return lista;
        }

        public Quarto BuscarPorId(int id)
        {
            conexao.Open();

            string sql = "SELECT * FROM Quartos WHERE idQuarto = @id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();

            Quarto quarto = null;
            if (reader.Read())
            {
                quarto = new Quarto();
                quarto.idQuarto = reader.GetInt32("idQuarto");
                quarto.Numero = reader.GetInt32("Numero");
                quarto.Status = reader.GetString("Status");
                quarto.Descricao = reader.GetString("Descricao");
                ClienteRepo cr = new ClienteRepo();
                if (!reader.IsDBNull(reader.GetOrdinal("idCliente")))
                    quarto.cliente = cr.BuscarPorId(reader.GetInt32("idCliente"));
                else
                    quarto.cliente = null;
                if (!reader.IsDBNull(reader.GetOrdinal("CheckIn")))
                    quarto.CheckIn = reader.GetDateTime("CheckIn");
                else
                    quarto.CheckIn = null;
                if (!reader.IsDBNull(reader.GetOrdinal("CheckOut")))
                    quarto.CheckOut = reader.GetDateTime("CheckOut");
                else
                    quarto.CheckOut = null;
            }

            conexao.Close();

            return quarto;
        }

        public void Editar(Quarto quarto)
        {
            conexao.Open();

            string sql = "SET foreign_key_checks = 0; " +
            "UPDATE Quartos SET Status = @Status, idCliente = @idCliente, CheckIn = @CheckIn, CheckOut = @CheckOut WHERE idQuarto = @idQuarto; " +
            "SET foreign_key_checks = 1;";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Status", quarto.Status);
            comando.Parameters.AddWithValue("idCliente", quarto.cliente.idCliente);
            comando.Parameters.AddWithValue("CheckIn", quarto.CheckIn);
            comando.Parameters.AddWithValue("CheckOut", quarto.CheckOut);
            comando.Parameters.AddWithValue("idQuarto", quarto.idQuarto);

            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}