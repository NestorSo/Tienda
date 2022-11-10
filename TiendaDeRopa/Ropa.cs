using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
   public class Ropa : Inventario
    {
        private  string talla;
        private   string tipo;
        private int id;
        public Ropa(string color, string genero, int existencia, string tipo, string talla, int id) : base(color, genero, existencia)
        {
            this.talla = talla;
            this.tipo = tipo;
            this.Id = id;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Talla { get => talla; set => talla = value; }
        public int Id { get => id; set => id = value; }

        public override void RegistroInventario()
        {
            List<Ropa> listaRopa = new List<Ropa>();

            foreach (var ropa in listaRopa)
            {
                listaRopa.Add(ropa);    
            } 
            
        }

}
}
