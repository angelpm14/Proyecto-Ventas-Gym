using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NProductos
    {

        //DCategoria objDCategoria = new DCategoria();

        public DataTable ListarProductos()
        {
            DProductos objDProductos = new DProductos();
            return objDProductos.ListaProductos();
        }



        public DataTable BuscarProductos(string valor)
        {
            DProductos objDProductos = new DProductos();
            return objDProductos.BuscaProductos(valor);
        }
        public string InsertarProductos(int idcategoria, string codigo, string nombre, decimal precio, int stock, string descripcion, string imagen)
        {
            DProductos objDProductos = new DProductos();
            Productos objProductos = new Productos();
            objProductos.IdCategoria = idcategoria;
            objProductos.Cod_prod = codigo;
            objProductos.Nom_prod = nombre;
            objProductos.Preci_prod = precio;
            objProductos.Stock_prod = stock;
            objProductos.Descrip_prod = descripcion;
            objProductos.Imag_prod = imagen;
            return objDProductos.InsertaProductos(objProductos);

        }

        public string ActualizarProductos(int idcategoria, int idproductos, string codigo, string nombre, decimal precio, int stock, string descripcion, string imagen)
        {
            DProductos objDProductos = new DProductos();
            Productos objProductos = new Productos();
            objProductos.IdCategoria = idcategoria;
            objProductos.IdProductos = idproductos;
            objProductos.Cod_prod = codigo;
            objProductos.Nom_prod = nombre;
            objProductos.Preci_prod = precio;
            objProductos.Stock_prod = stock;
            objProductos.Descrip_prod = descripcion;
            objProductos.Imag_prod = imagen;

            return objDProductos.ActualizaProductos(objProductos);
        }

        public string EliminarProductos(int id)
        {
            DProductos objDProductos = new DProductos();
            return objDProductos.EliminarProductos(id);
        }

        public static DataTable BuscarProductoCodigoVenta(string Valor)
        {
            DProductos Datos = new DProductos();
            return Datos.BuscaProductoCodigoVenta(Valor);
        }






    }
}
