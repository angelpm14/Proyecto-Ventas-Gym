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
    public class DCategoria
    {

        SqlConnection con;
        Conexion objconexion = new Conexion();

        //IMPLETMENTACION DE METODOS
        public DataTable ListaCategoria()
        {

            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_listacategoria", con);
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
        public DataTable BuscaCategoria(string variable)
        {

            con = objconexion.getConecta();
            DataTable dt = new DataTable();
            try
            {
                con.Open();//ABRE LA CONEXION
                SqlDataAdapter adapter = new SqlDataAdapter("sp_BuscarCategoria", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;// EJECUTA EL SP
                adapter.SelectCommand.Parameters.Add("variable", SqlDbType.VarChar).Value = variable;
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
        public string InsertaCategoria(Categoria obj)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertarcategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOM_CATE", SqlDbType.VarChar).Value = obj.Nombre;
                cmd.Parameters.Add("@DESCR_CATE", SqlDbType.VarChar).Value = obj.Descripcion;
                con.Open();//Abre la conexion
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registrivo";
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

        public string ActualizaCategoria(Categoria obj)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_actualizarcategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cod_cate", SqlDbType.Int).Value = obj.Idcategoria;
                cmd.Parameters.Add("@NOM_CATE", SqlDbType.VarChar).Value = obj.Nombre;
                cmd.Parameters.Add("@DESCR_CATE", SqlDbType.VarChar).Value = obj.Descripcion;
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
        public string EliminarCategoria(int Id)
        {
            string rpta = "";
            con = objconexion.getConecta();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarcategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cod_cate", SqlDbType.Int).Value = Id;
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
