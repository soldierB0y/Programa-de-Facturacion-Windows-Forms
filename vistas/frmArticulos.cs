using Microsoft.Extensions.Options;
using programaFacturacion.controlador;
using programaFacturacion.modelo;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace programaFacturacion
{
    public partial class frmArticulos : Form
    {
        Array imagenParaEnviar;
        public ArticulosControlador articulosControlador = new ArticulosControlador();
        public Image varImagen;
        Int64 MyUsuario;

        public void buscadorVista()
        {

            string valor;
            if (cbbCriterio.Text == "nombre")
            {
                // Hago que se cambie a nombreArticulo porque es este el nombre de la columna en la base de datos
                valor = "nombreArticulo";
            }
            else { valor = cbbCriterio.Text; }
            dgvArticulos.DataSource = articulosControlador.BuscadorArticulosControlador(valor, tbxBuscador.Text);
            try
            {
                for (int i = 0; i < dgvArticulos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvArticulos.Columns.Count; j++)
                    {

                        if (dgvArticulos.Rows[i].Cells[j].GetType().Name.ToString() == "DataGridViewImageCell" && dgvArticulos.Rows[i].Cells[j].Value.ToString() != "System.DBNull")
                        {
                            //creamos un objeto que contiene el contenido de la celda, en este caso una imagen
                            object objArticuloCelda = dgvArticulos.Rows[i].Cells[j].Value;
                            //capturamos ese objeto en bytes[]
                            byte[] bytesObjArticuloCelda = (byte[])objArticuloCelda;
                            //creamos una variable del tipo imagen 
                            Image imagen;
                            using (MemoryStream ms = new MemoryStream(bytesObjArticuloCelda))
                            {
                                //asignamos a  la variable imagen el valor del objeto en bytes[]
                                imagen = Image.FromStream(ms);
                            }
                            //creamos un variable bitmap del tipo Bitmap, con sus respectivas dimenciones
                            Bitmap bitmap = new Bitmap(45, 45);
                            using (Graphics g = Graphics.FromImage(bitmap))
                            {
                                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                g.DrawImage(imagen, 0, 0, 45, 45);



                                using (MemoryStream ms2 = new MemoryStream())
                                {
                                    var tipoImagen = imagen.RawFormat;
                                    bitmap.Save(ms2, tipoImagen);

                                    dgvArticulos.Rows[i].Cells[j].Value = ms2.ToArray();
                                }
                            }



                        }

                    }






                }
            }
            catch (Exception ex)
            {

            }
        }
        public frmArticulos(Int64 IDMarcaUsuario)
        {

            InitializeComponent();

            MyUsuario = IDMarcaUsuario;
            articulosControlador.getArticulos();
            buscadorVista();

            cbxProovedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            //lista de proovedores
            List<string> proovedores = articulosControlador.cargarProovedores();

            //MessageBox.Show(proovedores.Count.ToString());
            for (int i = 0; i < proovedores.Count; i++)
            {
                cbxProovedor.Items.Add(proovedores[i]);
            }
            try
            {
                cbxProovedor.SelectedIndex = 0;
            }
            catch (Exception ex) { }
            //lista de Marcas
            List<string> marca = articulosControlador.cargarMarca();
            //MessageBox.Show(marca.Count.ToString());
            for (int i = 0; i < marca.Count; i++)
            {
                cbxMarca.Items.Add(marca[i]);
            }

            try
            {
                cbxMarca.SelectedIndex = 0;
            }
            catch (Exception ex) { }


            dgvArticulos.DataSource = articulosControlador.dtArticulosControlador;
            cbxFacturarSinInventario.Checked = false;
            tbxInventario.Text = "0";
            tbxPrecioMinimo.Text = "0";
            cbbCriterio.SelectedIndex = 0;
            cbbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            //blockear edicion de columnas



        }


        public void LimpiarRegistros()
        {
            lbUbicacionArchivo.Text = "Ninguno";
            tbxNombre.Text = "";
            tbxCodigo.Text = "";
            varImagen = null;
            tbxDescripcion.Text = "";
            tbxPrecioCompra.Text = "";
            tbxPrecioVenta.Text = "";
            tbxPrecioMinimo.Text = "";
            cbxPrecioModificable.Checked = false;
            cbxEstado.Checked = false;
            cbxFacturarSinInventario.Checked = false;
            tbxInventario.Text = "";
        }

        public void CargarArticulosVista()
        {
            articulosControlador.dtArticulosControlador.Clear();
            articulosControlador.getArticulos();
            dgvArticulos.DataSource = articulosControlador.dtArticulosControlador;
            for (int j = 0; j < dgvArticulos.ColumnCount; j++)
            {
                for (int i = 0; i < dgvArticulos.Rows.Count; i++)
                {
                    // MessageBox.Show(dgvArticulos.Rows[i].Cells[j].Value.GetType().ToString());
                    try
                    {
                        if (dgvArticulos.Rows[i].Cells[j].Value.GetType().ToString() == "System.Byte[]")
                        {
                            if (dgvArticulos.Rows[i].Cells[j].GetType().Name.ToString() == "DataGridViewImageCell" && dgvArticulos.Rows[i].Cells[j].Value.ToString() != "System.DBNull")
                            {
                                //creamos un objeto que contiene el contenido de la celda, en este caso una imagen
                                object objArticuloCelda = dgvArticulos.Rows[i].Cells[j].Value;
                                //capturamos ese objeto en bytes[]
                                byte[] bytesObjArticuloCelda = (byte[])objArticuloCelda;
                                //creamos una variable del tipo imagen 
                                Image imagen;
                                using (MemoryStream ms = new MemoryStream(bytesObjArticuloCelda))
                                {
                                    //asignamos a  la variable imagen el valor del objeto en bytes[]
                                    imagen = Image.FromStream(ms);
                                }
                                //creamos un variable bitmap del tipo Bitmap, con sus respectivas dimenciones
                                Bitmap bitmap = new Bitmap(45, 45);
                                using (Graphics g = Graphics.FromImage(bitmap))
                                {
                                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                    g.DrawImage(imagen, 0, 0, 45, 45);



                                    using (MemoryStream ms2 = new MemoryStream())
                                    {
                                        var tipoImagen = imagen.RawFormat;
                                        bitmap.Save(ms2, tipoImagen);

                                        dgvArticulos.Rows[i].Cells[j].Value = ms2.ToArray();
                                    }
                                }



                            }
                        }
                    }
                    catch (Exception ex) { }
                }
            }




        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvArticulos.Select();
            try
            {
                var codigo = dgvArticulos.Rows[e.RowIndex].Cells[5].Value.ToString();
                var nombre = dgvArticulos.Rows[e.RowIndex].Cells[6].Value.ToString();
                var descripcion = dgvArticulos.Rows[e.RowIndex].Cells[7].Value.ToString();
                var imagen = dgvArticulos.Rows[e.RowIndex].Cells[8].Value.ToString();
                var precioCompra = dgvArticulos.Rows[e.RowIndex].Cells[18].Value.ToString();
                var precioVenta = dgvArticulos.Rows[e.RowIndex].Cells[9].Value.ToString();
                var precioMinimo = dgvArticulos.Rows[e.RowIndex].Cells[10].Value.ToString();
                var estado = dgvArticulos.Rows[e.RowIndex].Cells[11].Value.ToString();
                var invetario = dgvArticulos.Rows[e.RowIndex].Cells[15].Value.ToString();
                var facturarSinInventario = dgvArticulos.Rows[e.RowIndex].Cells[16].Value.ToString();
                var precioModificable = dgvArticulos.Rows[e.RowIndex].Cells[17].Value.ToString();
                // var marca = dgvArticulos.Rows[e.RowIndex].Cells[4]
                tbxCodigo.Text = codigo;
                tbxNombre.Text = nombre;
                tbxDescripcion.Text = descripcion;
                tbxPrecioCompra.Text = precioCompra;
                tbxPrecioVenta.Text = precioVenta;
                tbxPrecioMinimo.Text = precioMinimo;
                tbxInventario.Text = invetario;


                //   MessageBox.Show("estado:"+estado+"\n facturar sin inventario:"+facturarSinInventario+"\n"+"precioModificable:"+precioModificable);



                if (estado == "True")
                {
                    cbxEstado.Checked = true;
                }
                else
                {
                    cbxEstado.Checked = false;
                }
                if (precioModificable == "True")
                {
                    cbxPrecioModificable.Checked = true;
                }
                else
                {
                    cbxPrecioModificable.Checked = false;
                }
                if (facturarSinInventario == "True")
                {
                    cbxFacturarSinInventario.Checked = true;
                }
                else
                {
                    cbxFacturarSinInventario.Checked = false;
                }
            }
            catch (Exception ex) { }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCodigo.Text) && !string.IsNullOrEmpty(tbxPrecioVenta.Text) && !string.IsNullOrEmpty(tbxPrecioMinimo.Text) && (Convert.ToDouble(tbxPrecioMinimo.Text) <= Convert.ToDouble(tbxPrecioVenta.Text)))
            {
                /*if (string.IsNullOrEmpty(cbxMarca.Text))
                {
                    cbxMarca.Text = "Generico";
                }
                if (string.IsNullOrEmpty(cbxProovedor.Text))
                {
                    cbxProovedor.Text = "Generico";
                }*/
                if (tbxPrecioCompra.Text == "")
                {
                    tbxPrecioCompra.Text = "0";
                }
                if (tbxPrecioVenta.Text == "")
                {
                    tbxPrecioVenta.Text = "0";
                }
                if (tbxPrecioMinimo.Text == "")
                {
                    tbxPrecioMinimo.Text = "0";
                }
                if (tbxInventario.Text == "")
                {
                    tbxInventario.Text = "0";
                }
                try
                {


                    MessageBox.Show(articulosControlador.AgregarArticulosControlador(tbxNombre.Text, tbxCodigo.Text, imagenParaEnviar, tbxDescripcion.Text, Convert.ToDouble(tbxPrecioCompra.Text), Convert.ToDouble(tbxPrecioVenta.Text), Convert.ToDouble(tbxPrecioMinimo.Text), cbxPrecioModificable.Checked, cbxEstado.Checked, cbxFacturarSinInventario.Checked, Convert.ToDouble(tbxInventario.Text), cbxMarca.Text, cbxProovedor.Text, MyUsuario.ToString()));
                    LimpiarRegistros();
                    CargarArticulosVista();

                }
                catch (Exception ex) { MessageBox.Show("Error al ingresar valor en uno de los campos. Asegurese tambien de tener registrado por lo menos un proovedor y una marca."); };
            }
            else { MessageBox.Show("Debe ingresar  un codigo", "Error al agregar Articulo"); }
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lbUbicacionArchivo.Text = dialog.FileName;
                    var varImagen = Image.FromFile(dialog.FileName);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        varImagen.Save(ms, varImagen.RawFormat);
                        //  if (imagenParaEnviar == null) MessageBox.Show("No tengo contenido");
                        imagenParaEnviar = ms.ToArray();
                        //   if (imagenParaEnviar != null) MessageBox.Show("Tengo contenido pero no me puedo enviar");
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun archivo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCodigo.Text))
            {
                if (string.IsNullOrEmpty(cbxMarca.Text))
                {
                    cbxMarca.Text = "Generico";
                }
                if (string.IsNullOrEmpty(cbxProovedor.Text))
                {
                    cbxProovedor.Text = "Generico";
                }
                try
                {
                    MessageBox.Show(articulosControlador.ModificarArticulosControlador(tbxNombre.Text, tbxCodigo.Text, imagenParaEnviar, tbxDescripcion.Text, Convert.ToDouble(tbxPrecioCompra.Text), Convert.ToDouble(tbxPrecioVenta.Text), Convert.ToDouble(tbxPrecioMinimo.Text), cbxPrecioModificable.Checked, cbxEstado.Checked, cbxFacturarSinInventario.Checked, Convert.ToDouble(tbxInventario.Text), cbxMarca.Text, cbxProovedor.Text, MyUsuario.ToString()));
                    LimpiarRegistros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error0001: Ingreso un valor numerico en uno de los precios/ Ingreso un codigo a modificar que actualmente es inexistente");

                }

                CargarArticulosVista();
            }
            else { MessageBox.Show("Debe ingresar/seleccionar un codigo", "Error al modificar Articulo"); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCodigo.Text))
            {
                MessageBox.Show(articulosControlador.EliminarArticulosControlador(tbxCodigo.Text));
                LimpiarRegistros();
                CargarArticulosVista();
            }
            else
            {
                MessageBox.Show("Debe ingresar/seleccionar un codigo", "Error al eliminar Articulo");
            }
        }

        private void tbxInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxPrecioModificable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPrecioModificable.Checked == false)
            {
                tbxPrecioMinimo.ReadOnly = true;
                tbxPrecioMinimo.Text = tbxPrecioVenta.Text;
            }
            else { tbxPrecioMinimo.ReadOnly = false; }


        }

        private void cbxFacturarSinInventario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFacturarSinInventario.Checked == false)
            {
                tbxInventario.ReadOnly = true;
                tbxInventario.Text = "1";
            }
            else { tbxInventario.ReadOnly = false; }
        }

        private void tbxPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            if (cbxPrecioModificable.Checked == false)
            {
                tbxPrecioMinimo.Text = tbxPrecioVenta.Text;
            }
        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            buscadorVista();
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
