using System;
using System.Windows.Forms;

namespace Tienda_Escritorio
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

            // Crear una instancia única de Form1
            Form1 form1 = Form1.Instance;

            // Ejecutar la aplicación
            Application.Run(form1);
        }
    }
}