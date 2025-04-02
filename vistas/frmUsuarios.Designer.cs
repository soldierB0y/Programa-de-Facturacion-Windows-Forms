namespace programaFacturacion.vistas
{
    partial class frmUsuarios
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
            tbxUsuario = new TextBox();
            label2 = new Label();
            tbxClave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            cbbEmpleado = new ComboBox();
            label6 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cbbPuesto = new ComboBox();
            panel2 = new Panel();
            dgvUsuarios = new DataGridView();
            label7 = new Label();
            tbxBuscador = new TextBox();
            cbbCriterio = new ComboBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "usuario";
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(147, 17);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(185, 23);
            tbxUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 50);
            label2.TabIndex = 3;
            label2.Text = "Usuarios";
            // 
            // tbxClave
            // 
            tbxClave.Location = new Point(147, 65);
            tbxClave.Name = "tbxClave";
            tbxClave.PasswordChar = '*';
            tbxClave.Size = new Size(185, 23);
            tbxClave.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "puesto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 77);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 8;
            label5.Text = "Manejo de usuarios";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbEmpleado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cbbPuesto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbxUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxClave);
            panel1.Location = new Point(6, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 286);
            panel1.TabIndex = 9;
            // 
            // cbbEmpleado
            // 
            cbbEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbEmpleado.FormattingEnabled = true;
            cbbEmpleado.Location = new Point(147, 147);
            cbbEmpleado.Name = "cbbEmpleado";
            cbbEmpleado.Size = new Size(185, 23);
            cbbEmpleado.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 150);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 14;
            label6.Text = "vincular con empleado";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(172, 231);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 46);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(12, 231);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 46);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(172, 187);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 44);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 187);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 44);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbbPuesto
            // 
            cbbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPuesto.FormattingEnabled = true;
            cbbPuesto.Location = new Point(147, 110);
            cbbPuesto.Name = "cbbPuesto";
            cbbPuesto.Size = new Size(185, 23);
            cbbPuesto.TabIndex = 7;
            cbbPuesto.SelectedIndexChanged += cbbPuesto_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(354, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 286);
            panel2.TabIndex = 16;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(428, 280);
            dgvUsuarios.TabIndex = 18;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 72);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 17;
            label7.Text = "buscador";
            // 
            // tbxBuscador
            // 
            tbxBuscador.Location = new Point(419, 69);
            tbxBuscador.Name = "tbxBuscador";
            tbxBuscador.Size = new Size(149, 23);
            tbxBuscador.TabIndex = 16;
            tbxBuscador.TextChanged += tbxBuscador_TextChanged;
            // 
            // cbbCriterio
            // 
            cbbCriterio.AutoCompleteCustomSource.AddRange(new string[] { "IDUsuario", "IDEmpleado", "nombre", "clave" });
            cbbCriterio.FormattingEnabled = true;
            cbbCriterio.Location = new Point(624, 69);
            cbbCriterio.Name = "cbbCriterio";
            cbbCriterio.Size = new Size(161, 23);
            cbbCriterio.TabIndex = 16;
            cbbCriterio.SelectedIndexChanged += cbbCriterio_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 72);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 18;
            label8.Text = "criterio";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(cbbCriterio);
            Controls.Add(tbxBuscador);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label2);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxUsuario;
        private Label label2;
        private TextBox tbxClave;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private ComboBox cbbPuesto;
        private ComboBox cbbEmpleado;
        private Label label6;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnModificar;
        private Button btnAgregar;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private Label label7;
        private TextBox tbxBuscador;
        private ComboBox cbbCriterio;
        private Label label8;
    }
}