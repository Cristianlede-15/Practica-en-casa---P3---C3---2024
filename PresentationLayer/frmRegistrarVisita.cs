using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using Bunifu.Framework.UI;
using SharedEntities;


namespace PresentationLayer
{
    public partial class frmRegistrarVisita : Form
    {
        private readonly VisitaService _visitaService;

        public frmRegistrarVisita()
        {
            InitializeComponent();
            _visitaService = new VisitaService();
            CargarEdificios();
        }

        private void CargarEdificios()
        {
            var edificios = _visitaService.ObtenerEdificios();
            cmbEdificio.DataSource = edificios;
            cmbEdificio.DisplayMember = "Nombre";
            cmbEdificio.ValueMember = "Id";
        }

        private void cmbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var edificioId = cmbEdificio.Text;
                var aulas = _visitaService.ObtenerAulasPorEdificio(edificioId);
                this.aulas.DataSource = aulas;
                this.aulas.DisplayMember = "Nombre";
                this.aulas.ValueMember = "Id";

            }
            catch (Exception ex)
            {
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var visita = new Visita
            {
                Nombre = txtNombre.text,
                Apellido = txtApellido.text,
                Carrera = txtCarrera.text,
                Correo = txtCorreo.text,
                EdificioId = (int)cmbEdificio.SelectedValue,
                AulaId = (int)aulas.SelectedValue,
                HoraEntrada = dtpHoraEntrada.Value,
                HoraSalida = dtpHoraSalida.Value,
                Motivo = txtMotivoVisita.text
            };

            var resultado = _visitaService.RegistrarVisita(visita);
            if (resultado)
            {
                MessageBox.Show("Visita registrada exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar la visita");
            }
        }

        private void cmbEdificio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_OnTextChange(object sender, EventArgs e)
        {

        }

        private void cmbAulaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
