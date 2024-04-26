using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacerEntidades
{
    public class Moto : VehiculoTerrestre
    {
        // Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
        short cilindrada;

        public Moto(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cilindrada) :base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public short GetCilindrada()
        {
            return cilindrada;
        }
    }
}
