using MySqlConnector;

namespace HotelSys.Models
{
    public class UsuarioRepo : Repository
    {
        public Usuario ValidarLogin(Usuario usuario)
        {
            conexao.Open();

            string sql = "SELECT * FROM Usuarios WHERE Login = @Login AND Senha = @Senha";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@Senha", usuario.Senha);
            MySqlDataReader reader = comando.ExecuteReader();

            Usuario user = null;
            if (reader.Read())
            {
                user = new Usuario();
                user.idUsuario = reader.GetInt32("idUsuario");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    user.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                    user.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    user.Senha = reader.GetString("Senha");
            }

            conexao.Close();

            return user;
        }
    }
}