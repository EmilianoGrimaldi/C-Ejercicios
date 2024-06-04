using Entidades01;

namespace I01___Lanzar_y_atrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new();
                otraClase.MetodoInstancia();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);                                   
            }
            
        }
    }
}
