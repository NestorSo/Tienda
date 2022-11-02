namespace TiendaDeRopa
{
    public class Inventario
    {
        private string color;
        private int talla;
        private string genero;

        public Inventario(string color, int talla, string genero)
        {
            this.color = color;
            this.talla = talla;
            this.genero = genero;
        }

        public string Color { get => color; set => color = value; }
        public int Talla { get => talla; set => talla = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}