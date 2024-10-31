using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmConfiguracion : Form
    {
        private readonly ConfiguracionService _configuracionService;
        int Idedificio;
        public frmConfiguracion()
        {
            InitializeComponent();
            _configuracionService = new ConfiguracionService();
            CargarEdificios();
            CargarUsuarios();
        }

        private void CargarEdificios()
        {
            lstEdificios.DataSource = _configuracionService.ObtenerEdificios();
            lstEdificios.DisplayMember = "Nombre";
            lstEdificios.ValueMember = "Id";

        }

        private void CargarAulas(string edificio)
        {
            lstAulas.DataSource = _configuracionService.ObtenerAulas(edificio);
            lstAulas.DisplayMember = "Numero";
            lstAulas.ValueMember = "Id";
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = _configuracionService.ObtenerUsuarios();
        }


        private void btnGuardarEdificio_Click(object sender, EventArgs e)
        {
            string nombreEdificio = txtNombreEdificio.text;

            _configuracionService.GuardarEdificio(nombreEdificio);
            CargarEdificios();
        }

        private void btnGuardarAula_Click(object sender, EventArgs e)
        {


            _configuracionService.GuardarAula(Idedificio, txtNumeroAula.text);
            MessageBox.Show("Aula guardada", "EXITOSO:",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lstEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string edificio = lstEdificios.SelectedItem.ToString();
            CargarAulas(edificio);
        }

        public void CargarTiposDeUsuario()
        {
            var tiposDeUsuario = new List<string> { "Administrador", "General" };

            cmbTipoUsuario.DataSource = tiposDeUsuario;
        }
        private void GuardarUsuarios()
        {

            string nombre = txtNombreUsuario.text;
            string apellido = txtApellidoUsuario.text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();
            string usuario = txtUsuario.text;
            string password = txtPassword.text;
            _configuracionService.GuardarUsuario(nombre, apellido, fechaNacimiento, tipoUsuario, usuario, password);
            CargarUsuarios();
        }
        private void lstEdificios_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = lstEdificios.SelectedItem as DataRowView;
            string edificio = selectedRow["Nombre"].ToString();
            Idedificio = (int)selectedRow["Id"];
            CargarAulas(edificio);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            GuardarUsuarios();
        }
    }
}
