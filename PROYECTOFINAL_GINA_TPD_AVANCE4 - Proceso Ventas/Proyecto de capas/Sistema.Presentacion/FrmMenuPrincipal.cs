using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmC = new FrmCategoria();
            frmC.MdiParent = this;//INDICA QUE EL FORMULARIO MDI SERA SU CONTENEDOR
            frmC.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frmP = new FrmProducto();
            frmP.MdiParent = this;//INDICA QUE EL FORMULARIO MDI SERA SU CONTENEDOR
            frmP.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void consultaComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPantallaProducto frmpantprod = new FrmPantallaProducto();
            frmpantprod.MdiParent = this;
            frmpantprod.Show();

            //FrmProducto frmP = new FrmProducto();
            //frmP.MdiParent = this;//INDICA QUE EL FORMULARIO MDI SERA SU CONTENEDOR
            //frmP.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btnMantenimiento.Enabled = true;
            //btnReportes.Enabled = true;
            //btnVentas.Enabled = false;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMantenimientos.Enabled = true;
            btnVentas.Enabled = false;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnVentas.Enabled = true;
            btnMantenimientos.Enabled = false;
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente idsocio = new FrmCliente();
            idsocio.MdiParent = this;
            idsocio.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmUsuarios idusua = new FrmSocio();
            //idsocio.MdiParent = this;
            //idsocio.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria ID_CATE = new FrmCategoria();
            ID_CATE.MdiParent=this;
            ID_CATE.Show();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategoria ID_CATE = new FrmCategoria();
            ID_CATE.MdiParent = this;
            ID_CATE.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void membresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmMembresias ID_MEM = new FrmMembresias();
            //ID_MEM.MdiParent = this;
            //ID_MEM.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void membresiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmMembresias ID_MEM = new FrmMembresias();
            //ID_MEM.MdiParent = this;
            //ID_MEM.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente idsocio = new FrmCliente();
            idsocio.MdiParent = this;
            idsocio.Show();
        }

        private void consultaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmPantallaProducto frmpantprod = new FrmPantallaProducto();
            //frmpantprod.MdiParent = this;
            //frmpantprod.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmv = new FrmVentas();
            frmv.MdiParent = this;
            frmv.Show();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
