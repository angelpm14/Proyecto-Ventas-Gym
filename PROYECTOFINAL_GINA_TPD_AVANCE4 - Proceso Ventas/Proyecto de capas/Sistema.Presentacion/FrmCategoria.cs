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
    public partial class FrmCategoria : Form
    {
        NCategoria objNCategoria = new NCategoria();

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtnombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar el nombre");
                    erroricono.SetError(txtnombre, "Ingrese un Nombre");
                }
                else
                {
                    rpta = objNCategoria.InsetarCategoria(txtnombre.Text.Trim(), txtdescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro");
                        this.limpiar();
                        cargar();//para cargar dgc despues de inserta correctamente
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
                if (txtnombre.Text == string.Empty || txtId.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    erroricono.SetError(txtnombre, "Ingrese un Nombre");
                }
                else
                {
                    rpta = objNCategoria.ActualizarCategoria(Convert.ToInt32(txtId.Text), txtnombre.Text.Trim(), txtdescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizo de forma correcta el registro");
                        this.limpiar();
                        cargar();//para cargar dgc despues de inserta correctamente
                        tabCategorias.SelectedIndex = 0;
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
        private void limpiar()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            btninsertar.Visible = true;
            erroricono.Clear();
        }
        private void cargar()
        {
            dgvCategorias.DataSource = objNCategoria.ListarCategoria();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = objNCategoria.BuscarCategoria(txtCategoria.Text);
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            btnActualizar.Visible = true;
            btninsertar.Visible = false;
            txtId.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = dgvCategorias.CurrentRow.Cells[2].Value.ToString();
            tabCategorias.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string rpta = ";";
            DialogResult opcion;
            try
            {
                opcion = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    rpta = objNCategoria.EliminarCategoria(Convert.ToInt32(txtId.Text));
                    if (rpta.Equals("OK"))
                    {
                        MensajeOk("Se actualizo de forma correcta el registro");
                        limpiar();
                    }
                }
                else
                {
                    MensajeError(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try
            //{
            //    string rpta = "";
            //    if (txtId.Text == string.Empty)
            //    {
            //        this.MensajeError("Falta ingresar algunos datos, seran remarcados");
            //        erroricono.SetError(txtId, "Ingrese un Id");
            //    }
            //    else
            //    {
            //        rpta = objNCategoria.EliminarCategoria(Convert.ToInt32(txtId.Text));
            //        if (rpta.Equals("OK"))
            //        {
            //            this.MensajeOk("Se Elimino de forma correcta el registro");
            //            this.limpiar();
            //            cargar();//para cargar dgc despues de inserta correctamente
            //        }
            //        else
            //        {
            //            this.MensajeError(rpta);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
