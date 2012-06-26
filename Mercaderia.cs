using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Clase para representar objetos vendibles en un supermercado
 Empaquetados/enlatados/por unidades
 granel/peso
 */
namespace CodeKataPrecios
{
    public class Mercaderia
    {
        public int Id { get; set; }
        public float Precio { get; set; }
        public float Peso { get; set; }

        public virtual float Cobrar()
        {
            return Precio;
        }
    }
}
