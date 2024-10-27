using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class ClubDeportivo
    {
        public string Id { get; set; }
        public string NombreUsuario { get; set; }

        private string Password;
        private decimal abonoMensualSocios = 5000; // abono inicial socios
        private List<Cliente> clientes;

        public ClubDeportivo()
        {
            clientes = new List<Cliente>();

        }

        public ClubDeportivo(string id, string nombreUsuario, string password)
            : this() // llamada al constructor anterior para que aca tambien inicialice lista de cliente
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Password = password;
        }

        public List<dynamic> ObtenerClientesConPagoVencido()
        {
            List<dynamic> clientesVencidos = new List<dynamic>();
            Conexion conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;
            DateTime fechaActual = DateTime.Now;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                                SELECT 
                            c.Id AS Id,
                            c.Nombre,
                            c.Apellido,
                            c.DNI,
                            c.EsSocio,
                            COALESCE(MAX(p.FechaPago), MAX(pa.FechaPago)) AS FechaUltimoPago,
                            CASE 
                                WHEN c.EsSocio = 1 AND COALESCE(GROUP_CONCAT(a.Nombre SEPARATOR ', '), '') = '' 
                                THEN '----'  -- Mostrar '----' si es socio y no tiene actividades vencidas
                                ELSE COALESCE(GROUP_CONCAT(a.Nombre SEPARATOR ', '), '') 
                            END AS ActividadesVencidas,
                            COALESCE(MAX(p.ProximoVencimiento), MAX(pa.ProximoVencimiento)) AS FechaVencimiento
                        FROM Cliente AS c
                        LEFT JOIN (
                            SELECT Cliente_Id, MAX(FechaPago) AS FechaPago, MAX(ProximoVencimiento) AS ProximoVencimiento, Id_tipo_de_pago
                            FROM Pago
                            WHERE ProximoVencimiento < CURDATE()
                            GROUP BY Cliente_Id, Id_tipo_de_pago  -- Incluir Id_tipo_de_pago en el GROUP BY
                        ) AS p ON c.Id = p.Cliente_Id
                        LEFT JOIN (
                            SELECT Cliente_id, MAX(FechaPago) AS FechaPago, MAX(ProximoVencimiento) AS ProximoVencimiento, Actividad_id
                            FROM Pago_Actividad
                            WHERE ProximoVencimiento < CURDATE()
                            GROUP BY Cliente_id, Actividad_id
                        ) AS pa ON c.Id = pa.Cliente_id
                        LEFT JOIN Actividad AS a ON pa.Actividad_id = a.Id
                        WHERE p.FechaPago IS NOT NULL OR pa.FechaPago IS NOT NULL
                        GROUP BY c.Id, c.Nombre, c.Apellido, c.DNI, c.EsSocio;";




                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FechaActual", fechaActual);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var clienteVencido = new
                                {
                                    Id = reader.GetInt32("Id"),
                                    Nombre = reader.GetString("Nombre"),
                                    Apellido = reader.GetString("Apellido"),
                                    DNI = reader.GetInt32("DNI"),
                                    EsSocio = reader.GetBoolean("EsSocio"),
                                    FechaUltimoPago = reader.IsDBNull(reader.GetOrdinal("FechaUltimoPago"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime("FechaUltimoPago"),
                                                ActividadesVencidas = reader.IsDBNull(reader.GetOrdinal("ActividadesVencidas"))
                                    ? "----"  
                                    : reader.GetString("ActividadesVencidas"),
                                                FechaVencimiento = reader.IsDBNull(reader.GetOrdinal("FechaVencimiento"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime("FechaVencimiento"),
                                };

                                clientesVencidos.Add(clienteVencido);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener clientes con pagos vencidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return clientesVencidos;
        }



        public decimal ObtenerAbonoMensualSociosBase()
        {
            return abonoMensualSocios;
        }

        public void ModificarAbonoMensualSocios(decimal nuevoAbono)
        {
            abonoMensualSocios = nuevoAbono;
        }

        public decimal ObtenerAbonoMensualSociosConDescuento(int frecuenciaPago)
        {
            switch (frecuenciaPago)
            {
                case 1:
                    return abonoMensualSocios;
                case 2:
                    return abonoMensualSocios * 0.95m;
                case 3:
                    return abonoMensualSocios * 0.85m;
                case 4:
                    return abonoMensualSocios * 0.75m;
                default:
                    return abonoMensualSocios;
            }
        }



        /*
         * Permite inscribir un cliente o Socio en una actividad
         */
        /*public string InscribirActividad(string nombreActividad, int idCliente)
        {
            //Chequea que la actividad exista
            Actividad actividad = actividades.FirstOrDefault(a => a.Nombre == nombreActividad);            
            if (actividad == null) return "ACTIVIDAD INEXISTENTE";

            //Chequea que el cliente exista
            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);
            if (cliente == null) return "CLIENTE INEXISTENTE";


            // Verificar si el cliente ya está inscrito en la actividad
            if (cliente.Actividades.Any(a => a.Nombre == nombreActividad))
            {
                return "EL CLIENTE YA ESTÁ INSCRITO EN ESTA ACTIVIDAD";
            }

            // Si el cliente existe y es socio, chequea la cantidad de actividades. Si no es socio, no. 
            if (cliente is Socio && cliente.Actividades.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            // Chequear si hay cupo en la actividad
            if (!actividad.ChequearCupo())
            {
                return "NO HAY CUPOS DISPONIBLES";
            }

            // Registrar inscripción y restar cupo
            cliente.Actividades.Add(actividad);
            actividad.ReservaCupo();
            actividad.AgregarInscripto(cliente); // Método para agregar el cliente a la lista de inscriptos de la actividad

            // Verificar que se agrego la actividad
            if (cliente.Actividades.Contains(actividad))
            {
                Console.WriteLine($"El cliente {cliente.Nombre} ha sido inscrito correctamente en la actividad {actividad.Nombre}.");
            }
            else
            {
                Console.WriteLine("Hubo un error al inscribir al cliente en la actividad.");
            }

            return "INSCRIPCIÓN EXITOSA";
        }*/

        /*public List<Actividad> ObtenerActividades()
        {
            return actividades;
        }*/
        /*public List<Cliente> ObtenerClientesFiltrados(bool soloSocios = false, bool soloNoSocios = false)
        {
            if(soloSocios && !soloNoSocios) return clientes.Where(c => c is Socio).ToList();

            else if (soloNoSocios && !soloSocios) return clientes.Where(c => !(c is Socio)).ToList();

            else return clientes.ToList();
        }*/

        /*public Cliente ObtenerClientePorId(int id)
        {
            return clientes.Find(c => c.IdCliente == id);
        }*/

        /*public List<Cliente> ObtenerMorosos()
        {
            return clientes.Where(c => !c.Activo).ToList();
        }*/

        /*public void ProcesarPago(int idSocio)
        {
            Socio SocioPagador = clientes.FirstOrDefault(c => c.IdCliente == idSocio) as Socio;
            if (SocioPagador == null)
            {
                throw new Exception("El socio no existe o no es un socio.");
            }

            else if (SocioPagador.Activo == true)
            {
                Console.WriteLine("Su cuota se encuentra al dia");
            }
            else
            {
                Console.WriteLine("Vamos a procesar tu pago");
                int frecuenciaPago = SocioPagador.ObtenerFrecuenciaDePago();
                
                // Convertimos el int previo en el valor correspondiente del enum FrecuenciaPago (de la clase Pago)
                Pago.FrecuenciaPago frecuencia = (Pago.FrecuenciaPago)frecuenciaPago;
                Console.WriteLine($"La frecuencia elegida es: {frecuencia}");
                
                decimal montoTotalAbonado = SocioPagador.CalcularAbonoConDescuento(frecuenciaPago);
                SocioPagador.Activo = true;
                Pago nuevoPago = new Pago(idSocio, montoTotalAbonado, DateTime.Now, frecuencia);
                SocioPagador.AgregarPago(nuevoPago);
                Console.WriteLine();
                Console.WriteLine("Tu pago se ha procesado con exito");
                SocioPagador.MostrarPagos(SocioPagador.IdCliente);
                DateTime proximoVencimiento = nuevoPago.CalcularProximoVencimiento();
                Console.WriteLine($"Su abono estara vigente hasta el dia: {proximoVencimiento}");
            }
        }*/
    }
}
