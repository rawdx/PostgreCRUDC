using PostgreCRUDC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreCRUDC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexionPostgre conn = new ConexionPostgre();
            Console.ReadLine();
        }
    }
}
