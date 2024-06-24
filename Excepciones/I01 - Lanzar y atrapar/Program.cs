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
                Console.WriteLine("Mensajes excepciones");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Excepciones");
                Console.WriteLine(ex.InnerException);                                   
            }
            
        }
    }
}
