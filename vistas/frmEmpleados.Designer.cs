namespace programaFacturacion.vistas
{
    partial class frmEmpleados
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
            panel2 = new Panel();
            cbbCriterio = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            tbxBuscador = new TextBox();
            dgvEmpleados = new DataGridView();
            panel1 = new Panel();
            cbbTipoLicencia = new ComboBox();
            lbTipoLicencia = new Label();
            tbxNumeroLicencia = new TextBox();
            lbNumeroLicencia = new Label();
            cbbPosicion = new ComboBox();
            dtpFechaSalida = new DateTimePicker();
            dtpFechaEntrada = new DateTimePicker();
            label15 = new Label();
            lbUbicacionArchivo = new Label();
            btnExaminar = new Button();
            label9 = new Label();
            pbxEmpleado = new PictureBox();
            cbxSexo = new ComboBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            label10 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            label11 = new Label();
            tbxNombre = new TextBox();
            tbxSalario = new TextBox();
            label2 = new Label();
            tbxCedulaRNC = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            tbxCorreo = new TextBox();
            label7 = new Label();
            tbxTelefono = new TextBox();
            tbxDireccion = new TextBox();
            label6 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEmpleado).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbCriterio);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(tbxBuscador);
            panel2.Controls.Add(dgvEmpleados);
            panel2.Location = new Point(38, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 352);
            panel2.TabIndex = 53;
            // 
            // cbbCriterio
            // 
            cbbCriterio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCriterio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCriterio.FormattingEnabled = true;
            cbbCriterio.Items.AddRange(new object[] { "nombreRepresentante", "cedula", "correo", "telefono", "tipo de Empleado" });
            cbbCriterio.Location = new Point(393, 17);
            cbbCriterio.Name = "cbbCriterio";
            cbbCriterio.Size = new Size(227, 23);
            cbbCriterio.TabIndex = 27;
            cbbCriterio.SelectedIndexChanged += cbbCriterio_SelectedIndexChanged;
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
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.Location = new Point(19, 46);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1070, 237);
            dgvEmpleados.TabIndex = 25;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbTipoLicencia);
            panel1.Controls.Add(lbTipoLicencia);
            panel1.Controls.Add(tbxNumeroLicencia);
            panel1.Controls.Add(lbNumeroLicencia);
            panel1.Controls.Add(cbbPosicion);
            panel1.Controls.Add(dtpFechaSalida);
            panel1.Controls.Add(dtpFechaEntrada);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(lbUbicacionArchivo);
            panel1.Controls.Add(btnExaminar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pbxEmpleado);
            panel1.Controls.Add(cbxSexo);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(tbxSalario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxCedulaRNC);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxCorreo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbxTelefono);
            panel1.Controls.Add(tbxDireccion);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(38, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 278);
            panel1.TabIndex = 52;
            panel1.Paint += panel1_Paint;
            // 
            // cbbTipoLicencia
            // 
            cbbTipoLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoLicencia.FormattingEnabled = true;
            cbbTipoLicencia.Items.AddRange(new object[] { "", "Categoria 1", "Categoria 2", "Categoria 3" });
            cbbTipoLicencia.Location = new Point(687, 221);
            cbbTipoLicencia.Name = "cbbTipoLicencia";
            cbbTipoLicencia.Size = new Size(224, 23);
            cbbTipoLicencia.TabIndex = 61;
            cbbTipoLicencia.Visible = false;
            // 
            // lbTipoLicencia
            // 
            lbTipoLicencia.AutoSize = true;
            lbTipoLicencia.Location = new Point(590, 224);
            lbTipoLicencia.Name = "lbTipoLicencia";
            lbTipoLicencia.Size = new Size(71, 15);
            lbTipoLicencia.TabIndex = 60;
            lbTipoLicencia.Text = "tipo licencia";
            lbTipoLicencia.Visible = false;
            // 
            // tbxNumeroLicencia
            // 
            tbxNumeroLicencia.Location = new Point(335, 221);
            tbxNumeroLicencia.Name = "tbxNumeroLicencia";
            tbxNumeroLicencia.Size = new Size(224, 23);
            tbxNumeroLicencia.TabIndex = 57;
            tbxNumeroLicencia.Visible = false;
            // 
            // lbNumeroLicencia
            // 
            lbNumeroLicencia.AutoSize = true;
            lbNumeroLicencia.Location = new Point(238, 224);
            lbNumeroLicencia.Name = "lbNumeroLicencia";
            lbNumeroLicencia.Size = new Size(92, 15);
            lbNumeroLicencia.TabIndex = 58;
            lbNumeroLicencia.Text = "numero licencia";
            lbNumeroLicencia.Visible = false;
            // 
            // cbbPosicion
            // 
            cbbPosicion.AutoCompleteCustomSource.AddRange(new string[] { "", "chofer", "facturacion" });
            cbbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPosicion.FormattingEnabled = true;
            cbbPosicion.Items.AddRange(new object[] { "administrador", "facturador", "chofer" });
            cbbPosicion.Location = new Point(688, 29);
            cbbPosicion.Name = "cbbPosicion";
            cbbPosicion.Size = new Size(223, 23);
            cbbPosicion.TabIndex = 56;
            cbbPosicion.SelectedIndexChanged += cbbPosicion_SelectedIndexChanged;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(688, 187);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(224, 23);
            dtpFechaSalida.TabIndex = 55;
            // 
            // dtpFechaEntrada
            // 
            dtpFechaEntrada.Location = new Point(335, 184);
            dtpFechaEntrada.Name = "dtpFechaEntrada";
            dtpFechaEntrada.Size = new Size(224, 23);
            dtpFechaEntrada.TabIndex = 54;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(238, 187);
            label15.Name = "label15";
            label15.Size = new Size(95, 15);
            label15.TabIndex = 53;
            label15.Text = "fecha de Entrada";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(590, 32);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 49;
            label9.Text = "posicion";
            // 
            // pbxEmpleado
            // 
            pbxEmpleado.Location = new Point(3, 29);
            pbxEmpleado.Name = "pbxEmpleado";
            pbxEmpleado.Size = new Size(205, 173);
            pbxEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxEmpleado.TabIndex = 46;
            pbxEmpleado.TabStop = false;
            // 
            // cbxSexo
            // 
            cbxSexo.CausesValidation = false;
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "", "M", "F" });
            cbxSexo.Location = new Point(335, 66);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(224, 23);
            cbxSexo.TabIndex = 47;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(965, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 52);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(965, 72);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 52);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(591, 190);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 45;
            label10.Text = "fecha Salida";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(965, 131);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 52);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(965, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 52);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(592, 150);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 43;
            label11.Text = "salario";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(335, 29);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(224, 23);
            tbxNombre.TabIndex = 27;
            // 
            // tbxSalario
            // 
            tbxSalario.Location = new Point(688, 147);
            tbxSalario.Name = "tbxSalario";
            tbxSalario.Size = new Size(224, 23);
            tbxSalario.TabIndex = 42;
            tbxSalario.TextChanged += tbxSalario_TextChanged;
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
            // tbxCedulaRNC
            // 
            tbxCedulaRNC.Location = new Point(335, 107);
            tbxCedulaRNC.Name = "tbxCedulaRNC";
            tbxCedulaRNC.Size = new Size(224, 23);
            tbxCedulaRNC.TabIndex = 29;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 106);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 39;
            label8.Text = "correo";
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
            // tbxCorreo
            // 
            tbxCorreo.Location = new Point(687, 103);
            tbxCorreo.Name = "tbxCorreo";
            tbxCorreo.Size = new Size(224, 23);
            tbxCorreo.TabIndex = 38;
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
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(335, 147);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(224, 23);
            tbxDireccion.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 150);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 35;
            label6.Text = "direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(212, 50);
            label1.TabIndex = 51;
            label1.Text = "Empleados";
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private ComboBox cbbCriterio;
        private Label label14;
        private Label label13;
        private TextBox tbxBuscador;
        private DataGridView dgvEmpleados;
        private Panel panel1;
        private TextBox tbxRNC;
        private Label label15;
        private Label lbUbicacionArchivo;
        private Button btnExaminar;
        private ComboBox cbxTipoCliente;
        private Label label9;
        private PictureBox pbxEmpleado;
        private ComboBox cbxSexo;
        private Button btnAgregar;
        private Button btnModificar;
        private Label label10;
        private Button btnLimpiar;
        private TextBox tbxLimiteCredito;
        private Button btnEliminar;
        private Label label11;
        private TextBox tbxNombre;
        private TextBox tbxSalario;
        private Label label2;
        private TextBox tbxCedulaRNC;
        private Label label3;
        private Label label8;
        private Label label4;
        private TextBox tbxCorreo;
        private Label label7;
        private TextBox tbxTelefono;
        private TextBox tbxDireccion;
        private Label label6;
        private Label label1;
        private DateTimePicker dtpFechaSalida;
        private DateTimePicker dtpFechaEntrada;
        private ComboBox cbbPosicion;
        private Label lbTipoLicencia;
        private TextBox tbxNumeroLicencia;
        private Label lbNumeroLicencia;
        private ComboBox cbbTipoLicencia;
    }
}