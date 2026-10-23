using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Productos
    {

        public int IdProductos { get; set; }
        public int IdCategoria { get; set; }
        public string Cod_prod { get; set; }
        public string Nom_prod { get; set; }
        public decimal Preci_prod { get; set; }
        public int Stock_prod { get; set; }
        public string Descrip_prod { get; set; }
        public string Imag_prod { get; set; }
        public bool Estado { get; set; }
    }
}
