using EntidadesIndice;
namespace I02___Consultaste_el_índice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Jon I";
            libro[1] = "Daenerys II";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Tyrion III";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
