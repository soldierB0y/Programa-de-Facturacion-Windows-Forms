using programaFacturacion.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaFacturacion.vistas
{
    public partial class frmLogin : Form
    {
        inicioSesionControlador inicioSesionControlador = new inicioSesionControlador();
        usuarioControlador usuarioControlador = new usuarioControlador();
        DataTable dtUsuario = new DataTable();
        Int64 IDUsuario = -1;
        public frmLogin()
        {
            InitializeComponent();
            dtUsuario = usuarioControlador.cargarUsuarios();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUsuario.Text))
            {
                if (!string.IsNullOrEmpty(tbxClave.Text))
                {
                    if (inicioSesionControlador.verificarUsuarioClave(tbxUsuario.Text, tbxClave.Text) == true)
                    {
                        foreach (DataRow row in dtUsuario.Rows)
                        {
                            if (row[2].ToString() == tbxUsuario.Text)
                            {
                                IDUsuario = Convert.ToInt64(row[1].ToString());
                                frmPrincipal frmPrincipal = new frmPrincipal(IDUsuario);
                                frmPrincipal.Show();
                                frmPrincipal.Visible = true;
                                tbxUsuario.Text = "";
                                tbxClave.Text = "";
                                this.Visible = false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El usuario o la clave son incorrectos", "Error al tratar de iniciar sesion");
                        tbxClave.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una clave", "Error al tratar de iniciar sesion");

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Error al tratar de iniciar sesion");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
