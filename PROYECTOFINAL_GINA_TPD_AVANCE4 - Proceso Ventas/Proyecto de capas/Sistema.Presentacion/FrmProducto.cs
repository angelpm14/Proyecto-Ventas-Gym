using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmProducto : Form
    {

        NProductos objNProductos = new NProductos();
        NCategoria objNCategoria = new NCategoria();


        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "C:\\Users\\angel\\OneDrive\\Escritorio\\sistema(proyecto)\\imagenes\\"; //modificar el lugar donde se ubican las imagenes de los products
        private string DirectorioCB = "C:\\Users\\angel\\OneDrive\\Escritorio\\sistema(proyecto)\\codigobarra\\";//modificar el lugar donde se guardan las imagenes guardadas del codigo de barras

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cargar();
            cargarCategoria();
            limpiar();
            tabProducto.SelectedIndex = 0;
        }
        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCodigo.Clear();
            txtPrecioV.Clear();
            txtStock.Clear();
            txtImagen.Clear();
            picImagen.Image = null;
            txtdescripcion.Clear();
            btninsertar.Visible = true;
            btnActualizar.Visible = false;
            erroricono.Clear();
        }
        void cargarCategoria()
        {
            cboCategoria.DataSource = objNCategoria.ListarCategoria();
            cboCategoria.DisplayMember = "NOM_CATE";
            cboCategoria.ValueMember = "ID_CATE";
        }
        private void cargar()
        {
            dgvProducto.DataSource = objNProductos.ListarProductos();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = DirectorioCB;
            saveFile.FileName = txtCodigo.Text + " .png";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string codigob = saveFile.FileName;
                Bitmap bitmap = new Bitmap(pbCodigobarras.Image);
                bitmap.Save(codigob);
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cargarCategoria();
            cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (cboCategoria.Text == string.Empty || txtCodigo.Text == string.Empty || txtNombre.Text == string.Empty || txtPrecioV.Text == string.Empty || txtStock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos");
                    erroricono.SetError(txtNombre, "Ingrese el Nombre");
                    erroricono.SetError(txtCodigo, "Ingrese el Codigo");
                    erroricono.SetError(txtPrecioV, "Ingrese el Precio");
                    erroricono.SetError(txtStock, "Ingrese el Stock");
                }
                else
                {
                    rpta = objNProductos.ActualizarProductos(Convert.ToInt32(txtId.Text), Convert.ToInt32(cboCategoria.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioV.Text), Convert.ToInt32(txtCodigo.Text.Trim()), txtdescripcion.Text.Trim(), txtImagen.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizo de forma correcta el registro");
                        if (txtImagen.Text != string.Empty)
                        {
                            RutaDestino = Directorio + txtImagen.Text;
                            File.Copy(RutaOrigen, RutaDestino);
                            limpiar();
                            cargar();
                            tabProducto.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarCod_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw generacodigo = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pbCodigobarras.Image = generacodigo.Draw(txtCodigo.Text, 60);
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Image files(*.jpg,*.jpeg,*.jpe,*jfif,*.png)|*.jpg;*.jpeg;*.jpe;*jfif;*.png";
            if (file.ShowDialog() == DialogResult.OK)///si luego de abrirse la ventana al seleccionarse una 
            {
                picImagen.Image = Image.FromFile(file.FileName);
                txtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1);
                RutaOrigen = file.FileName;
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (cboCategoria.Text == string.Empty || txtCodigo.Text == string.Empty || txtNombre.Text == string.Empty || txtPrecioV.Text == string.Empty || txtStock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos");
                    erroricono.SetError(txtNombre, "Ingrese el Nombre");
                    erroricono.SetError(txtCodigo, "Ingrese el Codigo");
                    erroricono.SetError(txtPrecioV, "Ingrese el Precio");
                    erroricono.SetError(txtStock, "Ingrese el Stock");
                }
                else
                {
                    rpta = objNProductos.InsertarProductos(Convert.ToInt32(cboCategoria.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), Convert.ToDecimal(txtPrecioV.Text), Convert.ToInt32(txtCodigo.Text.Trim()), txtdescripcion.Text.Trim(), txtImagen.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertò de forma correcta el registro");
                        if (txtImagen.Text != string.Empty)
                        {
                            RutaDestino = Directorio + txtImagen.Text;
                            File.Copy(RutaOrigen, RutaDestino);
                            limpiar();
                            cargar();
                            tabProducto.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProducto.DataSource = objNProductos.BuscarProductos(txtProducto.Text);
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            btnActualizar.Visible = true;
            btninsertar.Visible = false;
            txtId.Text = dgvProducto.CurrentRow.Cells[0].Value.ToString();
            cboCategoria.SelectedValue = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            //txtCodigo.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
            txtPrecioV.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            txtStock.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();
            txtdescripcion.Text = dgvProducto.CurrentRow.Cells[6].Value.ToString();

            string imagen;
            string codBarras = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            imagen = dgvProducto.CurrentRow.Cells[7].Value.ToString();
            if (imagen != string.Empty && codBarras != string.Empty)
            {
                picImagen.Image = Image.FromFile(Directorio + imagen);
                txtImagen.Text = imagen;
                pbCodigobarras.Image = Image.FromFile(DirectorioCB + codBarras + " .png");
                txtCodigo.Text = codBarras;
            }
            else
            {
                picImagen.Image = null;
                txtImagen.Text = "";
                pbCodigobarras.Image = null;
                txtCodigo.Text = "";
            }

            tabProducto.SelectedIndex = 1;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            try
            {
                opcion = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string codigo = dgvProducto.CurrentRow.Cells[2].Value.ToString();
                    string imagen = dgvProducto.CurrentRow.Cells[7].Value.ToString();
                    string rpta = "";
                    rpta = objNProductos.EliminarProductos(Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value));
                    if (rpta.Equals("OK"))
                    {
                        MensajeOk("Se actualizo de forma correcta el registro");
                        File.Delete(Directorio + imagen);
                        File.Delete(DirectorioCB + codigo + " .png");
                        limpiar();
                    }
                    else
                    {
                        MensajeError(rpta);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cargar();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
