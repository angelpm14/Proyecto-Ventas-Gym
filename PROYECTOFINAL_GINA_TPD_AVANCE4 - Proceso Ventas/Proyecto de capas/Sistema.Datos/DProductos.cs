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
    public class DProductos
    {
        SqlConnection con;
        Conexion objconexion = new Conexion();

        //IMPLETMENTACION DE METODOS
        public DataTable ListaProductos()
        {

            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_listaProductos", con);
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
        public DataTable BuscaProductos(string valor)
        {

            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_BuscaProducto", con);
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
        public string InsertaProductos(Productos obj)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertaProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_CATE", SqlDbType.Int).Value = obj.IdCategoria;
                cmd.Parameters.Add("@cod_prod", SqlDbType.VarChar).Value = obj.Cod_prod;
                cmd.Parameters.Add("@nom_prod", SqlDbType.VarChar).Value = obj.Nom_prod;
                cmd.Parameters.Add("@prec_prod", SqlDbType.Decimal).Value = obj.Preci_prod;
                cmd.Parameters.Add("@stock_prod", SqlDbType.Int).Value = obj.Stock_prod;
                cmd.Parameters.Add("@descrip_prod", SqlDbType.VarChar).Value = obj.Descrip_prod;
                cmd.Parameters.Add("@imag_prod", SqlDbType.VarChar).Value = obj.Imag_prod;
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

        public string ActualizaProductos(Productos obj)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizaProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = obj.IdProductos;
                cmd.Parameters.Add("@ID_CATE", SqlDbType.Int).Value = obj.IdCategoria;
                cmd.Parameters.Add("@cod_prod", SqlDbType.VarChar).Value = obj.Cod_prod;
                cmd.Parameters.Add("@nom_prod", SqlDbType.VarChar).Value = obj.Nom_prod;
                cmd.Parameters.Add("@prec_prod", SqlDbType.Decimal).Value = obj.Preci_prod;
                cmd.Parameters.Add("@stock_prod", SqlDbType.Int).Value = obj.Stock_prod;
                cmd.Parameters.Add("@descrip_prod", SqlDbType.VarChar).Value = obj.Descrip_prod;
                cmd.Parameters.Add("@imag_prod", SqlDbType.VarChar).Value = obj.Imag_prod;
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
        public string EliminarProductos(int Id)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminaProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = Id;
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
        public DataTable BuscaProductoCodigoVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            con = objconexion.getConecta();
            try
            {
                SqlCommand Comando = new SqlCommand("sp_BuscarCodigoVentaProducto", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                con.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return Tabla;
        }

        public string ActivaProducto(int id)
        {
            string Rpta = "";
            con = objconexion.getConecta();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_ActivarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PROD", SqlDbType.Int).Value = id;
                con.Open();//abre la conexion
                Rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Activar el registro";
                //ExecuteNonQuery es un metodo que no devuelve filas
                //pero retorna el numero de filas afectadas
            }
            catch (Exception ex)
            {
                Rpta = ex.Message; //si se produce el error muestra la exception
            }
            finally //se ejecuta cuando el control sale de bloque try
            {
                con.Close();
            }
            return Rpta;
        }
        public string DesactivaProducto(int id)
        {
            string Rpta = "";
            con = objconexion.getConecta();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_DesactivarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PROD", SqlDbType.Int).Value = id;
                con.Open();//abre la conexion
                Rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Desactivar el registro";
                //ExecuteNonQuery es un metodo que no devuelve filas
                //pero retorna el numero de filas afectadas
            }
            catch (Exception ex)
            {
                Rpta = ex.Message; //si se produce el error muestra la exception
            }
            finally //se ejecuta cuando el control sale de bloque try
            {
                con.Close();
            }
            return Rpta;
        }

    }
}
