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
    public partial class frmLogin : Form
    {
        private readonly UsuarioService _usuarioService;
        public frmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.text;
            string password = txtPassword.text;

            if (_usuarioService.AutenticarUsuario(username, password))
            {
                bool isAdmin = _usuarioService.EsAdministrador(username);
                Form siguienteForm = isAdmin ? (Form)new frmAdmin() : new frmGeneral();
                siguienteForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
