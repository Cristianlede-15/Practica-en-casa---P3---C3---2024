using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void RegistrarVisita_Click(object sender, EventArgs e)
        {
            frmRegistrarVisita registrarVisitaForm = new frmRegistrarVisita();
            registrarVisitaForm.Show();
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracionForm = new frmConfiguracion();
            configuracionForm.Show();
        }

        private void ConsultaVisitas_Click(object sender, EventArgs e)
        {
            frmConsultaVisitas consultaVisitasForm = new frmConsultaVisitas();
            consultaVisitasForm.Show();
        }

        private void panelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
