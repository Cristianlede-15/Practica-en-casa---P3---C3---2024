using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using SharedEntities;
using System.Configuration;


namespace DataAccessLayer
{
    public class VisitaRepository
    {
        private readonly string connectionString;

        public VisitaRepository()
        {
             connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public bool RegistrarVisita(Visita visita)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_RegistrarVisita", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", visita.Nombre);
                command.Parameters.AddWithValue("@Apellido", visita.Apellido);
                command.Parameters.AddWithValue("@Carrera", visita.Carrera);
                command.Parameters.AddWithValue("@Correo", visita.Correo);
                command.Parameters.AddWithValue("@Edificioid", visita.EdificioId); 
                command.Parameters.AddWithValue("@HoraEntrada", visita.HoraEntrada);
                command.Parameters.AddWithValue("@HoraSalida", visita.HoraSalida);
                command.Parameters.AddWithValue("@MotivoVisita", visita.Motivo);
                command.Parameters.AddWithValue("@Aulaid", visita.AulaId); 
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowsAffected > 0;
            }
        }

        public DataTable ObtenerEdificios()
        {

            var connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_ObtenerEdificios", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;

        }

        public DataTable ObtenerAulasPorEdificio(string edificio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerAulasPorEdificio", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Edificio", edificio);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable ObtenerVisitas(int edificioId, DateTime fechaInicio, DateTime fechaFin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerVisitas", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@edificioId", edificioId);
                cmd.Parameters.AddWithValue("@horaEntrada", fechaInicio);
                cmd.Parameters.AddWithValue("@horaSalida", fechaFin);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

    }
}
