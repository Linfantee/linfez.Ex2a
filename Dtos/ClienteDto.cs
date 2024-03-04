using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflez.Ex2a.Dtos
{
    /// <summary>
    /// Clase que tiene la información de la lista.
    /// leig - 040324
    /// </summary>
    internal class ClienteDto
    {

        int idventa;
        long importe;
        DateTime fchinstante;


        public int Idventa { get => idventa; set => idventa = value; }
        public long Importe { get => importe; set => importe = value; }
        public DateTime Fchinstante { get => fchinstante; set => fchinstante = value; }


        public ClienteDto(int idventa, long importe, DateTime fchinstante)
        {
            this.idventa = idventa;
            this.importe = importe;
            this.fchinstante = fchinstante;
        }
    }
}
