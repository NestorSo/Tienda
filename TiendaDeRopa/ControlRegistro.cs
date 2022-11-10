using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa
{
    internal class ControlRegistro
    {
        public List<Ropa> ListaRopa;
        public List<Zapatos> ListaZapatos;
        public ControlRegistro()
        {
            ListaRopa = new List<Ropa>();
            ListaZapatos = new List<Zapatos>();

            ListaRopa.Add(new Ropa { Color= "rojo",Tipo = "camisa" ,Talla= "s",Genero= "Mujer"});
            ListaRopa.Add(new Ropa  { id = 2, nombre = "Microsoft" });
            ListaRopa.Add(new Ropa  { id = 3, nombre = "Sony" });
            ListaRopa.Add(new Ropa { id = 4, nombre = "Apple" });


   

        }
    }
}
