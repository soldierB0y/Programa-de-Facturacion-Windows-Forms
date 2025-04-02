using programaFacturacion.vistas;
using System;
using System.Windows.Forms;

namespace programaFacturacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Manejo de excepciones no controladas en hilos de UI
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show($"Error no controlado: {e.Exception.Message}\n{e.Exception.StackTrace}", "Error de aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Manejo de excepciones no controladas en otros hilos
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var exception = e.ExceptionObject as Exception;
                if (exception != null)
                {
                    MessageBox.Show($"Error cr�tico: {exception.Message}\n{exception.StackTrace}", "Error Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            try
            {
                // Iniciar la aplicaci�n normalmente
                Application.Run(new frmLogin());
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepci�n en el hilo principal y mostrarla
                MessageBox.Show($"Excepci�n en el hilo principal: {ex.Message}\n{ex.StackTrace}", "Excepci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
