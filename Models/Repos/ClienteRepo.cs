using System.Collections.Generic;
using MySqlConnector;

namespace HotelSys.Models
{
    public class ClienteRepo : Repository
    {
        public List<Cliente> Listar()
        {
            conexao.Open();

            string sql = "SELECT * FROM Clientes";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Cliente> lista = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = reader.GetInt32("idCliente");
                cliente.Nome = reader.GetString("Nome");
                cliente.CPF = reader.GetString("CPF");

                lista.Add(cliente);
            }

            conexao.Close();

            return lista;
        }

        public Cliente BuscarPorId(int id)
        {
            conexao.Open();

            string sql = "SELECT * FROM Clientes WHERE idCliente = @id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();

            Cliente cliente = null;
            if (reader.Read())
            {
                cliente = new Cliente();
                cliente.idCliente = reader.GetInt32("idCliente");
                cliente.Nome = reader.GetString("Nome");
                cliente.CPF = reader.GetString("CPF");
            }

            conexao.Close();

            return cliente;
        }

        public void Insert(Cliente cliente)
        {
            conexao.Open();

            string sql = "INSERT INTO Clientes(Nome, CPF) VALUES(@Nome, @CPF)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.CPF);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}