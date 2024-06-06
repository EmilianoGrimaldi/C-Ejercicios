using System.Drawing;

namespace I01___Cartuchera
{
    public class Boligrafo : IAcciones
    {
        ConsoleColor colorTinta;
        float tinta;

        public Boligrafo(float tinta, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }
        ConsoleColor IAcciones.Color { get { return colorTinta; } set { colorTinta = value; } }
        float IAcciones.UnidadesDeEscritura 
        { 
            get 
            { 
                return tinta; 
            } 
            set 
            {
                tinta = value;                        
            } 
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float tintaGastada = ((float)texto.Length) * 0.3f;
            tinta -= tintaGastada;
            return new EscrituraWrapper(colorTinta, texto);
        }

        bool IAcciones.Recargar(int unidades)
        {
            if (tinta <= 0)
            {
                tinta = unidades;
            }          
            return true;
        }
        public override string ToString()
        {
            return $"Boligrafo {colorTinta} {tinta}";
        }
    }
}
