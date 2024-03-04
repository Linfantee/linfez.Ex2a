using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflez.Ex2a.Servicios
{
    /// <summary>
    /// Implementación que se encarga del prodecimiento de los métodos de la gerencia.
    /// leig - 040324
    /// </summary>
    internal class GerenciaImplementacion : GerenciaInterfaz
    {

        public int entrarGerencia()
        {

            int opcion;
            Console.WriteLine("………");
            Console.WriteLine("Escoja la opción que desee tomar.");
            Console.WriteLine("0. Volver al inicio.");
            Console.WriteLine("1. Mostrar ventas del día.");
            Console.WriteLine("2. Crear pedido para proveedores.");
            Console.WriteLine("………");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
