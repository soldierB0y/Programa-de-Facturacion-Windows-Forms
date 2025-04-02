using programaFacturacion.controlador;
using System.Data;
using System.Drawing.Printing;

public class impresora
{
    Int64 ID;
    string nombreCliente;
    string telefono = "";
    string direccion = "";
    string tipoDocumento = "";
    double total;
    Int64 IDEmpleado;
    DataTable dtPrincipal = new DataTable();
    DataTable dtDetalles = new DataTable();
    PrintDocument printDocument1 = new PrintDocument();
    PrinterSettings ps = new PrinterSettings();
    cambiarIDaNombreControlador CINC = new cambiarIDaNombreControlador();

    public impresora(Int64 MyID, string MyCliente, string Mytelefono, string Mydireccion, DataTable MydtDetalles, double Mytotal, Int64 MyIDEmpleado, string MyTipoDocumento)
    {
        ID = MyID;
        nombreCliente = MyCliente;
        telefono = Mytelefono;
        direccion = Mydireccion;
        dtDetalles = MydtDetalles;
        total = Mytotal;

        IDEmpleado = MyIDEmpleado;
        tipoDocumento = MyTipoDocumento;

    }

    public void imprimirCotizacion()
    {
        for (int i = 0; i < 3; i++)
        {
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }
    }

    public string getNombreEmpleado(Int64 thisIDEmpleado)
    {
        return CINC.getID("empleados", "nombre", "IDEmpleado", thisIDEmpleado);

    }

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
    //    MessageBox.Show(IDEmpleado.ToString());
        string nombreEmpleado = getNombreEmpleado(IDEmpleado);
      //  MessageBox.Show(nombreEmpleado);
        Font font = new Font("Arial", 8);
        Font font2 = new Font("Arial", 7, FontStyle.Bold);
        Font font3= new Font("Arial",6,FontStyle.Bold);
        int ancho = 300;
        int y = 20;

        // Assuming Resources.logoWascar.LogoWascar is a valid Bitmap resource
        var logoWascar = new Bitmap(programaFacturacion.Resources.logoWascar.LogoWascar, ancho * 1 / 4, ancho * 1 / 4);
        e.Graphics.DrawImage(logoWascar, new RectangleF(ancho * 1 / 4 + 40, y, ancho * 1 / 4, ancho * 1 / 4));
        e.Graphics.DrawString("--------------------------Arenera Imperio W------------------------", font, Brushes.Black, new RectangleF(0, y += ancho * 1 / 4, ancho - 10, 20));
        e.Graphics.DrawString("telefono/whatsapp: +1 (809) 444-2000", font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("correo: imperiow@outlook.es ", font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("direccion:", font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString(" Calle Principal#56", font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("Sector la Guandulera, San Cristobal", font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("-----------------------------------------------------------------------", font, Brushes.Black, new RectangleF(10, y += 20, ancho - 10, 20));
        e.Graphics.DrawString(tipoDocumento, font, Brushes.Black, new RectangleF(125, y += 20, ancho, 20));
        e.Graphics.DrawString("numero: " + ID.ToString(), font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("fecha: " + DateTime.Now.ToString(), font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("Atendido por: " + nombreEmpleado, font, Brushes.Black, new RectangleF(10, y += 20, ancho, 20));
        e.Graphics.DrawString("Cliente: " + nombreCliente, font, Brushes.Black, new RectangleF(10, y += 20, ancho - 20, 40));
        if (!string.IsNullOrEmpty(telefono))
        {
            e.Graphics.DrawString("telefono del cliente: " + telefono, font, Brushes.Black, new RectangleF(10, y += 40, ancho, 20));
        }
        if (!string.IsNullOrEmpty(direccion))
        {
            e.Graphics.DrawString("direccion del cliente: " + direccion, font, Brushes.Black, new RectangleF(10, y += 20, ancho, 40));
        }
        e.Graphics.DrawString("-----------------------------------------------------------------------", font, Brushes.Black, new RectangleF(10, y += 20, ancho - 10, 20));
        e.Graphics.DrawString("cantidad", font, Brushes.Black, new RectangleF(ancho * 1 / 12, y += 40, ancho, 20));
        e.Graphics.DrawString("Descripcion", font, Brushes.Black, new RectangleF(ancho * 4 / 12, y, ancho, 20));
        e.Graphics.DrawString("ITBIS", font, Brushes.Black, new RectangleF(ancho * 7 / 12, y, ancho, 20));
        e.Graphics.DrawString("valor", font, Brushes.Black, new RectangleF(ancho * 10 / 12 - 20, y, ancho, 20));

        foreach (DataRow row in dtDetalles.Rows)
        {
            int z = y + 40;
            e.Graphics.DrawString(row[4].ToString(), font, Brushes.Black, new RectangleF(ancho * 1 / 12, z, ancho * 3 / 14 - 10, 40));
            e.Graphics.DrawString(row[2].ToString(), font2, Brushes.Black, new RectangleF(ancho * 4 / 12, z, ancho * 4 / 14 - 10, 40));
            e.Graphics.DrawString(Math.Round(Convert.ToDouble(row[6]), 2).ToString(), font, Brushes.Black, new RectangleF(ancho * 7 / 14 + 25, z, ancho, 40));
            e.Graphics.DrawString(Math.Round(Convert.ToDouble(row[9]),2).ToString(), font, Brushes.Black, new RectangleF(ancho * 11 / 14, z, ancho * 3 / 14, 40));

            y = z;
        }

        e.Graphics.DrawString("total: ", font, Brushes.Black, new RectangleF(ancho * 1 / 9 - 10, y += 30, ancho * 2 / 9, 20));
        e.Graphics.DrawString(total.ToString(), font, Brushes.Black, new RectangleF(ancho * 7 / 9, y, ancho * 3 / 14, 20));
        e.Graphics.DrawString("-----------------------------------------------------------------------", font, Brushes.Black, new RectangleF(10, y += 20, ancho - 10, 20));
        e.Graphics.DrawString("despachado por:________________________________________________", font3, Brushes.Black, new RectangleF(10, y += 20, ancho - 10, 20));
        e.Graphics.DrawString("recibido por:__________________________________________________", font3, Brushes.Black, new RectangleF(10, y += 20, ancho - 10, 20));
        e.Graphics.DrawString("-----------------------------------------------------------------------", font, Brushes.Black, new RectangleF(10, y += 20, ancho - 10, 20));
        e.Graphics.DrawString("¡¡Gracias por Preferirnos!!", font, Brushes.Black, new RectangleF(75, y += 20, ancho, 60));

    }
}
