using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DCliente
    {

        SqlConnection con;
        Conexion objconexion = new Conexion();

        //IMPLETMENTACION DE METODOS
        public DataTable ListaClientes()
        {

            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_listaClientes", con);
                adapter.Fill(dt);
                return dt;//RETORNA LA TABLA
            }
            catch (Exception ex)
            {

                throw ex;//SI SE PRODUCE UN ERROR MUESTRA LA EXCEPCION
            }
            finally
            { //SE EJECUTA CUANDO EL CONTROL SALE DEL BLOQUE TRY
                con.Close();
            }
        }

        public DataTable BuscaClientes(string valor)
        {

            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_BuscarCliente", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;// EJECUTA EL SP
                adapter.SelectCommand.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                adapter.Fill(dt);
                return dt;//RETORNA LA TABLA
            }
            catch (Exception ex)
            {
                throw ex;//SI SE PRODUCE UN ERROR MUESTRA LA EXCEPCION
            }
            finally
            { //SE EJECUTA CUANDO EL CONTROL SALE DEL BLOQUE TRY
                con.Close();
            }

        }

        public string InsertaCliente(Cliente obj)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertaCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMB_CLIENTE", SqlDbType.VarChar).Value = obj.NOMB_CLIENTE;
                cmd.Parameters.Add("@APE_CLIENTE", SqlDbType.VarChar).Value = obj.APE_CLIENTE;
                cmd.Parameters.Add("@CORRE_CLIENTE", SqlDbType.VarChar).Value = obj.CORRE_CLIENTE;
                cmd.Parameters.Add("@CELUL_CLIENTE ", SqlDbType.VarChar).Value = obj.CELUL_CLIENTE;
                cmd.Parameters.Add("@DIRECC_CLIENTE ", SqlDbType.VarChar).Value = obj.DIRECC_CLIENTE;
                cmd.Parameters.Add("@FOTO_CLIENTE ", SqlDbType.VarChar).Value = obj.FOTO_CLIENTE;
                con.Open();//Abre la conexion
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registrivo";
                //ExecuteNonQuery es un metodo que no devuelve fila
                //pero retorna el numero de filas afectada
            }
            catch (Exception ex)
            {
                rpta = ex.Message;//SI SE PRODUCE UN ERROR MUESTRA LA EXCEPCION
            }
            finally
            { //SE EJECUTA CUANDO EL CONTROL SALE DEL BLOQUE TRY
                con.Close();
            }
            return rpta;
        }

        public string ActualizaCliente(Cliente obj)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_actualizaCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_CLIENTES", SqlDbType.Int).Value = obj.ID_CLIENTES;
                cmd.Parameters.Add("@NOMB_CLIENTE", SqlDbType.VarChar).Value = obj.NOMB_CLIENTE;
                cmd.Parameters.Add("@APE_CLIENTE", SqlDbType.VarChar).Value = obj.APE_CLIENTE;
                cmd.Parameters.Add("@CORRE_CLIENTE", SqlDbType.VarChar).Value = obj.CORRE_CLIENTE;
                cmd.Parameters.Add("@CELUL_CLIENTE", SqlDbType.VarChar).Value = obj.CELUL_CLIENTE;
                cmd.Parameters.Add("@DIRECC_CLIENTE", SqlDbType.VarChar).Value = obj.DIRECC_CLIENTE;
                cmd.Parameters.Add("@FOTO_CLIENTE", SqlDbType.VarChar).Value = obj.FOTO_CLIENTE;
                con.Open();//Abre la conexion
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registrivo";
                //ExecuteNonQuery es un metodo que no devuelve fila
                //pero retorna el numero de filas afectada
            }
            catch (Exception ex)
            {
                rpta = ex.Message;//SI SE PRODUCE UN ERROR MUESTRA LA EXCEPCION
            }
            finally
            { //SE EJECUTA CUANDO EL CONTROL SALE DEL BLOQUE TRY
                con.Close();
            }
            return rpta;
        }
        public string EliminarCliente(int Id)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarSocio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_CLIENTES", SqlDbType.Int).Value = Id;
                con.Open();//Abre la conexion
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
                //ExecuteNonQuery es un metodo que no devuelve fila
                //pero retorna el numero de filas afectada
            }
            catch (Exception ex)
            {
                rpta = ex.Message;//SI SE PRODUCE UN ERROR MUESTRA LA EXCEPCION
            }
            finally
            { //SE EJECUTA CUANDO EL CONTROL SALE DEL BLOQUE TRY
                con.Close();
            }
            return rpta;
        }








    }
}
