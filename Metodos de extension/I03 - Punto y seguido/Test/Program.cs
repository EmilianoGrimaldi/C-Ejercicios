using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "He buscado todas las opciones posibles; sin embargo, todavía no he dado con la correcta. Quizás si pongo un lazo aquí, quito esto y sumo aquello pueda quedar bien.";
            Console.WriteLine(texto.ContarSignosPuntuacion());
        }
    }
}
