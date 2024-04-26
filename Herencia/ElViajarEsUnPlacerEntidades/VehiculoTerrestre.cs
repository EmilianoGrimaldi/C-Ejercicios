namespace ElViajarEsUnPlacerEntidades
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }
    public class VehiculoTerrestre
    {
        protected short cantidadDeRuedas;
        protected short cantidadDePuertas;
        protected Colores color;

        public VehiculoTerrestre(short cantidadDeRuedas, short cantidadDePuertas, Colores color)
        {
            this.cantidadDeRuedas = cantidadDeRuedas;
            this.cantidadDePuertas = cantidadDePuertas;
            this.color = color;
        }
        public short GetCantidadRuedas()
        {
            return cantidadDeRuedas; 
        }
        public short GetCantidadPuertas()
        {          
            return cantidadDePuertas;
        }
        public Colores GetColor()
        {
            return color;        
        }
    }
}
