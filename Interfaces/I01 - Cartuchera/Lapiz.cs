using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___Cartuchera
{
    public class Lapiz : IAcciones
    {
        float tamanioMina;

        public Lapiz(float unidades)
        {
            tamanioMina = unidades;
        }
        public ConsoleColor Color { get { return ConsoleColor.Gray; } set { throw new NotImplementedException(); } }
        public float UnidadesDeEscritura { get { return tamanioMina; } set { tamanioMina = value; } }
        public EscrituraWrapper Escribir(string texto)
        {
            float minaConsumida = ((float)texto.Length) * 0.1f;
            tamanioMina -= minaConsumida;
            return new EscrituraWrapper(Color,texto);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Lapiz {Color} {tamanioMina}";
        }
    }
}
