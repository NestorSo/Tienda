namespace TiendaDeRopa
{
    public abstract class Inventario
    {
        public  string color;
        public string genero;
        private int existencia;
        private int precio;

        public Inventario(string color, string genero, int existencia, int precio)
        {
            this.color = color;
            this.genero = genero;
            this.Existencia = existencia;
            this.Precio = precio;
        }

      

        public string Color { get => color; set => color = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public int Precio { get => precio; set => precio = value; }

        public abstract void RegistroInventario();
        

        
    }
}