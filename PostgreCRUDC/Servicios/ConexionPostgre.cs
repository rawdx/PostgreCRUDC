using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PostgreCRUDC.Servicios
{
    internal class ConexionPostgre:IConexionPostgre
    {
        public NpgsqlConnection GenerarConexion()
        {
            string stringConexionPostgresql = ConfigurationManager.ConnectionStrings["stringConexion"].ConnectionString;
            Console.WriteLine(stringConexionPostgresql);

            NpgsqlConnection conexion = null;
            string estado = "";

            if (!string.IsNullOrWhiteSpace(stringConexionPostgresql))
            {
                try
                {
                    conexion = new NpgsqlConnection(stringConexionPostgresql);
                    conexion.Open();

                    estado = conexion.State.ToString();
                    if (estado.Equals("Open"))
                        Console.WriteLine("[INFORMACIÓN-ConexionPostgresqlImplementacion-generarConexionPostgresql] Estado conexión: " + estado);
                    else
                        conexion = null;
                }
                catch (Exception e)
                {
                    Console.WriteLine("[ERROR-ConexionPostgresqlImplementacion-generarConexionPostgresql] Error al generar la conexión:" + e);
                    conexion = null;
                    return conexion;
                }
            }
            return conexion;
        }
    }
}
