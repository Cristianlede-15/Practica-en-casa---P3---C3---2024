using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedEntities
{
    public class Visita
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public string Correo { get; set; }
        public int EdificioId { get; set; } 
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public string Motivo { get; set; }
        public int AulaId { get; set; } 

    }

}
