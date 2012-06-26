using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataPrecios
{
    class ProductoAGranel : Mercaderia
    {
        public float PrecioPorKg { get; set; }
        public float Peso { get; set; }
        
        public virtual float Cobrar()
        {
            return Precio;
        }
    }
}
