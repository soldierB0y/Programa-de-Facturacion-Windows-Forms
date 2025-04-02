namespace programaFacturacion
{
    partial class FrmCotizacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnModificar = new Button();
            btnAgregarArticulos = new Button();
            cbxImprimirA4 = new CheckBox();
            cbxImprimir = new CheckBox();
            label10 = new Label();
            tbxTransporte = new TextBox();
            btnCotizar = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            tbxSubtotal = new TextBox();
            tbxITBIS = new TextBox();
            tbxTotal = new TextBox();
            tbxDescuento = new TextBox();
            btnEliminar = new Button();
            label8 = new Label();
            tbxCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvArticulosDetalle = new DataGridView();
            dgvArticulos = new DataGridView();
            btnAgregar = new Button();
            tbxPrecio = new TextBox();
            tbxCantidadArticulos = new TextBox();
            tbxArticulos = new TextBox();
            tbxBuscadorArticulos = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label1 = new Label();
            label50000 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            tbxTelefono = new TextBox();
            tbxTipoCliente = new TextBox();
            tbxDireccion = new TextBox();
            btnVerClientes = new Button();
            cbbCliente = new ComboBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulosDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregarArticulos);
            panel1.Controls.Add(cbxImprimirA4);
            panel1.Controls.Add(cbxImprimir);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(tbxTransporte);
            panel1.Controls.Add(btnCotizar);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbxSubtotal);
            panel1.Controls.Add(tbxITBIS);
            panel1.Controls.Add(tbxTotal);
            panel1.Controls.Add(tbxDescuento);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbxCodigo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvArticulosDetalle);
            panel1.Controls.Add(dgvArticulos);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(tbxPrecio);
            panel1.Controls.Add(tbxCantidadArticulos);
            panel1.Controls.Add(tbxArticulos);
            panel1.Controls.Add(tbxBuscadorArticulos);
            panel1.Location = new Point(88, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 529);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(674, 401);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(154, 37);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregarArticulos
            // 
            btnAgregarArticulos.Location = new Point(295, 34);
            btnAgregarArticulos.Name = "btnAgregarArticulos";
            btnAgregarArticulos.Size = new Size(25, 23);
            btnAgregarArticulos.TabIndex = 27;
            btnAgregarArticulos.Text = "+";
            btnAgregarArticulos.UseVisualStyleBackColor = true;
            btnAgregarArticulos.Click += btnAgregarArticulos_Click;
            // 
            // cbxImprimirA4
            // 
            cbxImprimirA4.AutoSize = true;
            cbxImprimirA4.Location = new Point(901, 451);
            cbxImprimirA4.Name = "cbxImprimirA4";
            cbxImprimirA4.Size = new Size(89, 19);
            cbxImprimirA4.TabIndex = 26;
            cbxImprimirA4.Text = "imprimir A4";
            cbxImprimirA4.UseVisualStyleBackColor = true;
            // 
            // cbxImprimir
            // 
            cbxImprimir.AutoSize = true;
            cbxImprimir.Location = new Point(810, 451);
            cbxImprimir.Name = "cbxImprimir";
            cbxImprimir.Size = new Size(72, 19);
            cbxImprimir.TabIndex = 25;
            cbxImprimir.Text = "imprimir";
            cbxImprimir.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(304, 430);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 24;
            label10.Text = "Transporte";
            // 
            // tbxTransporte
            // 
            tbxTransporte.Location = new Point(304, 404);
            tbxTransporte.Name = "tbxTransporte";
            tbxTransporte.Size = new Size(97, 23);
            tbxTransporte.TabIndex = 23;
            tbxTransporte.TextChanged += tbxTransporte_TextChanged;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(834, 401);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(154, 37);
            btnCotizar.TabIndex = 22;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(520, 474);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 21;
            label14.Text = "Descuento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(628, 474);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 20;
            label13.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(412, 475);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 19;
            label12.Text = "ITBIS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(304, 475);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 18;
            label11.Text = "Subtotal";
            // 
            // tbxSubtotal
            // 
            tbxSubtotal.Location = new Point(304, 449);
            tbxSubtotal.Name = "tbxSubtotal";
            tbxSubtotal.ReadOnly = true;
            tbxSubtotal.Size = new Size(102, 23);
            tbxSubtotal.TabIndex = 17;
            // 
            // tbxITBIS
            // 
            tbxITBIS.Location = new Point(412, 449);
            tbxITBIS.Name = "tbxITBIS";
            tbxITBIS.ReadOnly = true;
            tbxITBIS.Size = new Size(102, 23);
            tbxITBIS.TabIndex = 16;
            // 
            // tbxTotal
            // 
            tbxTotal.Location = new Point(628, 449);
            tbxTotal.Name = "tbxTotal";
            tbxTotal.ReadOnly = true;
            tbxTotal.Size = new Size(102, 23);
            tbxTotal.TabIndex = 15;
            // 
            // tbxDescuento
            // 
            tbxDescuento.Location = new Point(520, 449);
            tbxDescuento.Name = "tbxDescuento";
            tbxDescuento.ReadOnly = true;
            tbxDescuento.Size = new Size(102, 23);
            tbxDescuento.TabIndex = 14;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(951, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 20);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 12;
            label8.Text = "codigo";
            // 
            // tbxCodigo
            // 
            tbxCodigo.Location = new Point(326, 37);
            tbxCodigo.Name = "tbxCodigo";
            tbxCodigo.Size = new Size(164, 23);
            tbxCodigo.TabIndex = 11;
            tbxCodigo.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(752, 19);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(699, 19);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 19);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "articulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 15);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "buscador";
            // 
            // dgvArticulosDetalle
            // 
            dgvArticulosDetalle.AllowUserToAddRows = false;
            dgvArticulosDetalle.AllowUserToDeleteRows = false;
            dgvArticulosDetalle.AllowUserToResizeColumns = false;
            dgvArticulosDetalle.AllowUserToResizeRows = false;
            dgvArticulosDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticulosDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulosDetalle.Location = new Point(304, 66);
            dgvArticulosDetalle.Name = "dgvArticulosDetalle";
            dgvArticulosDetalle.ReadOnly = true;
            dgvArticulosDetalle.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvArticulosDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulosDetalle.Size = new Size(684, 332);
            dgvArticulosDetalle.TabIndex = 6;
            dgvArticulosDetalle.CellClick += dgvArticulosDetalle_CellClick;
            dgvArticulosDetalle.CellContentClick += dgvArticulosDetalle_CellContentClick;
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvArticulos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(17, 66);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(272, 332);
            dgvArticulos.TabIndex = 5;
            dgvArticulos.CellClick += dgvArticulos_CellClick;
            dgvArticulos.CellContentClick += dgvArticulos_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(872, 35);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(73, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // tbxPrecio
            // 
            tbxPrecio.Location = new Point(758, 36);
            tbxPrecio.Name = "tbxPrecio";
            tbxPrecio.Size = new Size(91, 23);
            tbxPrecio.TabIndex = 3;
            tbxPrecio.TextChanged += tbxPrecio_TextChanged;
            // 
            // tbxCantidadArticulos
            // 
            tbxCantidadArticulos.Location = new Point(699, 37);
            tbxCantidadArticulos.Name = "tbxCantidadArticulos";
            tbxCantidadArticulos.Size = new Size(53, 23);
            tbxCantidadArticulos.TabIndex = 2;
            // 
            // tbxArticulos
            // 
            tbxArticulos.Location = new Point(496, 37);
            tbxArticulos.Name = "tbxArticulos";
            tbxArticulos.ReadOnly = true;
            tbxArticulos.Size = new Size(197, 23);
            tbxArticulos.TabIndex = 1;
            // 
            // tbxBuscadorArticulos
            // 
            tbxBuscadorArticulos.Location = new Point(17, 34);
            tbxBuscadorArticulos.Name = "tbxBuscadorArticulos";
            tbxBuscadorArticulos.Size = new Size(272, 23);
            tbxBuscadorArticulos.TabIndex = 0;
            tbxBuscadorArticulos.TextChanged += tbxBuscadorArticulos_TextChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += imprimirCotizacion;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 35);
            label1.Name = "label1";
            label1.Size = new Size(205, 50);
            label1.TabIndex = 1;
            label1.Text = "Cotizacion";
            // 
            // label50000
            // 
            label50000.AutoSize = true;
            label50000.Location = new Point(17, 16);
            label50000.Name = "label50000";
            label50000.Size = new Size(106, 15);
            label50000.TabIndex = 11;
            label50000.Text = "nombre del cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 65);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "tipo de cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 13);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 65);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 14;
            label9.Text = "direccion";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(466, 10);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(191, 23);
            tbxTelefono.TabIndex = 15;
            // 
            // tbxTipoCliente
            // 
            tbxTipoCliente.Location = new Point(129, 62);
            tbxTipoCliente.Name = "tbxTipoCliente";
            tbxTipoCliente.ReadOnly = true;
            tbxTipoCliente.Size = new Size(191, 23);
            tbxTipoCliente.TabIndex = 16;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(466, 62);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(191, 23);
            tbxDireccion.TabIndex = 17;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Location = new Point(698, 27);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(152, 43);
            btnVerClientes.TabIndex = 14;
            btnVerClientes.Text = "Manejo de Clientes";
            btnVerClientes.UseVisualStyleBackColor = true;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // cbbCliente
            // 
            cbbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCliente.FlatStyle = FlatStyle.Popup;
            cbbCliente.FormattingEnabled = true;
            cbbCliente.Location = new Point(129, 13);
            cbbCliente.Name = "cbbCliente";
            cbbCliente.Size = new Size(191, 23);
            cbbCliente.TabIndex = 18;
            cbbCliente.SelectedIndexChanged += cbbCliente_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbCliente);
            panel2.Controls.Add(btnVerClientes);
            panel2.Controls.Add(tbxDireccion);
            panel2.Controls.Add(tbxTipoCliente);
            panel2.Controls.Add(tbxTelefono);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label50000);
            panel2.Location = new Point(88, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 100);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // FrmCotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 692);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmCotizacion";
            Text = "Cotizacion";
            Load += FrmCotizacion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulosDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAgregar;
        private TextBox tbxPrecio;
        private TextBox tbxCantidadArticulos;
        private TextBox tbxArticulos;
        private TextBox tbxBuscadorArticulos;
        public DataGridView dgvArticulosDetalle;
        private DataGridView dgvArticulos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private TextBox tbxCodigo;
        private Button btnEliminar;
        public TextBox tbxSubtotal;
        public TextBox tbxITBIS;
        public TextBox tbxTotal;
        public TextBox tbxDescuento;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnCotizar;
        private Label label10;
        public TextBox tbxTransporte;
        private CheckBox cbxImprimirA4;
        private CheckBox cbxImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnAgregarArticulos;
        private Button btnModificar;
        private Label label1;
        private Label label50000;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox tbxTelefono;
        private TextBox tbxTipoCliente;
        private TextBox tbxDireccion;
        private Button btnVerClientes;
        public ComboBox cbbCliente;
        private Panel panel2;
    }
}
