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
    public partial class FrmPantallaVistaCliente : Form
    {
        NCliente objNCliente= new NCliente();
        public FrmPantallaVistaCliente()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        void cargar()
        {
            dgvClientes.DataSource = objNCliente.ListarCliente();
        }
        void buscar()
        {
            try
            {
                dgvClientes.DataSource = objNCliente.BuscarCliente(txtBuscar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmPantallaVistaCliente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.ID_CLIENTE = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            Variables.NOMB_CLIENTE = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            Dispose();
        }
    }
}
