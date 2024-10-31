using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmConsultaVisitas : Form
    {
        private readonly VisitaService _visitaService;

        public frmConsultaVisitas()
        {
            InitializeComponent();
            _visitaService = new VisitaService();
            CargarEdificios();
        }


        private void CargarEdificios()
        {
            cmbEdificio.DataSource = _visitaService.ObtenerEdificios();
            cmbEdificio.DisplayMember = "Nombre"; 
            cmbEdificio.ValueMember = "Id";  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int edificioId = (int)cmbEdificio.SelectedValue;
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            DataTable visitas = _visitaService.ObtenerVisitas(edificioId, fechaInicio, fechaFin);
            dgvVisitas.DataSource = visitas;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmConsultaVisitas_Load(object sender, EventArgs e)
        {

        }
    }

   
   

}
