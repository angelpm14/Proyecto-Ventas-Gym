namespace Sistema.Presentacion
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMostrarDet = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalImpID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubTotalD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.btnCerrarDetalleventa = new System.Windows.Forms.Button();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelArticulos = new System.Windows.Forms.Panel();
            this.btnCerrararticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnFiltrarProductos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscararticulos = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalIgv = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSerieComprob = new System.Windows.Forms.TextBox();
            this.txtNumeroComprob = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.txtNombreClient = new System.Windows.Forms.TextBox();
            this.txtIDCliene = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabVentas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelMostrarDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabPage1);
            this.tabVentas.Controls.Add(this.tabPage2);
            this.tabVentas.Location = new System.Drawing.Point(36, 12);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(751, 528);
            this.tabVentas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMostrarDet);
            this.tabPage1.Controls.Add(this.txtVenta);
            this.tabPage1.Controls.Add(this.lblVentas);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.dgvVenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelMostrarDet
            // 
            this.panelMostrarDet.BackColor = System.Drawing.Color.YellowGreen;
            this.panelMostrarDet.Controls.Add(this.textBox1);
            this.panelMostrarDet.Controls.Add(this.label12);
            this.panelMostrarDet.Controls.Add(this.txtTotalImpID);
            this.panelMostrarDet.Controls.Add(this.label13);
            this.panelMostrarDet.Controls.Add(this.txtSubTotalD);
            this.panelMostrarDet.Controls.Add(this.label4);
            this.panelMostrarDet.Controls.Add(this.dgvMostrarDetalle);
            this.panelMostrarDet.Controls.Add(this.btnCerrarDetalleventa);
            this.panelMostrarDet.Location = new System.Drawing.Point(90, 143);
            this.panelMostrarDet.Name = "panelMostrarDet";
            this.panelMostrarDet.Size = new System.Drawing.Size(575, 308);
            this.panelMostrarDet.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Total";
            // 
            // txtTotalImpID
            // 
            this.txtTotalImpID.Location = new System.Drawing.Point(419, 244);
            this.txtTotalImpID.Name = "txtTotalImpID";
            this.txtTotalImpID.Size = new System.Drawing.Size(124, 20);
            this.txtTotalImpID.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Impuesto";
            // 
            // txtSubTotalD
            // 
            this.txtSubTotalD.Location = new System.Drawing.Point(419, 218);
            this.txtSubTotalD.Name = "txtSubTotalD";
            this.txtSubTotalD.Size = new System.Drawing.Size(124, 20);
            this.txtSubTotalD.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "SubTotal";
            // 
            // dgvMostrarDetalle
            // 
            this.dgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDetalle.Location = new System.Drawing.Point(30, 45);
            this.dgvMostrarDetalle.Name = "dgvMostrarDetalle";
            this.dgvMostrarDetalle.Size = new System.Drawing.Size(513, 162);
            this.dgvMostrarDetalle.TabIndex = 42;
            // 
            // btnCerrarDetalleventa
            // 
            this.btnCerrarDetalleventa.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarDetalleventa.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarDetalleventa.Location = new System.Drawing.Point(515, 16);
            this.btnCerrarDetalleventa.Name = "btnCerrarDetalleventa";
            this.btnCerrarDetalleventa.Size = new System.Drawing.Size(28, 23);
            this.btnCerrarDetalleventa.TabIndex = 41;
            this.btnCerrarDetalleventa.Text = "X";
            this.btnCerrarDetalleventa.UseVisualStyleBackColor = false;
            this.btnCerrarDetalleventa.Click += new System.EventHandler(this.btnCerrarDetalleventa_Click);
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(227, 86);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(257, 20);
            this.txtVenta.TabIndex = 14;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(86, 82);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(105, 24);
            this.lblVentas.TabIndex = 13;
            this.lblVentas.Text = "VENTAS: ";
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(529, 80);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(60, 32);
            this.btnAnular.TabIndex = 12;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(48, 129);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(637, 260);
            this.dgvVenta.TabIndex = 2;
            this.dgvVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento de ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.panelArticulos);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtTotalIgv);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvDetalle);
            this.groupBox2.Controls.Add(this.btnVerProductos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.btninsertar);
            this.groupBox2.Location = new System.Drawing.Point(18, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 325);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // panelArticulos
            // 
            this.panelArticulos.BackColor = System.Drawing.Color.Bisque;
            this.panelArticulos.Controls.Add(this.btnCerrararticulo);
            this.panelArticulos.Controls.Add(this.dgvArticulos);
            this.panelArticulos.Controls.Add(this.btnFiltrarProductos);
            this.panelArticulos.Controls.Add(this.label11);
            this.panelArticulos.Controls.Add(this.txtBuscararticulos);
            this.panelArticulos.Location = new System.Drawing.Point(54, 40);
            this.panelArticulos.Name = "panelArticulos";
            this.panelArticulos.Size = new System.Drawing.Size(578, 193);
            this.panelArticulos.TabIndex = 42;
            // 
            // btnCerrararticulo
            // 
            this.btnCerrararticulo.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrararticulo.ForeColor = System.Drawing.Color.Red;
            this.btnCerrararticulo.Location = new System.Drawing.Point(522, 11);
            this.btnCerrararticulo.Name = "btnCerrararticulo";
            this.btnCerrararticulo.Size = new System.Drawing.Size(28, 23);
            this.btnCerrararticulo.TabIndex = 40;
            this.btnCerrararticulo.Text = "X";
            this.btnCerrararticulo.UseVisualStyleBackColor = false;
            this.btnCerrararticulo.Click += new System.EventHandler(this.btnCerrararticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(14, 41);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(548, 133);
            this.dgvArticulos.TabIndex = 39;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // btnFiltrarProductos
            // 
            this.btnFiltrarProductos.BackColor = System.Drawing.Color.LightGray;
            this.btnFiltrarProductos.Location = new System.Drawing.Point(325, 11);
            this.btnFiltrarProductos.Name = "btnFiltrarProductos";
            this.btnFiltrarProductos.Size = new System.Drawing.Size(65, 23);
            this.btnFiltrarProductos.TabIndex = 38;
            this.btnFiltrarProductos.Text = "Buscar";
            this.btnFiltrarProductos.UseVisualStyleBackColor = false;
            this.btnFiltrarProductos.Click += new System.EventHandler(this.btnFiltrararticulos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "BUSCAR:";
            // 
            // txtBuscararticulos
            // 
            this.txtBuscararticulos.Location = new System.Drawing.Point(114, 14);
            this.txtBuscararticulos.Name = "txtBuscararticulos";
            this.txtBuscararticulos.Size = new System.Drawing.Size(165, 20);
            this.txtBuscararticulos.TabIndex = 36;
            this.txtBuscararticulos.TextChanged += new System.EventHandler(this.txtBuscararticulos_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(490, 292);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(156, 20);
            this.txtTotal.TabIndex = 41;
            // 
            // txtTotalIgv
            // 
            this.txtTotalIgv.Location = new System.Drawing.Point(512, 262);
            this.txtTotalIgv.Name = "txtTotalIgv";
            this.txtTotalIgv.Size = new System.Drawing.Size(134, 20);
            this.txtTotalIgv.TabIndex = 40;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(500, 236);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(146, 20);
            this.txtSubTotal.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sub Total: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Total: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total IGV%: ";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(39, 54);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(621, 174);
            this.dgvDetalle.TabIndex = 35;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.BackColor = System.Drawing.Color.LightGray;
            this.btnVerProductos.Location = new System.Drawing.Point(364, 25);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(75, 23);
            this.btnVerProductos.TabIndex = 34;
            this.btnVerProductos.Text = "Ver";
            this.btnVerProductos.UseVisualStyleBackColor = false;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Productos";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(149, 279);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 33);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(218, 20);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(52, 279);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(91, 33);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.txtSerieComprob);
            this.groupBox1.Controls.Add(this.txtNumeroComprob);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.cboComprobante);
            this.groupBox1.Controls.Add(this.txtNombreClient);
            this.groupBox1.Controls.Add(this.txtIDCliene);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 127);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // txtSerieComprob
            // 
            this.txtSerieComprob.Location = new System.Drawing.Point(405, 80);
            this.txtSerieComprob.Name = "txtSerieComprob";
            this.txtSerieComprob.Size = new System.Drawing.Size(100, 20);
            this.txtSerieComprob.TabIndex = 33;
            // 
            // txtNumeroComprob
            // 
            this.txtNumeroComprob.Location = new System.Drawing.Point(276, 81);
            this.txtNumeroComprob.Name = "txtNumeroComprob";
            this.txtNumeroComprob.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroComprob.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Comprobante";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(600, 80);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(74, 20);
            this.txtIGV.TabIndex = 24;
            this.txtIGV.Text = "0.18%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "IGV(*)";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarCliente.Location = new System.Drawing.Point(600, 37);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 22;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cboComprobante
            // 
            this.cboComprobante.FormattingEnabled = true;
            this.cboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA",
            "TICKET"});
            this.cboComprobante.Location = new System.Drawing.Point(128, 81);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(120, 21);
            this.cboComprobante.TabIndex = 21;
            // 
            // txtNombreClient
            // 
            this.txtNombreClient.Enabled = false;
            this.txtNombreClient.Location = new System.Drawing.Point(276, 39);
            this.txtNombreClient.Name = "txtNombreClient";
            this.txtNombreClient.Size = new System.Drawing.Size(318, 20);
            this.txtNombreClient.TabIndex = 20;
            // 
            // txtIDCliene
            // 
            this.txtIDCliene.Enabled = false;
            this.txtIDCliene.Location = new System.Drawing.Point(111, 40);
            this.txtIDCliene.Name = "txtIDCliene";
            this.txtIDCliene.Size = new System.Drawing.Size(137, 20);
            this.txtIDCliene.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cliente(*)";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 563);
            this.Controls.Add(this.tabVentas);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.tabVentas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelMostrarDet.ResumeLayout(false);
            this.panelMostrarDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelArticulos.ResumeLayout(false);
            this.panelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelArticulos;
        private System.Windows.Forms.Button btnCerrararticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnFiltrarProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscararticulos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalIgv;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSerieComprob;
        private System.Windows.Forms.TextBox txtNumeroComprob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox cboComprobante;
        private System.Windows.Forms.TextBox txtNombreClient;
        private System.Windows.Forms.TextBox txtIDCliene;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMostrarDet;
        private System.Windows.Forms.TextBox txtTotalImpID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSubTotalD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMostrarDetalle;
        private System.Windows.Forms.Button btnCerrarDetalleventa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider erroricono;
    }
}