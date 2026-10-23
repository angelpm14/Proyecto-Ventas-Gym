using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Venta
    {
        public int ID_VENTAS { get; set; }
        public int ID_CLIENTES { get; set; }
        public int ID_USUARIO { get; set; }
        public string TIPCOMPRB_VENTA { get; set; }
        public string SERIECOMPRB_VENTA { get; set; }
        public string NUMBCOMPRB_VENTA { get; set; }
        public DateTime FECHA_VENTA { get; set; }
        public Decimal IMPUEST_VENTA { get; set; }
        public decimal TOTAL_VENTA { get; set; }
        public string ESTADO_VENT { get; set; }
        public DataTable Detalles { get; set; }





    }
}
