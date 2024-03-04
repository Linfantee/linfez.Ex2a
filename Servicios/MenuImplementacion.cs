using linflez.Ex2a.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflez.Ex2a.Servicios
{
    /// <summary>
    /// Implementación que se encarga del prodecimiento de los métodos del menu.
    /// leig - 040324
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        List<ClienteDto> listaInicio = new List<ClienteDto>();
        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("………");
            Console.WriteLine("Escoja la opción que desee tomar.");
            Console.WriteLine("0. Cerrar menú.");
            Console.WriteLine("1. Menú empleado.");
            Console.WriteLine("2. Menú gerencia.");
            Console.WriteLine("………");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;

        }

        public int mostrarEmpleadoYSeleccion()
        {
            int opcion;
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
               
                EmpleadoInterfaz ei = new EmpleadoImplementacion();
                opcion = ei.entrarEmpleado();

                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Calculo total de ventas diario.");
                        ei.diferenciaFechas(listaInicio);
                        break;
                    case 2:
                        Console.WriteLine("Añadir venta.");
                        ei.añadirVenta(listaInicio);
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no es correcta escoja otra.");
                        break;
                        opcion = Convert.ToInt32(Console.ReadLine());
                        return opcion;
                }
            }
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;

        }
        public int mostrarGerenciaYSeleccion()
        {
            int opcion;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                EmpleadoInterfaz ei = new EmpleadoImplementacion();
                opcion = (int)ei.añadirVenta(listaInicio);

                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:

                        break;
                    case 2:
                       
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no es correcta escoja otra.");
                        break;
                        opcion = Convert.ToInt32(Console.ReadLine());

                }
            }
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;

        }


    }
}

