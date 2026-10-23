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
    public class NCategoria
    {
        //DCategoria objDCategoria = new DCategoria();

        public DataTable ListarCategoria()
        {
            DCategoria objDCategoria = new DCategoria();
            return objDCategoria.ListaCategoria();
        }
        public DataTable BuscarCategoria(string valor)
        {
            DCategoria objDCategoria = new DCategoria();
            return objDCategoria.BuscaCategoria(valor);
        }
        public string InsetarCategoria(string nombre, string descripcion)
        {
            DCategoria objDCategoria = new DCategoria();
            Categoria objCategoria = new Categoria();
            objCategoria.Nombre = nombre;
            objCategoria.Descripcion = descripcion;
            return objDCategoria.InsertaCategoria(objCategoria);
        }
        public string ActualizarCategoria(int id, string nombre, string descripcion)
        {
            DCategoria objDCategoria = new DCategoria();
            Categoria objCategoria = new Categoria();
            objCategoria.Idcategoria = id;
            objCategoria.Nombre = nombre;
            objCategoria.Descripcion = descripcion;
            return objDCategoria.ActualizaCategoria(objCategoria);
        }

        public string EliminarCategoria(int id)
        {
            DCategoria objDCategoria = new DCategoria();
            return objDCategoria.EliminarCategoria(id);
        }


    }
}
