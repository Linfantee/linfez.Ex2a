using linflez.Ex2a.Dtos;
using linflez.Ex2a.Servicios;

namespace linflez.Ex2a;
/// <summary>
/// Clase principal de nuestra aplicación.
/// leig - 040324
/// </summary>
class Program
{
    /// <summary>
    /// leig - método principal de nuestra aplicación.
    /// 040324
    /// </summary>
    /// <param name="args"></param>
  

    public static void Main(string[] args)
    {
        
        MenuInterfaz mi = new MenuImplementacion();
        int eleccion;
        bool cerrarMenu = false;

        while (!cerrarMenu)
        {
            eleccion = mi.mostrarMenuYSeleccion();
           
            switch(eleccion)
            {
                case 0:
                    cerrarMenu = true;
                    break;
                case 1:
                    Console.WriteLine("Has entrado en empleados.");
                    mi.mostrarEmpleadoYSeleccion();
                    break;
                case 2:
                    Console.WriteLine("Has entrado en gerencia.");
                    mi.mostrarGerenciaYSeleccion();    
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no es correcta escoja otra.");
                    break;
                    eleccion = Convert.ToInt32(Console.ReadLine());

            }

        }

    }

}
