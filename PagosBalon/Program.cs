using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagosBalon
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados Empleado1 = new Empleados(100,"Ludswing",25,2);
            Empleado1.pagos();
            Console.ReadKey();
        }
    }
}
