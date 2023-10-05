using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreCRUDC.Servicios
{
    internal interface IConexionPostgre
    {
        NpgsqlConnection GenerarConexion();
    }
}
