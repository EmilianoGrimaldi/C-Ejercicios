namespace Biblioteca.Ejercicio_I04
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }
        public short GetTinta() 
        {
            return tinta;
        }
       
        private void SetTinta(short tinta)
        {
            if (this.tinta >= 0 && this.tinta <= cantidadTintaMaxima )
            {
                this.tinta += tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        /*public bool Pintar(short gasto, out string dibujo)
        {
            
        }*/
    }
}
