using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacerEntidades
{
    public class Camion : VehiculoTerrestre
    {
        //Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
        short cantidadDeMarchas;
        int pesoCarga;

        public Camion(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cantidadDeMarchas, int pesoCarga) : base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            this.cantidadDeMarchas = cantidadDeMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
