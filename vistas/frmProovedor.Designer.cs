namespace programaFacturacion.vistas
{
    partial class frmProovedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProovedor));
            label1 = new Label();
            panel1 = new Panel();
            pbFotoCliente = new PictureBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            tbxNombre = new TextBox();
            label2 = new Label();
            tbxCedulaRNC = new TextBox();
            label8 = new Label();
            label4 = new Label();
            tbxCorreo = new TextBox();
            label7 = new Label();
            tbxTelefono = new TextBox();
            tbxEmpresa = new TextBox();
            label6 = new Label();
            cbxCriterio = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            tbxBuscador = new TextBox();
            dgvProovedor = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProovedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 50);
            label1.TabIndex = 2;
            label1.Text = "Proovedor";
            // 
            // panel1
            // 
            panel1.Controls.Add(pbFotoCliente);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(tbxNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxCedulaRNC);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxCorreo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbxTelefono);
            panel1.Controls.Add(tbxEmpresa);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 257);
            panel1.TabIndex = 49;
            // 
            // pbFotoCliente
            // 
            pbFotoCliente.Image = (Image)resources.GetObject("pbFotoCliente.Image");
            pbFotoCliente.Location = new Point(3, 32);
            pbFotoCliente.Name = "pbFotoCliente";
            pbFotoCliente.Size = new Size(229, 196);
            pbFotoCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoCliente.TabIndex = 46;
            pbFotoCliente.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(239, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 52);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(417, 176);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(142, 52);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(588, 176);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 52);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(751, 176);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 52);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(335, 29);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(224, 23);
            tbxNombre.TabIndex = 27;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(573, 32);
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
            tbxCorreo.Location = new Point(669, 29);
            tbxCorreo.Name = "tbxCorreo";
            tbxCorreo.Size = new Size(224, 23);
            tbxCorreo.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 75);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 37;
            label7.Text = "telefono";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(335, 72);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(224, 23);
            tbxTelefono.TabIndex = 36;
            // 
            // tbxEmpresa
            // 
            tbxEmpresa.Location = new Point(669, 70);
            tbxEmpresa.Name = "tbxEmpresa";
            tbxEmpresa.Size = new Size(224, 23);
            tbxEmpresa.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(572, 73);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 35;
            label6.Text = "empresa";
            // 
            // cbxCriterio
            // 
            cbxCriterio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCriterio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxCriterio.FormattingEnabled = true;
            cbxCriterio.Items.AddRange(new object[] { "nombreRepresentante", "empresa", "cedula", "correo", "telefono", "tipoCliente" });
            cbxCriterio.Location = new Point(389, 350);
            cbxCriterio.Name = "cbxCriterio";
            cbxCriterio.Size = new Size(227, 23);
            cbxCriterio.TabIndex = 54;
            cbxCriterio.SelectedIndexChanged += cbxCriterio_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(339, 353);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 53;
            label14.Text = "criterio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 353);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 50;
            label13.Text = "buscador";
            // 
            // tbxBuscador
            // 
            tbxBuscador.Location = new Point(89, 350);
            tbxBuscador.Name = "tbxBuscador";
            tbxBuscador.Size = new Size(224, 23);
            tbxBuscador.TabIndex = 51;
            tbxBuscador.TextChanged += tbxBuscador_TextChanged;
            // 
            // dgvProovedor
            // 
            dgvProovedor.AllowUserToAddRows = false;
            dgvProovedor.AllowUserToDeleteRows = false;
            dgvProovedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProovedor.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvProovedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProovedor.Location = new Point(15, 379);
            dgvProovedor.Name = "dgvProovedor";
            dgvProovedor.ReadOnly = true;
            dgvProovedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProovedor.Size = new Size(919, 248);
            dgvProovedor.TabIndex = 52;
            dgvProovedor.CellClick += dgvProovedor_CellClick;
            // 
            // frmProovedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 642);
            Controls.Add(cbxCriterio);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(tbxBuscador);
            Controls.Add(dgvProovedor);
            Controls.Add(panel1);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(961, 681);
            MinimizeBox = false;
            MinimumSize = new Size(961, 681);
            Name = "frmProovedor";
            Text = "frmProovedor";
            Load += frmProovedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProovedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox tbxRNC;
        private Label label15;
        private ComboBox cbxTipoCliente;
        private Label label9;
        private PictureBox pbFotoCliente;
        private ComboBox cbxSexo;
        private Button btnAgregar;
        private Button btnModificar;
        private Label label10;
        private Button btnLimpiar;
        private TextBox tbxLimiteCredito;
        private Button btnEliminar;
        private Label label11;
        private TextBox tbxNombre;
        private TextBox tbxDeuda;
        private Label label2;
        private Label label12;
        private TextBox tbxCedulaRNC;
        private TextBox tbxBalance;
        private Label label3;
        private Label label8;
        private Label label4;
        private TextBox tbxCorreo;
        private TextBox tbxEmpresa;
        private Label label7;
        private Label label5;
        private TextBox tbxTelefono;
        private Label label6;
        private ComboBox cbxCriterio;
        private Label label14;
        private Label label13;
        private TextBox tbxBuscador;
        private DataGridView dgvProovedor;
    }
}