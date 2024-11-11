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
        //private decimal abonoMensualSocios = 5000; // abono inicial socios
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
    }
}
