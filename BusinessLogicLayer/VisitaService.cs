using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using SharedEntities;




namespace BusinessLogicLayer
{
    public class VisitaService
    {
        private readonly VisitaRepository _visitaRepository;

        public VisitaService()
        {
            _visitaRepository = new VisitaRepository();
        }

        public DataTable ObtenerEdificios()
        {
            return _visitaRepository.ObtenerEdificios();
        }

        public DataTable ObtenerAulasPorEdificio(string edificio)
        {
            return _visitaRepository.ObtenerAulasPorEdificio(edificio);
        }

        public DataTable ObtenerVisitas(int edificioId, DateTime fechaInicio, DateTime fechaFin)
        {
            return _visitaRepository.ObtenerVisitas(edificioId, fechaInicio, fechaFin);
        }

        public bool RegistrarVisita(Visita visita)
        {
            return _visitaRepository.RegistrarVisita(visita);
        }

    }
}
