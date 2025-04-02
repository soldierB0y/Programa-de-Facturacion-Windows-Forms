namespace programaFacturacion.vistas
{
    partial class frmCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombustible));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbxGalones = new TextBox();
            tbxGasto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            panel1 = new Panel();
            label9 = new Label();
            tbxNotas = new TextBox();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            btnEliminar = new Button();
            label2 = new Label();
            cbbCamion = new ComboBox();
            cbbChofer = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            cbbCriterio = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            tbxBuscador = new TextBox();
            dgvRegistros = new DataGridView();
            label7 = new Label();
            dgvCamiones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCamiones).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 50);
            label1.TabIndex = 1;
            label1.Text = "Combustible";
            // 
            // tbxGalones
            // 
            tbxGalones.Location = new Point(70, 230);
            tbxGalones.Name = "tbxGalones";
            tbxGalones.Size = new Size(222, 23);
            tbxGalones.TabIndex = 3;
            // 
            // tbxGasto
            // 
            tbxGasto.Location = new Point(70, 262);
            tbxGasto.Name = "tbxGasto";
            tbxGasto.Size = new Size(222, 23);
            tbxGasto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 265);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "gasto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 233);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "galones";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(70, 442);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(222, 26);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbxNotas);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbbCamion);
            panel1.Controls.Add(tbxGalones);
            panel1.Controls.Add(cbbChofer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxGasto);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(2, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 511);
            panel1.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 326);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 15;
            label9.Text = "notas";
            // 
            // tbxNotas
            // 
            tbxNotas.Location = new Point(70, 323);
            tbxNotas.Multiline = true;
            tbxNotas.Name = "tbxNotas";
            tbxNotas.Size = new Size(222, 113);
            tbxNotas.TabIndex = 14;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(70, 294);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(222, 23);
            dtpFecha.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 300);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "fecha";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(70, 472);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(222, 26);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 167);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "chofer";
            // 
            // cbbCamion
            // 
            cbbCamion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCamion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCamion.FormattingEnabled = true;
            cbbCamion.Location = new Point(70, 196);
            cbbCamion.Name = "cbbCamion";
            cbbCamion.Size = new Size(222, 23);
            cbbCamion.TabIndex = 9;
            cbbCamion.SelectedIndexChanged += cbbCamion_SelectedIndexChanged;
            // 
            // cbbChofer
            // 
            cbbChofer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbChofer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbChofer.FormattingEnabled = true;
            cbbChofer.Location = new Point(70, 164);
            cbbChofer.Name = "cbbChofer";
            cbbChofer.Size = new Size(222, 23);
            cbbChofer.TabIndex = 8;
            cbbChofer.SelectedIndexChanged += cbbChofer_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 199);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "camion";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbCriterio);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tbxBuscador);
            panel2.Controls.Add(dgvRegistros);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dgvCamiones);
            panel2.Location = new Point(313, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 511);
            panel2.TabIndex = 12;
            // 
            // cbbCriterio
            // 
            cbbCriterio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCriterio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCriterio.FormattingEnabled = true;
            cbbCriterio.Items.AddRange(new object[] { "modelo", "placa", "color", "marca" });
            cbbCriterio.Location = new Point(294, 16);
            cbbCriterio.Name = "cbbCriterio";
            cbbCriterio.Size = new Size(190, 23);
            cbbCriterio.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(244, 19);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 20;
            label10.Text = "criterio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 270);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 18;
            label8.Text = "Registros";
            // 
            // tbxBuscador
            // 
            tbxBuscador.Location = new Point(60, 16);
            tbxBuscador.Name = "tbxBuscador";
            tbxBuscador.Size = new Size(178, 23);
            tbxBuscador.TabIndex = 19;
            tbxBuscador.TextChanged += tbxBuscador_TextChanged;
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(5, 286);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(479, 222);
            dgvRegistros.TabIndex = 17;
            dgvRegistros.CellClick += dgvRegistros_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 19);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 16;
            label7.Text = "buscador";
            // 
            // dgvCamiones
            // 
            dgvCamiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCamiones.Location = new Point(1, 45);
            dgvCamiones.Name = "dgvCamiones";
            dgvCamiones.ReadOnly = true;
            dgvCamiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCamiones.Size = new Size(483, 222);
            dgvCamiones.TabIndex = 0;
            dgvCamiones.CellClick += dgvCamiones_CellClick;
            // 
            // frmCombustible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 576);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmCombustible";
            Text = "Combustible";
            Load += frmCombustible_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCamiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbxGalones;
        private TextBox tbxGasto;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCamiones;
        private Label label2;
        private ComboBox cbbCamion;
        private ComboBox cbbChofer;
        private Label label3;
        private Label label7;
        private Label label8;
        private DataGridView dgvRegistros;
        private Button btnEliminar;
        private DateTimePicker dtpFecha;
        private Label label6;
        private Label label9;
        private TextBox tbxNotas;
        private ComboBox cbbCriterio;
        private Label label10;
        private TextBox tbxBuscador;
    }
}