using Entidades.Veterinaria;
/*
 Crear una aplicación de consola.
Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
Instanciar los siguientes objetos:
Un cliente con un perro sin vacunar.
Un cliente con un gato con la vacuna "Triple Felina".
Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
 */
namespace A02___La_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new("Lalala", "Robert", "Lewandowski", 12345678);
            Mascota mascota1 = new("Perro", "Firulais", new(2020,4,4));

            Cliente cliente2 = new("Lalala", "Lionel", "Messi", 12345678);
            Mascota mascota2 = new("Gato", "Garfield", new(2022, 12, 21));

            Cliente cliente3 = new("Lalala", "Rodrigo", "Rey", 12345678);
            Mascota mascota3 = new("Gato", "Salem", new(2024, 1, 31));
            Mascota mascota4 = new("Perro", "Sam", new(2020,7,14));

            cliente1.SetMascota(mascota1);
            cliente2.SetMascota(mascota2);
            mascota2.SetVacuna("Triple Felina");
            cliente3.SetMascota(mascota3);
            cliente3.SetMascota(mascota4);
            mascota4.SetVacuna("Rabia");

            Console.WriteLine(cliente1.MostrarDatos());
            Console.WriteLine(cliente2.MostrarDatos());
            Console.WriteLine(cliente3.MostrarDatos());



        }
    }
}
