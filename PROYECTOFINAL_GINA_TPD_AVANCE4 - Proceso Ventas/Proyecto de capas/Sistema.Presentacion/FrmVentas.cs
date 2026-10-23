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
    public partial class FrmVentas : Form
    {

        NProductos objNProductos= new NProductos();
        NVenta objNVenta= new NVenta();
        private DataTable DDetalle = new DataTable(); //tabla momentanea


        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnFiltrararticulos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArticulos.DataSource = objNProductos.BuscarProductos(txtBuscararticulos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmPantallaVistaCliente frmVentaCli = new FrmPantallaVistaCliente();
            frmVentaCli.ShowDialog();//
            txtIDCliene.Text = Convert.ToString(Variables.ID_CLIENTE);
            txtNombreClient.Text = Variables.NOMB_CLIENTE;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CrearTabla();

        }

        private void btnCerrarDetalleventa_Click(object sender, EventArgs e)
        {
            panelMostrarDet.Visible = false;
        }

        private void dgvVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CrearTabla()
        {
            //añadiendo columnas y tipos especificos
            DDetalle.Columns.Add("ID_PROD", System.Type.GetType("System.Int32"));
            DDetalle.Columns.Add("COD_PROD", System.Type.GetType("System.String"));
            DDetalle.Columns.Add("NOMB_PROD", System.Type.GetType("System.String"));
            DDetalle.Columns.Add("STOCK_PROD", System.Type.GetType("System.Int32"));
            DDetalle.Columns.Add("CANT_DETALLVENT", System.Type.GetType("System.Int32"));
            DDetalle.Columns.Add("PREC_DETALLVENT", System.Type.GetType("System.Decimal"));
            DDetalle.Columns.Add("DESCUE_DETALLVENT", System.Type.GetType("System.Decimal"));
            DDetalle.Columns.Add("Importe", System.Type.GetType("System.Decimal"));


            //nombracion de las columnas emcabezados

            dgvDetalle.DataSource = DDetalle;
            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[1].HeaderText = "CODIGO BAR";
            dgvDetalle.Columns[2].HeaderText = "NOMBRE";
            dgvDetalle.Columns[3].HeaderText = "STOCK";
            dgvDetalle.Columns[4].HeaderText = "CANTIDAD";
            dgvDetalle.Columns[5].HeaderText = "PRECIO";
            dgvDetalle.Columns[6].HeaderText = "DESCUENTO";
            dgvDetalle.Columns[7].HeaderText = "IMPORTE";

            //solo sera lectura y no sera modificable

            dgvDetalle.Columns[1].ReadOnly = true;
            dgvDetalle.Columns[2].ReadOnly = true;
            dgvDetalle.Columns[3].ReadOnly = true;
            dgvDetalle.Columns[5].ReadOnly = true;
            dgvDetalle.Columns[7].ReadOnly = true;

        }

        private void AgregarDetalle(int ID_PROD, string COD_PROD, string NOMB_PROD, int STOCK_PROD, int CANT_DETALLVENT, decimal PREC_DETALLVENT, decimal DESCUE_DETALLVENT)
        {
            bool Agregar = true;
            foreach (DataRow FilaTemp in DDetalle.Rows)
            {
                if (Convert.ToInt32(FilaTemp["ID_PROD"]) == ID_PROD)
                {
                    Agregar = false;
                    MensajeError("El artículo ya ha sido agregado.");
                }
            }
            if (Agregar)
            {
                DataRow Fila = DDetalle.NewRow();
                Fila["ID_PROD"] = ID_PROD;
                Fila["CODIGO"] = COD_PROD;
                Fila["NOMBRE"] = NOMB_PROD;
                Fila["STOCK"] = STOCK_PROD;
                Fila["CANTIDAD"] = 1;
                Fila["PRECIO"] = PREC_DETALLVENT;
                Fila["DESCUENTO"] = 0;
                Fila["IMPORTE"] = PREC_DETALLVENT;
                DDetalle.Rows.Add(Fila);
                CalcularTotales();
            }
        }

        private void Limpiar()
        {
            txtIDCliene.Clear();
            txtNombreClient.Clear();
            txtSerieComprob.Clear();
            txtNumeroComprob.Clear();
            DDetalle.Clear();
            txtSubTotal.Text = "0.00";
            txtTotalIgv.Text = "0.00";
            txtTotal.Text = "0.00";

        }
        private void ListarVentas()
        {
            try
            {
                dgvVenta.DataSource = objNVenta.ListarVentas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            if (dgvDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            {
                foreach (DataRow FilaTemp in DDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(FilaTemp["importe"]);
                }
            }
            SubTotal = Total / (1 + Convert.ToDecimal(txtIGV.Text));
            txtTotal.Text = Total.ToString("#0.00#");
            txtSubTotal.Text = SubTotal.ToString("#0.00#");
            txtTotalIgv.Text = (Total - SubTotal).ToString("#0.00#");
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            try
            {
                opcion = MessageBox.Show("¿Esta seguro que deseas Anular el registro de venta?", "Sistema de ventas",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {

                    string Rpta = "";
                    Rpta = objNVenta.AnularVenta(Convert.ToInt32(dgvVenta.CurrentRow.Cells[0].Value));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se Desactivo de forma correcta el registro");


                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID_PROD;
            string NOMB_PROD, COD_PROD;
            decimal PREC_DETALLVENT, DESCUE_DETALLVENT;
            int STOCK_PROD, CANT_DETALLVENT;
            ID_PROD = Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value);
            COD_PROD = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
            NOMB_PROD = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
            STOCK_PROD = Convert.ToInt32(dgvArticulos.CurrentRow.Cells[3].Value);
            CANT_DETALLVENT = Convert.ToInt32(dgvArticulos.CurrentRow.Cells[4].Value);
            PREC_DETALLVENT = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells[5].Value);
            DESCUE_DETALLVENT = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells[6].Value);
            AgregarDetalle(ID_PROD,COD_PROD, NOMB_PROD,STOCK_PROD,CANT_DETALLVENT,PREC_DETALLVENT,DESCUE_DETALLVENT);
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = true;
        }

        private void btnCerrararticulo_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
        }

        private void txtBuscararticulos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NProductos.BuscarProductoCodigoVenta(txtCodigo.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("No existe artículo con ese código de barras o no hay stock de ese artículo.");
                    }
                    else
                    {
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]), Convert.ToString(Tabla.Rows[0][2]),Convert.ToInt32(Tabla.Rows[0][3]),Convert.ToInt32(Tabla.Rows[0][4]), Convert.ToDecimal(Tabla.Rows[0][5]), Convert.ToDecimal(Tabla.Rows[0][6]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIDCliene.Text == string.Empty || txtIGV.Text == string.Empty || txtNumeroComprob.Text == string.Empty || DDetalle.Rows.Count == 0)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    erroricono.SetError(txtIDCliene, "Seleccione un cliente.");
                    erroricono.SetError(txtIGV, "Ingrese un impuesto.");
                    erroricono.SetError(txtNumeroComprob, "Ingrese el número del comprobante.");
                    erroricono.SetError(dgvDetalle, "Debe tener al menos un detalle.");
                }
                else
                {
                    Rpta = objNVenta.InsertarVentas(Variables.ID_CLIENTE,Convert.ToInt32(txtIDCliene.Text), cboComprobante.Text, txtSerieComprob.Text.Trim(), txtNumeroComprob.Text.Trim(), Convert.ToDecimal(txtIGV.Text), Convert.ToDecimal(txtTotal.Text), DDetalle);
                    if (Rpta.Equals("OK"))
                    {
                        MensajeOK("Se insertó de forma correcta el registro");
                        Limpiar();
                        ListarVentas();
                    }
                    else
                    {
                        MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            tabVentas.SelectedIndex = 0;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tabVentas.SelectedIndex = 0;
        }
    }
}
