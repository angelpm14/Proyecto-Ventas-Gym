using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DUsuario
    {


        SqlConnection con;
        Conexion objconexion = new Conexion();


        public string Login(Usuario obj)
        {
            string resultado = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_LoginUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = obj.USUARIO;
                cmd.Parameters.Add("@CONTRA", SqlDbType.VarChar).Value = obj.CONTRASEÑA;

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    resultado = "OK";
                }
                else
                {
                    resultado = "Credenciales incorrectas";
                }

            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return resultado;
        }




    }
}
