using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataPrecios
{
    class ProductoAtomico:Mercaderia
    {
        public float PrecioUnitario { get; set; }

        public virtual float Cobrar()
        {
            return PrecioUnitario;
        }
    }
}
