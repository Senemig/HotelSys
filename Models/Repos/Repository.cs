using MySqlConnector;

namespace HotelSys.Models
{
    public abstract class Repository
    {
        private const string _strConexao = "DATABASE = HotelSys; DATA SOURCE = localhost; USER ID = root;";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}