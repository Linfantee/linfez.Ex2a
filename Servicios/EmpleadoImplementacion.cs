using linflez.Ex2a.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflez.Ex2a.Servicios
{

    /// <summary>
    /// Implementación que se encarga del prodecimiento de los métodos del me.
    /// leig - 040324
    /// </summary>
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public int entrarEmpleado()
        {

            int opcion;
            Console.WriteLine("………");
            Console.WriteLine("Escoja la opción que desee tomar.");
            Console.WriteLine("0. Volver al inicio.");
            Console.WriteLine("1. Calculo total de ventas diario.");
            Console.WriteLine("2. Añadir venta.");
            Console.WriteLine("………");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
        DateTime fechacompra = DateTime.Now;
        public long añadirVenta(List<ClienteDto> list)
        {
            long venta;
            Console.WriteLine("Inserte el importe de la venta realizada.");
            venta = Convert.ToInt64(Console.ReadLine());

            return venta;

        }

        public int diferenciaFechas(List<ClienteDto> list)
        {
            int fecha;
            
            Console.WriteLine("Inserte una fecha en formato dd-MM-yyyy");
            fecha = Convert.ToInt32(Console.ReadLine());
            int fechaFinal = fechacompra.CompareTo(fecha);
            
            return fechaFinal;
        
        }



    }
}
