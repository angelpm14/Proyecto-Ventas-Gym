using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NUsuario
    {

        public string ValidarUsuario(string USUARIO, string CONTRASEÑA)
        {
            DUsuario objDUsuario = new DUsuario();
            Usuario objUsuario = new Usuario();
            objUsuario.USUARIO = USUARIO;
            objUsuario.CONTRASEÑA = CONTRASEÑA;
            return objDUsuario.Login(objUsuario);
        }




    }
}
