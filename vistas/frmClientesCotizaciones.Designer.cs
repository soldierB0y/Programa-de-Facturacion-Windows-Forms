namespace programaFacturacion.vistas
{
    partial class frmClientesCotizaciones
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
            cbbClientes = new ComboBox();
            pbxCliente = new PictureBox();
            dgvCotizacion = new DataGridView();
            dgvCotizacionDetalle = new DataGridView();
            label1 = new Label();
            btnModificarCotizacion = new Button();
            btnEliminarCotizacoin = new Button();
            button1 = new Button();
            btnImprimir = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pbxCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCotizacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCotizacionDetalle).BeginInit();
            SuspendLayout();
            // 
            // cbbClientes
            // 
            cbbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbClientes.FormattingEnabled = true;
            cbbClientes.Items.AddRange(new object[] { "" });
            cbbClientes.Location = new Point(38, 251);
            cbbClientes.Name = "cbbClientes";
            cbbClientes.Size = new Size(224, 23);
            cbbClientes.TabIndex = 0;
            cbbClientes.SelectedIndexChanged += cbbClientes_SelectedIndexChanged;
            cbbClientes.TextChanged += cbbClientes_TextChanged;
            // 
            // pbxCliente
            // 
            pbxCliente.Location = new Point(38, 65);
            pbxCliente.Name = "pbxCliente";
            pbxCliente.Size = new Size(224, 180);
            pbxCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCliente.TabIndex = 1;
            pbxCliente.TabStop = false;
            // 
            // dgvCotizacion
            // 
            dgvCotizacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCotizacion.Location = new Point(295, 65);
            dgvCotizacion.Name = "dgvCotizacion";
            dgvCotizacion.ReadOnly = true;
            dgvCotizacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizacion.Size = new Size(769, 223);
            dgvCotizacion.TabIndex = 2;
            dgvCotizacion.CellClick += dgvCotizacion_CellClick;
            dgvCotizacion.CellContentClick += dgvCotizacion_CellContentClick;
            // 
            // dgvCotizacionDetalle
            // 
            dgvCotizacionDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCotizacionDetalle.Location = new Point(295, 350);
            dgvCotizacionDetalle.Name = "dgvCotizacionDetalle";
            dgvCotizacionDetalle.ReadOnly = true;
            dgvCotizacionDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizacionDetalle.Size = new Size(769, 215);
            dgvCotizacionDetalle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 50);
            label1.TabIndex = 4;
            label1.Text = "Cotizaciones de Clientes";
            // 
            // btnModificarCotizacion
            // 
            btnModificarCotizacion.Location = new Point(491, 305);
            btnModificarCotizacion.Name = "btnModificarCotizacion";
            btnModificarCotizacion.Size = new Size(195, 28);
            btnModificarCotizacion.TabIndex = 5;
            btnModificarCotizacion.Text = "modificar cotizaciones";
            btnModificarCotizacion.UseVisualStyleBackColor = true;
            btnModificarCotizacion.Click += btnModificarCotizacion_Click;
            // 
            // btnEliminarCotizacoin
            // 
            btnEliminarCotizacoin.Location = new Point(692, 305);
            btnEliminarCotizacoin.Name = "btnEliminarCotizacoin";
            btnEliminarCotizacoin.Size = new Size(183, 28);
            btnEliminarCotizacoin.TabIndex = 6;
            btnEliminarCotizacoin.Text = "eliminar cotizaciones";
            btnEliminarCotizacoin.UseVisualStyleBackColor = true;
            btnEliminarCotizacoin.Click += btnEliminarCotizacoin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(295, 305);
            button1.Name = "button1";
            button1.Size = new Size(190, 28);
            button1.TabIndex = 7;
            button1.Text = "crear cotizaciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(881, 305);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(183, 28);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // frmClientesCotizaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 749);
            Controls.Add(btnImprimir);
            Controls.Add(button1);
            Controls.Add(btnEliminarCotizacoin);
            Controls.Add(btnModificarCotizacion);
            Controls.Add(label1);
            Controls.Add(dgvCotizacionDetalle);
            Controls.Add(dgvCotizacion);
            Controls.Add(pbxCliente);
            Controls.Add(cbbClientes);
            Name = "frmClientesCotizaciones";
            Text = "Cotizaciones de Clientes";
            Load += frmClientesCotizaciones_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCotizacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCotizacionDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbClientes;
        private PictureBox pbxCliente;
        private DataGridView dgvCotizacion;
        private DataGridView dgvCotizacionDetalle;
        private Label label1;
        private Button btnModificarCotizacion;
        private Button btnEliminarCotizacoin;
        private Button button1;
        private Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}