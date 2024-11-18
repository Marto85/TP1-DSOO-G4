using System;
using System.Windows.Forms;
using DSOO_Grupo4_TP1.Datos; // Asegúrate de que el espacio de nombres sea correcto

namespace DSOO_Grupo4_TP1
{
    internal class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuración inicial de la aplicación
            ApplicationConfiguration.Initialize();

            try
            {
                // Inicializar la conexión a la base de datos
                Conexion conexion = Conexion.getInstancia();

                // Si la conexión es exitosa, iniciar la aplicación
                Application.Run(new Login_form());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error  al conectar con la base de datos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
