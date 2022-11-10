using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
   public class Ropa : Inventario
    {
        private string talla;
        private string tipo;
        public Ropa(string color, string genero, string tipo, string talla) : base(color, genero)
        {
            this.Talla = talla;
            this.tipo = tipo;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Talla { get => talla; set => talla = value; }

        List<Ropa> listaRopa = new List<Ropa>();

        public override void RegistroInventario()
        {
            
            foreach (var ropa in listaRopa)
            {
                listaRopa.Add(ropa);
            }
        }

}
}
