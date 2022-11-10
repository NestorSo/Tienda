namespace TiendaDeRopa
{
    public abstract class Inventario
    {
        private string color;
        private string genero;

        public Inventario(string color, string genero)
        {
            this.color = color;
            this.genero = genero;
        }

        public string Color { get => color; set => color = value; }
        public string Genero { get => genero; set => genero = value; }

        public abstract void RegistroInventario();
        

        
    }
}