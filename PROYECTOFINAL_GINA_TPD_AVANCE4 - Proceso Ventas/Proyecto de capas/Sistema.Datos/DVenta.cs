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
    public class DVenta
    {
        SqlConnection con;
        Conexion objconexion = new Conexion();

        public DataTable ListarVenta()
        {
            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_listarventas", con);
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
        public DataTable BuscaVenta(string valor)
        {
            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_BuscarVenta", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;// EJECUTA EL SP
                adapter.SelectCommand.Parameters.Add("valor", SqlDbType.VarChar).Value = valor;
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


        public string AnulaVenta(int Id)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ventaanular", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                con.Open();//Abre la conexion
                cmd.ExecuteNonQuery();
                rpta = "OK";
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
        public string InsertaVentas(Venta ven)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertarVenta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = ven.ID_USUARIO;
                cmd.Parameters.Add("@ID_CLIENTES", SqlDbType.Int).Value = ven.ID_CLIENTES;
                cmd.Parameters.Add("@TIPCOMPRB_VENTA", SqlDbType.VarChar).Value = ven.TIPCOMPRB_VENTA;
                cmd.Parameters.Add("@SERIECOMPRB_VENTA", SqlDbType.VarChar).Value = ven.SERIECOMPRB_VENTA;
                cmd.Parameters.Add("@NUMBCOMPRB_VENTA", SqlDbType.VarChar).Value = ven.NUMBCOMPRB_VENTA;
                cmd.Parameters.Add("@FECHA_VENTA", SqlDbType.DateTime).Value = ven.FECHA_VENTA;
                cmd.Parameters.Add("@IMPUEST_VENTA", SqlDbType.Decimal).Value = ven.IMPUEST_VENTA;
                cmd.Parameters.Add("@TOTAL_VENTA", SqlDbType.Decimal).Value = ven.TOTAL_VENTA;
                cmd.Parameters.Add("@ESTADO_VENT", SqlDbType.VarChar).Value = ven.ESTADO_VENT;
                con.Open();//Abre la conexion
                cmd.ExecuteNonQuery();
                rpta = "OK";
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


        public DataTable ListaDetalle(int Id)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertarVenta", con);
                SqlCommand Comando = new SqlCommand("sp_ListarDetallVenta", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                con.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
                //ExecuteNonQuery es un metodo que no devuelve fila
                //pero retorna el numero de filas afectada
            }
            catch (Exception ex)
            {

                return null;
                throw ex;
            }
            finally
            { //SE EJECUTA CUANDO EL CONTROL SALE DEL BLOQUE TRY
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}
