using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using programaFacturacion.controlador;
using programaFacturacion.modelo;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace programaFacturacion
{
    public partial class frmReporteEstado : Form
    {
        public frmReporteEstado()
        {
            InitializeComponent();
        }
        public void clearInputs()
        {
            DateTime now=DateTime.Now;
            dateTimePicker1.Value= now;
            dateTimePicker2.Value=now;
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
        }
            
        
        private void button1_Click(object sender, EventArgs e)
        {
          DateOnly firstDate = DateOnly.FromDateTime(dateTimePicker1.Value);
DateOnly secondDate = DateOnly.FromDateTime(dateTimePicker2.Value);

DataTable dtReporteEstado = new DataTable();
double ventas = 0;
double Costo = 0;
double ganancia = 0;

conexion conexion = new conexion();
string consulta = "SELECT * FROM facturaDetalle WHERE fechaCreacion BETWEEN @fechaInicio AND @fechaFin";

using (SqlConnection conn = new SqlConnection(conexion.connectionString))
{
    conn.Open();
    using (SqlCommand cmd = new SqlCommand(consulta, conn))
    {
        // Use DateTime for parameter values
        cmd.Parameters.AddWithValue("@fechaInicio", dateTimePicker1.Value.Date);
        cmd.Parameters.AddWithValue("@fechaFin", dateTimePicker2.Value.Date);

        using (SqlDataReader Reader = cmd.ExecuteReader())
        {
            if (Reader.HasRows)
            {
                dtReporteEstado.Load(Reader);

                for (int i = 0; i < dtReporteEstado.Rows.Count; i++)
                {
                    double cantidad = Convert.ToDouble(dtReporteEstado.Rows[i][3]);
                    ventas += Convert.ToDouble(dtReporteEstado.Rows[i][4]) * cantidad;
                    Costo += Convert.ToDouble(dtReporteEstado.Rows[i][5]) * cantidad;
                }

                ganancia = ventas - Costo;

                textBox1.Text = ventas.ToString("F2");
                textBox2.Text = ganancia.ToString("F2");
                textBox3.Text = Costo.ToString("F2");

                MessageBox.Show("Realizado");
            }
            else
            {
                MessageBox.Show("No existen registros dentro del intervalo proporcionado");
            }
        }
    }
}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearInputs();
        }
}
}
