namespace programaFacturacion.vistas
{
    partial class frmClientesFacturacion
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
            btnImprimir = new Button();
            button1 = new Button();
            btnEliminarCotizacoin = new Button();
            btnModificarCotizacion = new Button();
            dgvFacturasDetalle = new DataGridView();
            dgvFacturas = new DataGridView();
            pbxCliente = new PictureBox();
            cbbClientes = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFacturasDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCliente).BeginInit();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(800, 329);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(248, 28);
            btnImprimir.TabIndex = 25;
            btnImprimir.Text = "imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(279, 329);
            button1.Name = "button1";
            button1.Size = new Size(247, 28);
            button1.TabIndex = 24;
            button1.Text = "crear facturas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminarCotizacoin
            // 
            btnEliminarCotizacoin.Location = new Point(541, 329);
            btnEliminarCotizacoin.Name = "btnEliminarCotizacoin";
            btnEliminarCotizacoin.Size = new Size(247, 28);
            btnEliminarCotizacoin.TabIndex = 23;
            btnEliminarCotizacoin.Text = "eliminar facturas";
            btnEliminarCotizacoin.UseVisualStyleBackColor = true;
            btnEliminarCotizacoin.Click += btnEliminarCotizacoin_Click;
            // 
            // btnModificarCotizacion
            // 
            btnModificarCotizacion.Location = new Point(475, 329);
            btnModificarCotizacion.Name = "btnModificarCotizacion";
            btnModificarCotizacion.Size = new Size(195, 28);
            btnModificarCotizacion.TabIndex = 22;
            btnModificarCotizacion.Text = "modificar facturas";
            btnModificarCotizacion.UseVisualStyleBackColor = true;
            btnModificarCotizacion.Visible = false;
            btnModificarCotizacion.Click += btnModificarCotizacion_Click;
            // 
            // dgvFacturasDetalle
            // 
            dgvFacturasDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturasDetalle.Location = new Point(279, 363);
            dgvFacturasDetalle.Name = "dgvFacturasDetalle";
            dgvFacturasDetalle.ReadOnly = true;
            dgvFacturasDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturasDetalle.Size = new Size(769, 261);
            dgvFacturasDetalle.TabIndex = 21;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(279, 62);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(769, 261);
            dgvFacturas.TabIndex = 20;
            dgvFacturas.CellClick += dgvFacturas_CellClick;
            // 
            // pbxCliente
            // 
            pbxCliente.Image = Properties.Resources.persona;
            pbxCliente.Location = new Point(22, 62);
            pbxCliente.Name = "pbxCliente";
            pbxCliente.Size = new Size(224, 180);
            pbxCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCliente.TabIndex = 19;
            pbxCliente.TabStop = false;
            // 
            // cbbClientes
            // 
            cbbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbClientes.FormattingEnabled = true;
            cbbClientes.Items.AddRange(new object[] { "" });
            cbbClientes.Location = new Point(22, 248);
            cbbClientes.Name = "cbbClientes";
            cbbClientes.Size = new Size(224, 23);
            cbbClientes.TabIndex = 18;
            cbbClientes.SelectedIndexChanged += cbbClientes_SelectedIndexChanged;
            cbbClientes.TextChanged += cbbClientes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 50);
            label1.TabIndex = 17;
            label1.Text = "Facturas de Clientes";
            // 
            // frmClientesFacturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 739);
            Controls.Add(btnImprimir);
            Controls.Add(button1);
            Controls.Add(btnEliminarCotizacoin);
            Controls.Add(btnModificarCotizacion);
            Controls.Add(dgvFacturasDetalle);
            Controls.Add(dgvFacturas);
            Controls.Add(pbxCliente);
            Controls.Add(cbbClientes);
            Controls.Add(label1);
            Name = "frmClientesFacturacion";
            Text = "frmClientesFacturacion";
            Load += frmClientesFacturacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturasDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Button button1;
        private Button btnEliminarCotizacoin;
        private Button btnModificarCotizacion;
        private DataGridView dgvFacturasDetalle;
        private DataGridView dgvFacturas;
        private PictureBox pbxCliente;
        private ComboBox cbbClientes;
        private Label label1;
    }
}