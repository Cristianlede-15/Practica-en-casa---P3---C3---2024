using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public bool Login(string username, string password)
        {
            return _usuarioRepository.Login(username, password);
        }

        public void CrearUsuario(string nombre, string apellido, DateTime fechaNacimiento, string tipoUsuario, string username, string password)
        {
            _usuarioRepository.CrearUsuario(nombre, apellido, fechaNacimiento, tipoUsuario, username, password);
        }

        public bool EsAdministrador(string username)
        {
            return _usuarioRepository.EsAdministrador(username);
        }

        public bool AutenticarUsuario(string username, string password)
        {
            return _usuarioRepository.AutenticarUsuario(username, password);
        }


    }
}
