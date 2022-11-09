using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
   public class Ropa : Inventario
    {

        private string tipo;
        public Ropa(string color, int talla, string genero, string tipo) : base(color, talla, genero)
        {
            this.tipo = tipo;
        }

        public string Tipo { get => tipo; set => tipo = value; }
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
