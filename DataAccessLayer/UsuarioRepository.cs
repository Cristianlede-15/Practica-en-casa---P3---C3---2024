using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class UsuarioRepository
    {
        private readonly string connectionString;

        public UsuarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_Login", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }

        public void CrearUsuario(string nombre, string apellido, DateTime fechaNacimiento, string tipoUsuario, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_CrearUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        


        public void EliminarUsuario(int usuarioId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_EliminarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool AutenticarUsuario(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_VerificarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

            

                connection.Open();

                Console.WriteLine("Connection opened successfully.");
                Console.WriteLine("Executing stored procedure with parameters: Username = " + username + ", Password = " + password);

               int result = Convert.ToInt32( command.ExecuteScalar());
                bool isLogin = result ==1 ? true :false;
                connection.Close();

                return isLogin;
            }
        }

        public bool EsAdministrador(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_ObtenerTipoUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);


                connection.Open();
                var usernameResult = command.ExecuteScalar().ToString();
                connection.Close();
                return usernameResult == "Administrador";
            }
        }

    }
}
