using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SharedEntities;
using System.Configuration;

namespace DataAccessLayer
{
    public class ConfiguracionRepository
    {

        private readonly string connectionString;

        public ConfiguracionRepository()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<Edificio> ObtenerEdificios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_ObtenerEdificios", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Edificio> edificios = new List<Edificio>();
                while (reader.Read())
                {
                    edificios.Add(new Edificio
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    });
                }
                connection.Close();
                return edificios;
            }
        }

        public List<Aula> ObtenerAulas(int edificioId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_ObtenerAulasPorEdificio", connection);
                command.Parameters.AddWithValue("@EdificioId", edificioId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Aula> aulas = new List<Aula>();
                while (reader.Read())
                {
                    aulas.Add(new Aula
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        EdificioId = edificioId
                    });
                }
                return aulas;
            }
        }

        public bool GuardarVisita(Visita visita)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_RegistrarVisita", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", visita.Nombre);
                command.Parameters.AddWithValue("@Apellido", visita.Apellido);
                command.Parameters.AddWithValue("@Carrera", visita.Carrera);
                command.Parameters.AddWithValue("@Correo", visita.Correo);
                command.Parameters.AddWithValue("@Edificio", visita.EdificioId);
                command.Parameters.AddWithValue("@HoraEntrada", visita.HoraEntrada);
                command.Parameters.AddWithValue("@HoraSalida", visita.HoraSalida);
                command.Parameters.AddWithValue("@MotivoVisita", visita.Motivo);
                command.Parameters.AddWithValue("@AulaDestino", visita.AulaId);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }
    }


}

