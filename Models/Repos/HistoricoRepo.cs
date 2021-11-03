using System;
using System.Collections.Generic;
using MySqlConnector;

namespace HotelSys.Models
{
    public class HistoricoRepo : Repository
    {
        public List<Historico> Listar()
        {
            conexao.Open();

            string sql = "SELECT * FROM Historico";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Historico> lista = new List<Historico>();
            while (reader.Read())
            {
                Historico historico = new Historico();
                historico.idHistorico = reader.GetInt32("idHistorico");
                historico.idCliente = reader.GetInt32("idCliente");
                historico.Quarto = reader.GetInt32("Quarto");
                historico.Tipo = reader.GetString("Tipo");
                historico.Registro = reader.GetDateTime("DataRegistro");

                lista.Add(historico);
            }

            conexao.Close();

            return lista;
        }

        public void Insert(Historico historico)
        {
            conexao.Open();

            string sql = "SET foreign_key_checks = 0; " +
            "INSERT INTO Historico(Quarto, Tipo, idCliente, DataRegistro) VALUES(@Quarto, @Tipo, @idCliente, @DataRegistro);";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Quarto", historico.Quarto);
            comando.Parameters.AddWithValue("@Tipo", historico.Tipo);
            comando.Parameters.AddWithValue("@idCliente", historico.idCliente);
            comando.Parameters.AddWithValue("@DataRegistro", historico.Registro);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}