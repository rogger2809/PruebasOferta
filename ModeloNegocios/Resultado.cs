using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocios
{
    public class Resultado
    {
        public int? IdProducto { get; set; }
        public int? CantidadSolicitada { get; set; }
        public int? CantidadAsignada { get; set; }
        public int? Residuo { get; set; }
        public int? CantidadDisponible { get; set; }
        public int? Lote { get; set; }

        public Resultado()
        {
            IdProducto = 0;
            CantidadSolicitada = 0;
            CantidadAsignada = 0;
            Residuo = 0;
            CantidadDisponible = 0;
            Lote = 0;
        }
    }
}
