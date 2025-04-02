using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    public class ArticulosModelo
    {
        conexion conexion1 = new conexion();
        
        public DataTable dtArticulosModelo = new DataTable();
        //get: Articulos

        public DataTable getArticulos()
        {
            string consulta = "select * from Articulos";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            dtArticulosModelo.Load(reader);
                        }
                    }
                }
                ocon.Close();


            }
            return dtArticulosModelo;
        }


        public string AgregarArticulosModelo(string nombre, string codigo, Array imagen, string descripcion, double precioCompra, double precioVenta, double precioMinimo, bool precioModificable, bool estado, bool facturarSinInventario, double inventario,string marca, string proovedor,string descripcionModificacion)
        {
            string consulta = "select * from articulos where codigo= @codigo";
            //marca
            string consultaMarca = "select IDArticuloMarca from articuloMarca where nombreMarca=@marca";
            DataTable tbMarca= new DataTable();
            string valorMarcaCapturadoID="";
            //proovedor
            string consultaProovedor = "select IDProovedor from proovedor where nombreProovedor=@proovedor";
            DataTable tbProovedor= new DataTable();
            string valorProovedorCapturadoID = "";



            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))

            {
                try
                {
                    ocon.Open();
                    //Con el siguiente comando calculamos el valor del IDMarca y lo agregamos a valorMarcaCapturadoID
                    using (SqlCommand cmd2 = new SqlCommand(consultaMarca, ocon))
                    {
                        cmd2.Parameters.AddWithValue("@marca", marca);
                        cmd2.ExecuteNonQuery();
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                tbMarca.Load(reader);
                                for (int i = 0; i < tbMarca.Rows.Count; i++)
                                {
                                    valorMarcaCapturadoID = tbMarca.Rows[i][0].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex) { valorMarcaCapturadoID = "0"; }

                using (SqlCommand cmd4 = new SqlCommand(consultaProovedor, ocon))
                {
                    try
                    {
                        cmd4.Parameters.AddWithValue("@proovedor", proovedor);
                        cmd4.ExecuteNonQuery();
                        using (SqlDataReader reader = cmd4.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                tbProovedor.Load(reader);
                                for (int i = 0; i < tbProovedor.Rows.Count; i++)
                                {
                                    valorProovedorCapturadoID = tbProovedor.Rows[i][0].ToString();
                                }
                            }
                        }
                    } catch (Exception ex) {valorProovedorCapturadoID="0"; }
                }
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if ((reader.HasRows))
                        {
                            return "ya existe un articulo con este codigo";
                        }
                        else
                        {
                            string consulta2;
                            //la siguiente condicion en esta consulta es para que no haya errores
                            // a la hora de modificar datos en la base de datos puesto que si no existe la imagen 
                            //no debe solicitarla a la variable puesto que no existe
                            if (imagen != null)
                            {

                                consulta2 = "insert into Articulos(nombreArticulo,codigo,imagen,descripcion,precioCompra,precioVenta,precioMinimo,precioModificable,estado,facturarSinInventario,inventario,fechaModificacion,IDMarca,IDProovedor,descripcionModificacion)" +
                      "\r\nvalues(@nombre,@codigo,@imagen,@descripcion,@precioCompra,@precioVenta,@precioMinimo,@precioModificable,@estado,@facturarSininventario,@inventario,@fechaModificacion,@IDMarca,@IDProovedor,@descripcionModificacion)";
                            }
                            else
                            {

                                consulta2 = "insert into Articulos(nombreArticulo,codigo,descripcion,precioCompra,precioVenta,precioMinimo,precioModificable,estado,facturarSinInventario,inventario,fechaModificacion,IDMarca,IDProovedor,descripcionModificacion)" +
                       "\r\nvalues(@nombre,@codigo,@descripcion,@precioCompra,@precioVenta,@precioMinimo,@precioModificable,@estado,@facturarSininventario,@inventario,@fechaModificacion,@IDMarca,@IDProovedor,@descripcionModificacion)";
                            }
                            // Cerrar el DataReader antes de ejecutar el siguiente comando
                            reader.Close();

                            using (SqlCommand cmd3 = new SqlCommand(consulta2, ocon))
                            {
                                cmd3.Parameters.AddWithValue("@nombre", nombre);
                                cmd3.Parameters.AddWithValue("@codigo", codigo);
                                //la siguiente condicion en este parametro es para que no haya errores
                                // a la hora de modificar datos en la base de datos puesto que si no existe la imagen 
                                //no debe solicitarla a la variable puesto que no existe
                                if (imagen != null)
                                {
                                    cmd3.Parameters.AddWithValue("@imagen", imagen);
                                }
                                cmd3.Parameters.AddWithValue("@IDMarca", Convert.ToInt64(valorMarcaCapturadoID));
                                cmd3.Parameters.AddWithValue("@IDProovedor",Convert.ToInt64( valorProovedorCapturadoID));
                                cmd3.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                                cmd3.Parameters.AddWithValue("@descripcion", descripcion);
                                cmd3.Parameters.AddWithValue("@precioCompra", precioCompra);
                                cmd3.Parameters.AddWithValue("@precioVenta", precioVenta);
                                cmd3.Parameters.AddWithValue("@precioMinimo", precioMinimo);
                                cmd3.Parameters.AddWithValue("@precioModificable", precioModificable);
                                cmd3.Parameters.AddWithValue("@estado", estado);
                                cmd3.Parameters.AddWithValue("@facturarSinInventario", facturarSinInventario);
                                cmd3.Parameters.AddWithValue("@inventario", inventario);
                                cmd3.Parameters.AddWithValue("descripcionModificacion",descripcionModificacion);
                                cmd3.ExecuteNonQuery();
                            }

                            return "Agregado Exitosamente!!!";
                        }
                    }

                }
                ocon.Close();
            }
        }


        public string ModificarArticulosModelo(string nombre, string codigo, Array imagen, string descripcion, double precioCompra, double precioVenta, double precioMinimo, bool precioModificable, bool estado, bool facturarSinInventario, double inventario,string marca,string proovedor,string descripcionModificacion)
        {
            //query
            string consulta = "select * from articulos where codigo= @codigo";
            //Marca
            string valorMarcaCapturadoID = "";
            string consultaMarca = "select IDArticuloMarca from articuloMarca where nombreMarca=@marca";
            DataTable tbMarca = new DataTable();
            //Proovedor
            string valorProovedorID = "";
            //query especifico para buscar el proovedor del articulo y obtener el ID
            string consultaProovedor = "select IDProovedor from proovedor where nombreProovedor=@proovedor";
            DataTable tbProovedor=new DataTable();//aqui cargaremos el resultado de la busqueda en la base de datos
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))

                {
                    ocon.Open();
                using (SqlCommand cmd2 = new SqlCommand(consultaMarca, ocon))
                {
                    //query especifico para buscar la marca 
                    cmd2.Parameters.AddWithValue("@marca", marca);
                    cmd2.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            tbMarca.Load(reader);
                            for (int i = 0; i < tbMarca.Rows.Count; i++)
                            {
                                valorMarcaCapturadoID = tbMarca.Rows[i][0].ToString();
                                //MessageBox.Show(valorMarcaCapturadoID, "IDMARCA");
                            }
                        }
                    }
                }

                using (SqlCommand cmd4 = new SqlCommand(consultaProovedor, ocon))
                {
                    cmd4.Parameters.AddWithValue("@proovedor",proovedor);
                    cmd4.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd4.ExecuteReader())
                    {
                        if (reader.HasRows)
                        { 
                            tbProovedor.Load(reader);
                            for (int i = 0; i < tbProovedor.Rows.Count; i++)
                            {
                                valorProovedorID = tbProovedor.Rows[i][0].ToString();
                               // MessageBox.Show(valorProovedorID);
                            }
                        }
                    }
                
                }
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!(reader.HasRows))
                        {
                            return "No existe un articulo para modificar con este codigo";
                        }
                        else
                        {
                            string consulta2;

                            if (imagen != null)
                            {
                                consulta2 = "update Articulos set nombreArticulo= @nombre,codigo=@codigo,imagen=@imagen,descripcion=@descripcion, precioCompra=@precioCompra, precioVenta=@precioVenta,precioMinimo=@precioMinimo,precioModificable=@precioModificable,estado=@estado,facturarSinInventario=@facturarSinInventario,inventario=@inventario,IDMarca=@IDMarca, IDProovedor=@IDProovedor,descripcionModificacion=@descripcionModificacion where codigo= @codigo";
                            }
                            else {
                                consulta2 = "update Articulos set nombreArticulo= @nombre,codigo=@codigo,imagen=imagen,descripcion=@descripcion, precioCompra=@precioCompra, precioVenta=@precioVenta,precioMinimo=@precioMinimo,precioModificable=@precioModificable,estado=@estado,facturarSinInventario=@facturarSinInventario,inventario=@inventario,IDMarca=@IDMarca,IDProovedor=@IDProovedor,descripcionModificacion=@descripcionModificacion where codigo= @codigo";

                            }
                           // MessageBox.Show(consulta2,"consulta");
                            // Cerrar el DataReader antes de ejecutar el siguiente comando
                            reader.Close();

                            using (SqlCommand cmd3 = new SqlCommand(consulta2, ocon))
                            {
                                cmd3.Parameters.AddWithValue("@nombre", nombre);
                                cmd3.Parameters.AddWithValue("@codigo", codigo);
                                if (imagen != null)
                                {
                                    cmd3.Parameters.AddWithValue("@imagen", imagen);
                                }
                                cmd3.Parameters.AddWithValue("@IDMarca", valorMarcaCapturadoID);
                                cmd3.Parameters.AddWithValue("@IDProovedor",valorProovedorID);
                                cmd3.Parameters.AddWithValue("@descripcion", descripcion);
                                cmd3.Parameters.AddWithValue("@precioCompra", precioCompra);
                                cmd3.Parameters.AddWithValue("@precioVenta", precioVenta);
                                cmd3.Parameters.AddWithValue("@precioMinimo", precioMinimo);
                                cmd3.Parameters.AddWithValue("@precioModificable", precioModificable);
                                cmd3.Parameters.AddWithValue("@estado", estado);
                                cmd3.Parameters.AddWithValue("@facturarSinInventario", facturarSinInventario);
                                cmd3.Parameters.AddWithValue("@inventario", inventario);
                                cmd3.Parameters.AddWithValue("descripcionModificacion", descripcionModificacion);
                                cmd3.ExecuteNonQuery();
                            }

                            return "Modificado Exitosamente!!!";
                        }
                    }

                }
                    ocon.Close();
                }
            }
        public string EliminarArticulosControlador(string codigo)
        {
            string consulta = "delete Articulos where codigo=@codigo";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@codigo",codigo);
                    cmd.ExecuteNonQuery();
                    return "se ha eliminado correctamente";
                }
                ocon.Close();
            }
        }


        public DataTable BuscadorArticulosModelo(string criterio, string buscador)
        {
            try
            {
                string a = buscador;
                buscador = "";
                buscador = "%" + a + "%";
                string consulta = "select * from articulos where " + criterio + " like @buscador";
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@buscador", buscador);
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtArticulosModelo.Clear();
                                dtArticulosModelo.Load(reader);
                            }

                        }
                    }
                    ocon.Close();
                }
            } catch (Exception ex) { }
            return dtArticulosModelo;
                    
        }


        //Cargar proovedores
        public List<string> cargarProovedores()
        {
            List<string> values = new List<string>();
            string consulta = "select nombreProovedor from proovedor";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {

                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable proovedores = new DataTable();

                        if (reader.HasRows)
                        {
                            proovedores.Load(reader);
                            try
                            {

                                for (int i = 0; i < ((proovedores.Rows.Count)); i++)
                                {
                                    for (int j = 0; j <= 0; i++)
                                    {
                                         //MessageBox.Show("Row:" + i.ToString() + "\n Column:" + j.ToString() + "\n" + "valor:" + proovedores.Rows[i][j].ToString());
                                        values.Add(proovedores.Rows[i][j].ToString());
                                    }
                                }
                            }catch(Exception ex) {  }
                        }
                    }
                }
                ocon.Close();
            }
            return values;
        }
        //Cargar Marca
        public List<string> cargarMarca()
        {
            List<string> values = new List<string>();
            string consulta = "select nombreMarca from articuloMarca";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {

                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable Marca = new DataTable();

                        if (reader.HasRows)
                        {
                            Marca.Load(reader);
                            try
                            {
                                for (int i = 0; i < ((Marca.Rows.Count)); i++)
                                {
                                    for (int j = 0; j <= 0; i++)
                                    {
                                         //MessageBox.Show("Row:" + i.ToString() + "\n Column:" + j.ToString() + "\n" + "valor:" + Marca.Rows[i][j].ToString());
                                        values.Add(Marca.Rows[i][j].ToString());
                                    }
                                }
                            }
                            catch (Exception ex) {  }
                        }
                    }
                }
                ocon.Close();
            }
            return values;
        }

    }
}