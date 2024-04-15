namespace Geometria.Ejercicio_I04
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
            short total = Convert.ToInt16(this.tinta + tinta);
            if (total >= 0 && total <= cantidadTintaMaxima )
            {         
                  this.tinta += tinta;
            }
        }
        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - tinta));
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            bool sePudoPintar = false;
            if (tinta > 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                    SetTinta(-1);
                    if (tinta == 0)
                    {
                        break;
                    }
                }
            }
            
            if (dibujo.Length > 0)
            {
                sePudoPintar = true;
                Console.ForegroundColor = color;
            }

            return sePudoPintar;
        }
    }
}
