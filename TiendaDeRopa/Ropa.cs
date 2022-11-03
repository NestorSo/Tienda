using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    internal abstract class Ropa : Inventario
    {
        public Ropa(string color, int talla, string genero) : base(color, talla, genero)
        {
        }
    }
}
