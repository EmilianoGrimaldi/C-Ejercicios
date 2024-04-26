using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacerEntidades
{
    public class Automovil : VehiculoTerrestre
    {
        //Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
        short cantidadDeMarchas;
        int cantidadPasajeros;

        public Automovil(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cantidadDeMarchas, int cantidadPasajeros):base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            this.cantidadDeMarchas = cantidadDeMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
