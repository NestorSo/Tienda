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

            ListaRopa = new List<Ropa>();
            ListaZapatos = new List<Zapatos>();

            ListaRopa.Add(new Ropa { color= "rojo", Genero = "Dama", Talla="M", Tipo= "camisa" });
     
            ListaZapatos.Add(new Zapatos { Color = "negro", Genero  = "Hombre", Talla = 40, tipo = "deportivo" });
     




        }
    }
}
