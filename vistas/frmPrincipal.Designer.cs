namespace programaFacturacion.vistas
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            articulosToolStripMenuItem = new ToolStripMenuItem();
            cotizacionesToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            camionesToolStripMenuItem = new ToolStripMenuItem();
            proovedorToolStripMenuItem = new ToolStripMenuItem();
            marcaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Crimson;
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, articulosToolStripMenuItem, cotizacionesToolStripMenuItem, empleadosToolStripMenuItem, facturasToolStripMenuItem, camionesToolStripMenuItem, proovedorToolStripMenuItem, marcaToolStripMenuItem, toolStripMenuItem1, usuariosToolStripMenuItem, inventarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.ForeColor = Color.White;
            clientesToolStripMenuItem.MergeAction = MergeAction.MatchOnly;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(98, 34);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            clientesToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            clientesToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            clientesToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(106, 34);
            articulosToolStripMenuItem.Text = "Articulos";
            articulosToolStripMenuItem.Click += articulosToolStripMenuItem_Click;
            articulosToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            articulosToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            articulosToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // cotizacionesToolStripMenuItem
            // 
            cotizacionesToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            cotizacionesToolStripMenuItem.Size = new Size(142, 34);
            cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            cotizacionesToolStripMenuItem.Click += cotizacionesToolStripMenuItem_Click;
            cotizacionesToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            cotizacionesToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            cotizacionesToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(126, 34);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            empleadosToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            empleadosToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            empleadosToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(101, 34);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            facturasToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            facturasToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            facturasToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // camionesToolStripMenuItem
            // 
            camionesToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            camionesToolStripMenuItem.Size = new Size(116, 34);
            camionesToolStripMenuItem.Text = "Camiones";
            camionesToolStripMenuItem.Click += camionesToolStripMenuItem_Click;
            camionesToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            camionesToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            camionesToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // proovedorToolStripMenuItem
            // 
            proovedorToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            proovedorToolStripMenuItem.Name = "proovedorToolStripMenuItem";
            proovedorToolStripMenuItem.Size = new Size(120, 34);
            proovedorToolStripMenuItem.Text = "Proovedor";
            proovedorToolStripMenuItem.Click += proovedorToolStripMenuItem_Click;
            proovedorToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            proovedorToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            proovedorToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // marcaToolStripMenuItem
            // 
            marcaToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            marcaToolStripMenuItem.Size = new Size(83, 34);
            marcaToolStripMenuItem.Text = "Marca";
            marcaToolStripMenuItem.Click += marcaToolStripMenuItem_Click;
            marcaToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            marcaToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            marcaToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 34);
            toolStripMenuItem1.Text = "Conduces";
            toolStripMenuItem1.Visible = false;
            toolStripMenuItem1.BackColorChanged += toolStripMenuItem1_BackColorChanged;
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            toolStripMenuItem1.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            toolStripMenuItem1.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            toolStripMenuItem1.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(104, 34);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.BackColorChanged += toolStripMenuItem1_BackColorChanged;
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            usuariosToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            usuariosToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            usuariosToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(118, 34);
            inventarioToolStripMenuItem.Text = "Inventario";
            inventarioToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.BackColorChanged += toolStripMenuItem1_BackColorChanged;
            inventarioToolStripMenuItem.Click += inventarioToolStripMenuItem_Click;
            inventarioToolStripMenuItem.MouseEnter += clientesToolStripMenuItem_MouseEnter;
            inventarioToolStripMenuItem.MouseLeave += clientesToolStripMenuItem_MouseLeave;
            inventarioToolStripMenuItem.MouseHover += clientesToolStripMenuItem_MouseHover;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Arenera Imperio W";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmPrincipal_FormClosed;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripMenuItem cotizacionesToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem camionesToolStripMenuItem;
        private ToolStripMenuItem proovedorToolStripMenuItem;
        private ToolStripMenuItem marcaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
    }
}