using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPantallaProducto : Form
    {

        NProductos objNProductos = new NProductos();

        public FrmPantallaProducto()
        {
            InitializeComponent();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProducto.DataSource = objNProductos.BuscarProductos(txtBuscarProducto.Text);
        }

        private void FrmPantallaProducto_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            dgvProducto.DataSource = objNProductos.ListarProductos();
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmVentas frmv = new FrmVentas();
            frmv.MdiParent = this;
            frmv.Show();

        }
    }
}
