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
    public class NVenta
    {

        public DataTable ListarVentas()
        {
            DVenta objDVenta = new DVenta();
            return objDVenta.ListarVenta();
        }
        public DataTable BuscarVentas(string valor)
        {
            DVenta objDVenta = new DVenta();
            return objDVenta.BuscaVenta(valor);
        }
        public string InsertarVentas(int ID_USUARIO, int ID_CLIENTES, string TIPCOMPRB_VENTA, string SERIECOMPRB_VENTA, string NUMBCOMPRB_VENTA , decimal IMPUEST_VENTA, decimal TOTAL_VENTA, DataTable detalle)
        {
            DVenta objDVenta = new DVenta();
            Venta objVenta = new Venta();
            objVenta.ID_USUARIO = ID_USUARIO;
            objVenta.ID_CLIENTES = ID_CLIENTES;
            objVenta.TIPCOMPRB_VENTA = TIPCOMPRB_VENTA;
            objVenta.SERIECOMPRB_VENTA = SERIECOMPRB_VENTA;
            objVenta.NUMBCOMPRB_VENTA = NUMBCOMPRB_VENTA;
            objVenta.IMPUEST_VENTA = IMPUEST_VENTA;
            objVenta.TOTAL_VENTA = TOTAL_VENTA;
            objVenta.Detalles = detalle;

            return objDVenta.InsertaVentas(objVenta);
        }

        public string EliminarVentas(int id)
        {
            DVenta objDVenta = new DVenta();
            return objDVenta.AnulaVenta(id);
        }
        public DataTable ListarDetalle(int id)
        {
            DVenta objDVenta = new DVenta();
            return objDVenta.ListaDetalle(id);
        }
        
        public string AnularVenta(int id)
        {
            DVenta ObjDVenta = new DVenta();
            return ObjDVenta.AnulaVenta(id);
        }




    }
}
