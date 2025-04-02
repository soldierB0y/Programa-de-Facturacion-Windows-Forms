namespace programaFacturacion.vistas
{
    partial class frmCamiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCamiones));
            label1 = new Label();
            panel1 = new Panel();
            cbbPropietario = new ComboBox();
            label7 = new Label();
            cbbColor = new ComboBox();
            cbbModelo = new ComboBox();
            cbbMarca = new ComboBox();
            tbxMetraje = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            cbxActivo = new CheckBox();
            dtpFechaAdquisicion = new DateTimePicker();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbxMatricula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvCamiones = new DataGridView();
            cbbCriterio = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            tbxBuscador = new TextBox();
            cbbBuscador = new ComboBox();
            button1 = new Button();
            btnExaminar = new Button();
            lbUbicacionArchivo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCamiones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(191, 50);
            label1.TabIndex = 1;
            label1.Text = "Camiones";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbPropietario);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbbColor);
            panel1.Controls.Add(cbbModelo);
            panel1.Controls.Add(cbbMarca);
            panel1.Controls.Add(tbxMetraje);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(cbxActivo);
            panel1.Controls.Add(dtpFechaAdquisicion);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxMatricula);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(314, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 234);
            panel1.TabIndex = 2;
            // 
            // cbbPropietario
            // 
            cbbPropietario.AutoCompleteCustomSource.AddRange(new string[] { "", "Empresa", "Cliente", "Empleado" });
            cbbPropietario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPropietario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbPropietario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPropietario.FormattingEnabled = true;
            cbbPropietario.Items.AddRange(new object[] { "Empresa", "Empleado", "Cliente", "Otro" });
            cbbPropietario.Location = new Point(428, 104);
            cbbPropietario.Name = "cbbPropietario";
            cbbPropietario.Size = new Size(207, 23);
            cbbPropietario.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(323, 107);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 37;
            label7.Text = "propietario";
            // 
            // cbbColor
            // 
            cbbColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbColor.FormattingEnabled = true;
            cbbColor.Location = new Point(82, 137);
            cbbColor.Name = "cbbColor";
            cbbColor.Size = new Size(207, 23);
            cbbColor.TabIndex = 36;
            // 
            // cbbModelo
            // 
            cbbModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbModelo.FormattingEnabled = true;
            cbbModelo.Location = new Point(82, 71);
            cbbModelo.Name = "cbbModelo";
            cbbModelo.Size = new Size(207, 23);
            cbbModelo.TabIndex = 35;
            // 
            // cbbMarca
            // 
            cbbMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbMarca.FormattingEnabled = true;
            cbbMarca.Location = new Point(82, 39);
            cbbMarca.Name = "cbbMarca";
            cbbMarca.Size = new Size(207, 23);
            cbbMarca.TabIndex = 34;
            // 
            // tbxMetraje
            // 
            tbxMetraje.Location = new Point(428, 39);
            tbxMetraje.Name = "tbxMetraje";
            tbxMetraje.Size = new Size(207, 23);
            tbxMetraje.TabIndex = 33;
            tbxMetraje.TextChanged += tbxMetraje_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(728, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 52);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(728, 64);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 52);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(728, 122);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 52);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(728, 180);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 52);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbxActivo
            // 
            cbxActivo.AutoSize = true;
            cbxActivo.Location = new Point(428, 139);
            cbxActivo.Name = "cbxActivo";
            cbxActivo.Size = new Size(60, 19);
            cbxActivo.TabIndex = 26;
            cbxActivo.Text = "Activo";
            cbxActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaAdquisicion
            // 
            dtpFechaAdquisicion.Location = new Point(428, 71);
            dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            dtpFechaAdquisicion.Size = new Size(207, 23);
            dtpFechaAdquisicion.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 74);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 20;
            label8.Text = "fecha adquisicion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 42);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 12;
            label6.Text = "metraje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 43);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 140);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "color";
            // 
            // tbxMatricula
            // 
            tbxMatricula.Location = new Point(82, 104);
            tbxMatricula.Name = "tbxMatricula";
            tbxMatricula.Size = new Size(207, 23);
            tbxMatricula.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 107);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "modelo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dgvCamiones
            // 
            dgvCamiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCamiones.Location = new Point(12, 351);
            dgvCamiones.Name = "dgvCamiones";
            dgvCamiones.ReadOnly = true;
            dgvCamiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCamiones.Size = new Size(1135, 333);
            dgvCamiones.TabIndex = 33;
            dgvCamiones.CellClick += dgvCamiones_CellClick;
            // 
            // cbbCriterio
            // 
            cbbCriterio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCriterio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCriterio.FormattingEnabled = true;
            cbbCriterio.Items.AddRange(new object[] { "modelo", "placa", "color", "marca", "propietario" });
            cbbCriterio.Location = new Point(386, 321);
            cbbCriterio.Name = "cbbCriterio";
            cbbCriterio.Size = new Size(227, 23);
            cbbCriterio.TabIndex = 37;
            cbbCriterio.SelectedIndexChanged += cbbCriterio_SelectedIndexChanged;
            cbbCriterio.TextChanged += cbbCriterio_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(336, 324);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 36;
            label14.Text = "criterio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 324);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 34;
            label13.Text = "buscador";
            // 
            // tbxBuscador
            // 
            tbxBuscador.Location = new Point(86, 321);
            tbxBuscador.Name = "tbxBuscador";
            tbxBuscador.Size = new Size(224, 23);
            tbxBuscador.TabIndex = 35;
            tbxBuscador.TextChanged += tbxBuscador_TextChanged;
            // 
            // cbbBuscador
            // 
            cbbBuscador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbBuscador.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbBuscador.FormattingEnabled = true;
            cbbBuscador.Location = new Point(86, 321);
            cbbBuscador.Name = "cbbBuscador";
            cbbBuscador.Size = new Size(224, 23);
            cbbBuscador.TabIndex = 38;
            cbbBuscador.SelectedIndexChanged += cbbBuscador_SelectedIndexChanged;
            cbbBuscador.TextChanged += cbbBuscador_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(810, 15);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 39;
            button1.Text = "combustible";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(71, 238);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(205, 24);
            btnExaminar.TabIndex = 52;
            btnExaminar.Text = "Examinar ";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // lbUbicacionArchivo
            // 
            lbUbicacionArchivo.AutoSize = true;
            lbUbicacionArchivo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUbicacionArchivo.Location = new Point(71, 265);
            lbUbicacionArchivo.Name = "lbUbicacionArchivo";
            lbUbicacionArchivo.Size = new Size(51, 13);
            lbUbicacionArchivo.TabIndex = 53;
            lbUbicacionArchivo.Text = "ninguna";
            lbUbicacionArchivo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCamiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 749);
            Controls.Add(lbUbicacionArchivo);
            Controls.Add(btnExaminar);
            Controls.Add(button1);
            Controls.Add(cbbBuscador);
            Controls.Add(cbbCriterio);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(tbxBuscador);
            Controls.Add(dgvCamiones);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmCamiones";
            Text = "Camiones";
            Load += frmCamiones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCamiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private TextBox tbxMatricula;
        private Label label3;
        private Label label6;
        private Label label5;
        private CheckBox cbxActivo;
        private DateTimePicker dtpFechaAdquisicion;
        private Label label8;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dgvCamiones;
        private ComboBox cbxBuscadorTipoCliente;
        private ComboBox cbbCriterio;
        private Label label14;
        private Label label13;
        private TextBox tbxBuscador;
        private TextBox tbxMetraje;
        private ComboBox cbbColor;
        private ComboBox cbbModelo;
        private ComboBox cbbMarca;
        private ComboBox cbbPropietario;
        private Label label7;
        private ComboBox cbbBuscador;
        private Button button1;
        private Button btnExaminar;
        private Label lbUbicacionArchivo;
    }
}