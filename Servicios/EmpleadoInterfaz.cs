using linflez.Ex2a.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflez.Ex2a.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de llamar a los métodos del empleado.
    /// leig - 040324
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// Método que se encarga de mostrar el menú y la selección del empleado.
        /// </summary>
        /// <returns></returns>
        public int entrarEmpleado();

        /// <summary>
        /// Método que se encarga de realizar la venta del empleado.
        /// leig - 040324
        /// </summary>
        public long añadirVenta(List<ClienteDto> list);

        /// <summary>
        /// Método que se encarga de realizar la diferencia de fechas de la compra.
        /// leig - 040324
        /// </summary>
        public int diferenciaFechas(List<ClienteDto> list);

    }
}
