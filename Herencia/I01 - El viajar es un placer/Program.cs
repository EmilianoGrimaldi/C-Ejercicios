/*
 Crear un proyecto de biblioteca de clases con las clases Automovil, Moto, Camion.

Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
Crearle a cada clase un constructor que reciba todos sus atributos.
Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores. Luego generar una relación de herencia entre ellas, según corresponda.
VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las clases que heredan de ésta para que lo reutilicen.
Crear un proyecto de consola y generar el código necesario para probar las clases.
 */

using ElViajarEsUnPlacerEntidades;
namespace I01___El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Camion camioncito = new Camion(8, 2, Colores.Azul, 8, 5000);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.GetCantidadRuedas(), camioncito.GetCantidadPuertas(), camioncito.GetColor(), camioncito.GetCantidadMarchas(), camioncito.GetPesoCarga());
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, Colores.Blanco,  5, 3);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.GetCantidadRuedas(), autito.GetCantidadPuertas(), autito.GetColor(), autito.GetCantidadMarchas(), autito.GetCantPasajeros());
            Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, Colores.Rojo, 1000);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.GetCantidadRuedas(), motito.GetCantidadPuertas(), motito.GetColor(), motito.GetCilindrada());
        }
    }
}
