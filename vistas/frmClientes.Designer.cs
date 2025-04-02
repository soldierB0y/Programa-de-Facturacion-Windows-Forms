namespace programaFacturacion.vistas
{
    partial class frmClientes
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
            label1 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            tbxNombre = new TextBox();
            label3 = new Label();
            tbxCedulaRNC = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbxEmpresa = new TextBox();
            label6 = new Label();
            tbxDireccion = new TextBox();
            label7 = new Label();
            tbxTelefono = new TextBox();
            label8 = new Label();
            tbxCorreo = new TextBox();
            label10 = new Label();
            tbxLimiteCredito = new TextBox();
            label11 = new Label();
            tbxDeuda = new TextBox();
            label12 = new Label();
            tbxBalance = new TextBox();
            pbFotoCliente = new PictureBox();
            cbxSexo = new ComboBox();
            panel1 = new Panel();
            tbxRNC = new TextBox();
            label15 = new Label();
            lbUbicacionArchivo = new Label();
            btnExaminar = new Button();
            cbxTipoCliente = new ComboBox();
            label9 = new Label();
            panel2 = new Panel();
            cbxBuscadorTipoCliente = new ComboBox();
            cbxCriterio = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            tbxBuscador = new TextBox();
            dgvClientes = new DataGridView();
            btnFacturas = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFotoCliente).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(159, 50);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1014, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 52);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1014, 131);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 52);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1014, 72);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 52);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1014, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 52);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 32);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 28;
            label2.Text = "nombre";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(335, 29);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(224, 23);
            tbxNombre.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 69);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 30;
            label3.Text = "sexo";
            // 
            // tbxCedulaRNC
            // 
            tbxCedulaRNC.Location = new Point(335, 107);
            tbxCedulaRNC.Name = "tbxCedulaRNC";
            tbxCedulaRNC.Size = new Size(224, 23);
            tbxCedulaRNC.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 110);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 31;
            label4.Text = "cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 150);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 33;
            label5.Text = "empresa";
            // 
            // tbxEmpresa
            // 
            tbxEmpresa.Location = new Point(335, 147);
            tbxEmpresa.Name = "tbxEmpresa";
            tbxEmpresa.Size = new Size(224, 23);
            tbxEmpresa.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 187);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 35;
            label6.Text = "direccion";
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(335, 184);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(224, 23);
            tbxDireccion.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 66);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 37;
            label7.Text = "telefono";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(688, 63);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(224, 23);
            tbxTelefono.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 106);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 39;
            label8.Text = "correo";
            // 
            // tbxCorreo
            // 
            tbxCorreo.Location = new Point(687, 103);
            tbxCorreo.Name = "tbxCorreo";
            tbxCorreo.Size = new Size(224, 23);
            tbxCorreo.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(591, 227);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 45;
            label10.Text = "limiteCredito";
            // 
            // tbxLimiteCredito
            // 
            tbxLimiteCredito.Location = new Point(688, 224);
            tbxLimiteCredito.Name = "tbxLimiteCredito";
            tbxLimiteCredito.Size = new Size(224, 23);
            tbxLimiteCredito.TabIndex = 44;
            tbxLimiteCredito.TextChanged += tbxLimiteCredito_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(592, 187);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 43;
            label11.Text = "deuda";
            // 
            // tbxDeuda
            // 
            tbxDeuda.Location = new Point(688, 184);
            tbxDeuda.Name = "tbxDeuda";
            tbxDeuda.Size = new Size(224, 23);
            tbxDeuda.TabIndex = 42;
            tbxDeuda.TextChanged += tbxDeuda_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(591, 146);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 41;
            label12.Text = "balance";
            // 
            // tbxBalance
            // 
            tbxBalance.Location = new Point(688, 143);
            tbxBalance.Name = "tbxBalance";
            tbxBalance.Size = new Size(224, 23);
            tbxBalance.TabIndex = 40;
            tbxBalance.TextChanged += tbxBalance_TextChanged;
            // 
            // pbFotoCliente
            // 
            pbFotoCliente.Image = Properties.Resources.persona;
            pbFotoCliente.Location = new Point(3, 29);
            pbFotoCliente.Name = "pbFotoCliente";
            pbFotoCliente.Size = new Size(205, 173);
            pbFotoCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoCliente.TabIndex = 46;
            pbFotoCliente.TabStop = false;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "M", "F" });
            cbxSexo.Location = new Point(335, 66);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(224, 23);
            cbxSexo.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxRNC);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(lbUbicacionArchivo);
            panel1.Controls.Add(btnExaminar);
            panel1.Controls.Add(cbxTipoCliente);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pbFotoCliente);
            panel1.Controls.Add(cbxSexo);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(tbxLimiteCredito);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(tbxDeuda);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(tbxCedulaRNC);
            panel1.Controls.Add(tbxBalance);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxCorreo);
            panel1.Controls.Add(tbxEmpresa);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbxTelefono);
            panel1.Controls.Add(tbxDireccion);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(26, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 257);
            panel1.TabIndex = 48;
            panel1.Paint += panel1_Paint;
            // 
            // tbxRNC
            // 
            tbxRNC.Location = new Point(335, 221);
            tbxRNC.Name = "tbxRNC";
            tbxRNC.Size = new Size(224, 23);
            tbxRNC.TabIndex = 54;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(238, 224);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 53;
            label15.Text = "RNC";
            // 
            // lbUbicacionArchivo
            // 
            lbUbicacionArchivo.AutoSize = true;
            lbUbicacionArchivo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUbicacionArchivo.Location = new Point(3, 231);
            lbUbicacionArchivo.Name = "lbUbicacionArchivo";
            lbUbicacionArchivo.Size = new Size(51, 13);
            lbUbicacionArchivo.TabIndex = 52;
            lbUbicacionArchivo.Text = "ninguna";
            lbUbicacionArchivo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(3, 204);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(205, 24);
            btnExaminar.TabIndex = 51;
            btnExaminar.Text = "Examinar ";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Items.AddRange(new object[] { "bajo", "medio", "alto", "top" });
            cbxTipoCliente.Location = new Point(687, 29);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(224, 23);
            cbxTipoCliente.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(590, 32);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 49;
            label9.Text = "tipo de cliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxBuscadorTipoCliente);
            panel2.Controls.Add(cbxCriterio);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(tbxBuscador);
            panel2.Controls.Add(dgvClientes);
            panel2.Location = new Point(26, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 297);
            panel2.TabIndex = 49;
            panel2.Paint += panel2_Paint;
            // 
            // cbxBuscadorTipoCliente
            // 
            cbxBuscadorTipoCliente.FormattingEnabled = true;
            cbxBuscadorTipoCliente.Items.AddRange(new object[] { "bajo", "medio", "alto", "top" });
            cbxBuscadorTipoCliente.Location = new Point(93, 17);
            cbxBuscadorTipoCliente.Name = "cbxBuscadorTipoCliente";
            cbxBuscadorTipoCliente.Size = new Size(224, 23);
            cbxBuscadorTipoCliente.TabIndex = 28;
            cbxBuscadorTipoCliente.Visible = false;
            cbxBuscadorTipoCliente.SelectedIndexChanged += cbxBuscadorTipoCliente_SelectedIndexChanged;
            // 
            // cbxCriterio
            // 
            cbxCriterio.FormattingEnabled = true;
            cbxCriterio.Items.AddRange(new object[] { "nombreRepresentante", "empresa", "cedula", "correo", "telefono", "tipoCliente" });
            cbxCriterio.Location = new Point(393, 17);
            cbxCriterio.Name = "cbxCriterio";
            cbxCriterio.Size = new Size(227, 23);
            cbxCriterio.TabIndex = 27;
            cbxCriterio.SelectedIndexChanged += cbxCriterio_SelectedIndexChanged;
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
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Location = new Point(19, 46);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1070, 248);
            dgvClientes.TabIndex = 25;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(812, 50);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(125, 41);
            btnFacturas.TabIndex = 50;
            btnFacturas.Text = "cotizaciones";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 749);
            Controls.Add(btnFacturas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoCliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label2;
        private TextBox tbxNombre;
        private Label label3;
        private TextBox tbxCedulaRNC;
        private Label label4;
        private Label label5;
        private TextBox tbxEmpresa;
        private Label label6;
        private TextBox tbxDireccion;
        private Label label7;
        private TextBox tbxTelefono;
        private Label label8;
        private TextBox tbxCorreo;
        private Label label10;
        private TextBox tbxLimiteCredito;
        private Label label11;
        private TextBox tbxDeuda;
        private Label label12;
        private TextBox tbxBalance;
        private PictureBox pbFotoCliente;
        private ComboBox cbxSexo;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cbxCriterio;
        private Label label14;
        private Label label13;
        private TextBox tbxBuscador;
        private DataGridView dgvClientes;
        private Label label9;
        private ComboBox cbxTipoCliente;
        private Button btnExaminar;
        private Label lbUbicacionArchivo;
        private ComboBox cbxBuscadorTipoCliente;
        private TextBox tbxRNC;
        private Label label15;
        private Button btnFacturas;
    }
}