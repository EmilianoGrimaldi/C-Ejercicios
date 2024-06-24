namespace Entidades
{
    public class Juego
    {
        string nombre;
        double precio;
        string genero;
        int codigoJuego;
        int codigoUsuario;

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario, int codigoJuego) : this(nombre, precio, genero, codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        public int CodigoJuego { get => codigoJuego; }
        public int CodigoUsuario { get => codigoUsuario;}
        public string Genero { get => genero;}
        public string Nombre { get => nombre; }
        public double Precio { get => precio; }
    }
}
