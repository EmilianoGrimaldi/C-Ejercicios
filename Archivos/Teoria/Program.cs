using EntidadesArchivo;
using Serializacion;
namespace Teoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Archivo.Escribir();
                //Console.WriteLine(Archivo.Leer());
                //ArchivoDos.Escribir();
                //Console.WriteLine(ArchivoDos.Leer());
                //Personaje pj1 = new Personaje("Shaco",18);
                //Personaje pj2 = new Personaje("Kayn",15);
                //Personaje pj3 = new Personaje("Lee Sin",10);
                //Console.WriteLine((Serilizadora.Leer()).ToString());
                //List<Personaje> personajes = new();
                /*personajes.Add(pj1);
                personajes.Add(pj2);
                personajes.Add(pj3);*/
                //Serilizadora.Escribir(pj);
                //Serilizadora.Escribir(personajes);
                /* foreach (Personaje item in SerilizadoraXML.LeerLista())
                 {
                     Console.WriteLine(item.ToString());
                 }*/
                Mascota m1 = new("Firulais", "Golden", 2, false, true, new() {"Arroz","Balanceado","Carne"});
                Mascota m2 = new("Coco", "Calle", 2, false, true, new() { "Arroz"});
                Mascota m3 = new("Salem", "Gato", 2, false, false, new() { "Atun", "Whiscat"});
                List<Mascota> mascotas = new();
                mascotas.Add(m1);
                mascotas.Add(m2);
                mascotas.Add(m3);
                SerializacionJSON<List<Mascota>>.Escribir(mascotas);
                foreach (Mascota item in SerializacionJSON<List<Mascota>>.Leer())
                {
                    Console.WriteLine(item.ToString());
                }
                /*SerializacionJSON<Mascota>.Escribir(m1);
                Console.WriteLine(SerializacionJSON<Mascota>.Leer().ToString());*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
            
        }
    }
}
