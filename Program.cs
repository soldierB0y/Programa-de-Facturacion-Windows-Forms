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
                MessageBox.Show($"Error no controlado: {e.Exception.Message}\n{e.Exception.StackTrace}", "Error de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Manejo de excepciones no controladas en otros hilos
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var exception = e.ExceptionObject as Exception;
                if (exception != null)
                {
                    MessageBox.Show($"Error crítico: {exception.Message}\n{exception.StackTrace}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            try
            {
                // Iniciar la aplicación normalmente
                Application.Run(new frmLogin());
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción en el hilo principal y mostrarla
                MessageBox.Show($"Excepción en el hilo principal: {ex.Message}\n{ex.StackTrace}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
