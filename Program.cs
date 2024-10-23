//using DSOO_Grupo4_TP1.Models;
//using System.Reflection.PortableExecutable;
//using static System.Net.Mime.MediaTypeNames;

using DSOO_Grupo4_TP1.Datos;

namespace DSOO_Grupo4_TP1
{
    internal class Program
    {       /// <summary>
            ///  The main entry point for the application.
            /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login_form());
        }

        
    }
    
}
