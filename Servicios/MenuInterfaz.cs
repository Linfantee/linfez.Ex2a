using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflez.Ex2a.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de llamar a los métodos de la implementación.
    /// leig - 040324
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que se encarga de mostrar el menú y la selección del usuario.
        /// leig - 040324
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Método que se encarga de tomar la elección del usuario y entrar en la parte de empleados.
        /// leig - 040324
        /// </summary>
        /// <returns></returns>
        public int mostrarEmpleadoYSeleccion();

        /// <summary>
        /// Método que se encarga de tomar la elección del usuario y entrar en la parte de gerencia.
        /// leig - 040324
        /// </summary>
        /// <returns></returns>
        public int mostrarGerenciaYSeleccion();
    }
}
