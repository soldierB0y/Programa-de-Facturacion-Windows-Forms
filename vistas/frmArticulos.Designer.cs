namespace programaFacturacion
{
    partial class frmArticulos
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
            label1 = new Label();
            tbxNombre = new TextBox();
            panel1 = new Panel();
            lbUbicacionArchivo = new Label();
            cbxMarca = new ComboBox();
            cbxProovedor = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            tbxUnidadMedida = new TextBox();
            label15 = new Label();
            btnBuscarImagen = new Button();
            cbxEstado = new CheckBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cbxFacturarSinInventario = new CheckBox();
            cbxPrecioModificable = new CheckBox();
            label12 = new Label();
            tbxInventario = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            tbxPrecioMinimo = new TextBox();
            tbxPrecioVenta = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbxPrecioCompra = new TextBox();
            tbxDescripcion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbxCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            cbbCriterio = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            tbxBuscador = new TextBox();
            dgvArticulos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 0;
            label1.Text = "Articulos";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(133, 32);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(224, 23);
            tbxNombre.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbUbicacionArchivo);
            panel1.Controls.Add(cbxMarca);
            panel1.Controls.Add(cbxProovedor);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(tbxUnidadMedida);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnBuscarImagen);
            panel1.Controls.Add(cbxEstado);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cbxFacturarSinInventario);
            panel1.Controls.Add(cbxPrecioModificable);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(tbxInventario);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbxPrecioMinimo);
            panel1.Controls.Add(tbxPrecioVenta);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbxPrecioCompra);
            panel1.Controls.Add(tbxDescripcion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbxCodigo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxNombre);
            panel1.Location = new Point(26, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 277);
            panel1.TabIndex = 2;
            // 
            // lbUbicacionArchivo
            // 
            lbUbicacionArchivo.AutoSize = true;
            lbUbicacionArchivo.Location = new Point(133, 143);
            lbUbicacionArchivo.Name = "lbUbicacionArchivo";
            lbUbicacionArchivo.Size = new Size(54, 15);
            lbUbicacionArchivo.TabIndex = 31;
            lbUbicacionArchivo.Text = "Ninguno";
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(816, 38);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(160, 23);
            cbxMarca.TabIndex = 30;
            cbxMarca.SelectedIndexChanged += cbxMarca_SelectedIndexChanged;
            // 
            // cbxProovedor
            // 
            cbxProovedor.FormattingEnabled = true;
            cbxProovedor.Location = new Point(816, 78);
            cbxProovedor.Name = "cbxProovedor";
            cbxProovedor.Size = new Size(160, 23);
            cbxProovedor.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(748, 81);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 29;
            label16.Text = "proovedor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(748, 40);
            label17.Name = "label17";
            label17.Size = new Size(40, 15);
            label17.TabIndex = 27;
            label17.Text = "marca";
            // 
            // tbxUnidadMedida
            // 
            tbxUnidadMedida.Location = new Point(511, 247);
            tbxUnidadMedida.Name = "tbxUnidadMedida";
            tbxUnidadMedida.Size = new Size(224, 23);
            tbxUnidadMedida.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(383, 250);
            label15.Name = "label15";
            label15.Size = new Size(106, 15);
            label15.TabIndex = 25;
            label15.Text = "unidad de medida:";
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(133, 116);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(224, 23);
            btnBuscarImagen.TabIndex = 24;
            btnBuscarImagen.Text = "examinar";
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // cbxEstado
            // 
            cbxEstado.AutoSize = true;
            cbxEstado.Location = new Point(511, 129);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(15, 14);
            cbxEstado.TabIndex = 23;
            cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1019, 209);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 52);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1019, 150);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 52);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1019, 91);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 52);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1019, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 52);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // cbxFacturarSinInventario
            // 
            cbxFacturarSinInventario.AutoSize = true;
            cbxFacturarSinInventario.Location = new Point(511, 171);
            cbxFacturarSinInventario.Name = "cbxFacturarSinInventario";
            cbxFacturarSinInventario.Size = new Size(67, 19);
            cbxFacturarSinInventario.TabIndex = 18;
            cbxFacturarSinInventario.Text = "facturar";
            cbxFacturarSinInventario.UseVisualStyleBackColor = true;
            cbxFacturarSinInventario.CheckedChanged += cbxFacturarSinInventario_CheckedChanged;
            // 
            // cbxPrecioModificable
            // 
            cbxPrecioModificable.AutoSize = true;
            cbxPrecioModificable.Location = new Point(511, 38);
            cbxPrecioModificable.Name = "cbxPrecioModificable";
            cbxPrecioModificable.Size = new Size(58, 19);
            cbxPrecioModificable.TabIndex = 17;
            cbxPrecioModificable.Text = "activo";
            cbxPrecioModificable.UseVisualStyleBackColor = true;
            cbxPrecioModificable.CheckedChanged += cbxPrecioModificable_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(383, 172);
            label12.Name = "label12";
            label12.Size = new Size(122, 15);
            label12.TabIndex = 16;
            label12.Text = "facturar sin inventario";
            // 
            // tbxInventario
            // 
            tbxInventario.Location = new Point(511, 212);
            tbxInventario.Name = "tbxInventario";
            tbxInventario.ReadOnly = true;
            tbxInventario.Size = new Size(224, 23);
            tbxInventario.TabIndex = 8;
            tbxInventario.TextChanged += tbxInventario_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 37);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 15;
            label8.Text = "precio modificable";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(383, 212);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 7;
            label10.Text = "inventario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 81);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 14;
            label9.Text = "precio minimo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 128);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 6;
            label11.Text = "estado";
            // 
            // tbxPrecioMinimo
            // 
            tbxPrecioMinimo.Location = new Point(511, 81);
            tbxPrecioMinimo.Name = "tbxPrecioMinimo";
            tbxPrecioMinimo.ReadOnly = true;
            tbxPrecioMinimo.Size = new Size(224, 23);
            tbxPrecioMinimo.TabIndex = 13;
            // 
            // tbxPrecioVenta
            // 
            tbxPrecioVenta.Location = new Point(133, 245);
            tbxPrecioVenta.Name = "tbxPrecioVenta";
            tbxPrecioVenta.Size = new Size(224, 23);
            tbxPrecioVenta.TabIndex = 12;
            tbxPrecioVenta.TextChanged += tbxPrecioVenta_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 248);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 11;
            label6.Text = "precio venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 207);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 10;
            label7.Text = "precio compra";
            // 
            // tbxPrecioCompra
            // 
            tbxPrecioCompra.Location = new Point(133, 204);
            tbxPrecioCompra.Name = "tbxPrecioCompra";
            tbxPrecioCompra.Size = new Size(224, 23);
            tbxPrecioCompra.TabIndex = 9;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(133, 161);
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(224, 23);
            tbxDescripcion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 164);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 123);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "imagen";
            // 
            // tbxCodigo
            // 
            tbxCodigo.Location = new Point(133, 73);
            tbxCodigo.Name = "tbxCodigo";
            tbxCodigo.Size = new Size(224, 23);
            tbxCodigo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 76);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "nombre";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbCriterio);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(tbxBuscador);
            panel2.Controls.Add(dgvArticulos);
            panel2.Location = new Point(26, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 297);
            panel2.TabIndex = 3;
            // 
            // cbbCriterio
            // 
            cbbCriterio.FormattingEnabled = true;
            cbbCriterio.Items.AddRange(new object[] { "nombre", "codigo", "descripcion" });
            cbbCriterio.Location = new Point(393, 17);
            cbbCriterio.Name = "cbbCriterio";
            cbbCriterio.Size = new Size(227, 23);
            cbbCriterio.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(343, 20);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 26;
            label14.Text = "criterio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 20);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 24;
            label13.Text = "buscador";
            // 
            // tbxBuscador
            // 
            tbxBuscador.Location = new Point(93, 17);
            tbxBuscador.Name = "tbxBuscador";
            tbxBuscador.Size = new Size(224, 23);
            tbxBuscador.TabIndex = 24;
            tbxBuscador.TextChanged += tbxBuscador_TextChanged;
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvArticulos.Location = new Point(19, 46);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(1060, 248);
            dgvArticulos.TabIndex = 25;
            dgvArticulos.CellClick += dgvArticulos_CellClick;
            dgvArticulos.CellContentClick += dgvArticulos_CellContentClick;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1159, 692);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmArticulos";
            Text = "Articulos";
            Load += frmArticulos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNombre;
        private Panel panel1;
        private Label label2;
        private TextBox tbxInventario;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private TextBox tbxPrecioMinimo;
        private TextBox tbxPrecioVenta;
        private Label label6;
        private Label label7;
        private TextBox tbxPrecioCompra;
        private TextBox tbxDescripcion;
        private Label label4;
        private Label label5;
        private TextBox tbxCodigo;
        private Label label3;
        private Label label12;
        private CheckBox cbxEstado;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private CheckBox cbxFacturarSinInventario;
        private CheckBox cbxPrecioModificable;
        private Panel panel2;
        private Label label13;
        private TextBox tbxBuscador;
        private DataGridView dgvArticulos;
        private Button btnBuscarImagen;
        private ComboBox cbbCriterio;
        private Label label14;
        private TextBox tbxUnidadMedida;
        private Label label15;
        private ComboBox cbxMarca;
        private ComboBox cbxProovedor;
        private Label label16;
        private Label label17;
        private Label lbUbicacionArchivo;
    }
}
