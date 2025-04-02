namespace programaFacturacion.vistas
{
    partial class frmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tbxOtrosDatos = new TextBox();
            label4 = new Label();
            tbxDescripcion = new TextBox();
            label3 = new Label();
            tbxNombre = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            tbxBuscador = new TextBox();
            dgvMarcas = new DataGridView();
            label5 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 50);
            label1.TabIndex = 2;
            label1.Text = "Marcas";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxOtrosDatos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxDescripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(211, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 372);
            panel1.TabIndex = 3;
            // 
            // tbxOtrosDatos
            // 
            tbxOtrosDatos.Location = new Point(85, 155);
            tbxOtrosDatos.Multiline = true;
            tbxOtrosDatos.Name = "tbxOtrosDatos";
            tbxOtrosDatos.Size = new Size(193, 90);
            tbxOtrosDatos.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 155);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "otros datos";
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(87, 48);
            tbxDescripcion.Multiline = true;
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(193, 90);
            tbxDescripcion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 51);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "descripcion";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(87, 12);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(193, 23);
            tbxNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "nombre";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbxBuscador);
            panel2.Controls.Add(dgvMarcas);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(513, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 372);
            panel2.TabIndex = 0;
            // 
            // tbxBuscador
            // 
            tbxBuscador.Location = new Point(68, 12);
            tbxBuscador.Name = "tbxBuscador";
            tbxBuscador.Size = new Size(197, 23);
            tbxBuscador.TabIndex = 11;
            tbxBuscador.TextChanged += tbxBuscador_TextChanged;
            // 
            // dgvMarcas
            // 
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(6, 41);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(456, 200);
            dgvMarcas.TabIndex = 10;
            dgvMarcas.CellClick += dgvMarcas_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 15);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "buscador";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 240);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(111, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(12, 279);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 28);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(111, 240);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 33);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 326);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(1014, 365);
            MinimizeBox = false;
            MinimumSize = new Size(1014, 365);
            Name = "frmMarca";
            Text = "Marcas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbxOtrosDatos;
        private Label label4;
        private TextBox tbxDescripcion;
        private Label label3;
        private TextBox tbxNombre;
        private Label label2;
        private TextBox tbxBuscador;
        private DataGridView dgvMarcas;
        private Label label5;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
    }
}