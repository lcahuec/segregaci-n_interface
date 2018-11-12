using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagosBalon
{
    class Empleados : IFabrica
    {
        int cantBalones;
        string  nombre;
        double precio;
        double comision;
        double t,tFinal;

        public int CantBalones
        {
            get { return cantBalones; }
            set { cantBalones = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public double Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        //Craecion del constructor de la clase
        public Empleados(int CANT, string NOMBRE, double PRECIO, double COMISIONES)
        {
            this.cantBalones = CANT;
            this.nombre = NOMBRE;
            this.precio = PRECIO;
            this.comision = COMISIONES;
            
        }

        //CReacion de la Segregacion de la interfaz
        public void pagos()
        {
            t = precio * comision;
            tFinal = t * cantBalones;

            Console.WriteLine("Nombre del Empleado: " + nombre + "\nBalones hechos: " +cantBalones + "\nSalario: Q " +tFinal);
        }

    }
}
