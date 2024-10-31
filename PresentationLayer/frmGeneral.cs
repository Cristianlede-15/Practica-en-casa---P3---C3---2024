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
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }

        private void RegistrarVisita_Click(object sender, EventArgs e)
        {
            frmRegistrarVisita registrarVisitaForm = new frmRegistrarVisita();
            registrarVisitaForm.Show();
        }

        private void ConsultaVisitas_Click(object sender, EventArgs e)
        {
            frmConsultaVisitas consultaVisitasForm = new frmConsultaVisitas();
            consultaVisitasForm.Show();
        }
    }
}
