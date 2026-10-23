using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : Form
    {


        NCliente objNCliente = new NCliente();
        DateTime hoy = new DateTime();

        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "C:\\Users\\angel\\OneDrive\\Escritorio\\PROYECTO GINA(AVANCE 1.1)\\sistema(proyecto)\\foto\\"; //modificar el lugar donde se ubican las imagenes de los products


        public FrmCliente()
        {
            InitializeComponent();
        }

        private void txtSOCIOs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSocio_TextChanged(object sender, EventArgs e)
        {
            dgvCliente.DataSource = objNCliente.BuscarCliente(txtSocio.Text);
        }
        private void cargar()
        {
            dgvCliente.DataSource = objNCliente.ListarCliente();
        }
        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtNumDocument.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtFoto.Clear();
            picFoto.Image = null;
            btninsertar.Visible = true;
            btnActualizar.Visible = false;
            erroricono.Clear();
            txtNombre.Focus();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void cargarCliente()
        {
            cboTipDocument.DataSource = objNCliente.ListarCliente();
            cboTipDocument.DisplayMember = "NOMBRE";
            cboTipDocument.ValueMember = "ID_TIPSOC";
        }
        private void FrmSocio_Load(object sender, EventArgs e)
        {
            cargarCliente();
            cargar();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Image files(*.jpg,*.jpeg,*.jpe,*jfif,*.png)|*.jpg;*.jpeg;*.jpe;*jfif;*.png";
            if (file.ShowDialog() == DialogResult.OK)///si luego de abrirse la ventana al seleccionarse una 
            {
                picFoto.Image = Image.FromFile(file.FileName);
                txtFoto.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1);
                RutaOrigen = file.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
            cargarCliente();
            limpiar();
            tabSocio.SelectedIndex = 0;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (txtNombre.Text == string.Empty || txtApellidos.Text == string.Empty || cboTipDocument.Text == string.Empty || txtNumDocument.Text == string.Empty || txtCelular.Text == string.Empty || txtDireccion.Text == string.Empty )
                {
                    this.MensajeError("Falta ingresar algunos datos");
                    erroricono.SetError(txtNombre, "Ingrese el Nombre");
                    erroricono.SetError(txtApellidos, "Ingrese el Apellidos");
                    erroricono.SetError(cboTipDocument, "Seleccione una opcion");
                    erroricono.SetError(txtNumDocument, "Ingrese su numero de documento");
                    erroricono.SetError(txtCelular, "Ingrese su numero Celular o Telefonico");
                    erroricono.SetError(txtDireccion, "Ingrese su direccion");
                }
                else
                {
                    rpta = objNCliente.InsertarCliente(Convert.ToInt32(txtId.Text.Trim()), txtNombre.Text.Trim(), txtApellidos.Text.Trim(), Convert.ToString(cboTipDocument.SelectedValue), txtNumDocument.Text, txtCelular.Text.Trim(), txtDireccion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertò de forma correcta el registro");
                        if (txtFoto.Text != string.Empty)
                        {
                            RutaDestino = Directorio + txtFoto.Text;
                            File.Copy(RutaOrigen, RutaDestino);
                            limpiar();
                            cargar();
                            tabSocio.SelectedIndex = 0;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (txtNombre.Text == string.Empty || txtApellidos.Text == string.Empty || cboTipDocument.Text == string.Empty || txtNumDocument.Text == string.Empty || txtCelular.Text == string.Empty || txtDireccion.Text == string.Empty )
                {
                    this.MensajeError("Falta ingresar algunos datos");
                    erroricono.SetError(txtNombre, "Ingrese el Nombre");
                    erroricono.SetError(txtApellidos, "Ingrese el Apellido");
                    erroricono.SetError(cboTipDocument, "Seleccione una opcion");
                    erroricono.SetError(txtNumDocument, "Ingrese su numero de documento");
                    erroricono.SetError(txtCelular, "Ingrese su numero Celular o Telefonico");
                    erroricono.SetError(txtDireccion, "Ingrese su direccion");
                }
                else
                {
                    rpta = objNCliente.ActualizarCliente(Convert.ToInt32(txtId.Text.Trim()), txtNombre.Text.Trim(), txtApellidos.Text.Trim(), Convert.ToString(cboTipDocument.SelectedValue), txtNumDocument.Text, txtCelular.Text.Trim(), txtDireccion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizo de forma correcta el registro");
                        if (txtFoto.Text != string.Empty)
                        {
                            RutaDestino = Directorio + txtFoto.Text;
                            File.Copy(RutaOrigen, RutaDestino);
                            limpiar();
                            cargar();
                            tabSocio.SelectedIndex = 0;
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

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            try
            {
                opcion = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string foto = dgvCliente.CurrentRow.Cells[7].Value.ToString();
                    string rpta = "";
                    rpta = objNCliente.EliminarCliente(Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value));
                    if (rpta.Equals("OK"))
                    {
                        MensajeOk("Se actualizo de forma correcta el registro");
                        File.Delete(Directorio + foto + " .png");
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

        private void dgvSocio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargar();
            cargarCliente();
            limpiar();
            tabSocio.SelectedIndex = 0;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            tabSocio.SelectedIndex = 1;
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            tabSocio.SelectedIndex = 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            btnActualizar.Visible = true;
            btninsertar.Visible = false;
            txtId.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            cboTipDocument.SelectedValue = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtNumDocument.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtCelular.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();

            string imagen;
            imagen = dgvCliente.CurrentRow.Cells[9].Value.ToString();
            if (imagen != string.Empty)
            {
                picFoto.Image = Image.FromFile(Directorio + imagen);
                txtFoto.Text = imagen;
            }
            else
            {
                picFoto.Image = null;
                txtFoto.Text = "";
            }

            tabSocio.SelectedIndex = 1;
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
