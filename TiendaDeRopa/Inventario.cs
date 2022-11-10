namespace TiendaDeRopa
{
    public abstract class Inventario
    {
        public  string color;
        public string genero;
        private int existencia;

        public Inventario(string color, string genero, int existencia)
        {
            this.color = color;
            this.genero = genero;
            this.Existencia = existencia;
        }

        protected Inventario(string color, string genero)
        {
            this.color = color;
            this.genero = genero;
        }

        public string Color { get => color; set => color = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Existencia { get => existencia; set => existencia = value; }

        public abstract void RegistroInventario();
        

        
    }
}