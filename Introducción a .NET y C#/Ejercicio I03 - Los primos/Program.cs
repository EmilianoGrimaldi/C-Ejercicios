/*
 Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/
namespace Ejercicio_I03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool esNumero = false;
            string dato = "";
            bool esPrimo;
            string continuar = "";
            
            do 
            {
                Console.WriteLine("Ingresar un numero o ingrese salir");
                while (dato != "salir") 
                {
                    dato = Console.ReadLine().ToLower();
                    esNumero = int.TryParse(dato, out numero);

                    if (esNumero || dato == "salir")
                    {
                        if (numero > 1)
                        {
                            for (int i = 2; i <= numero; i++)
                            {
                                esPrimo = true;
                                for (int j = 2; j < i; j++)
                                {
                                    if (i % j == 0)
                                    {
                                        esPrimo = false;
                                        break;
                                    }
                                }

                                if (esPrimo)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! El numero debe ser mayor a 2");
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error! Debe ingresar un numero");
                    }
                }
               

                do
                {
                    Console.WriteLine("Desea continuar? si/no");
                    continuar = Console.ReadLine().ToLower();
                    if (continuar == "si" || continuar == "no")
                    {
                        break;
                    }
                } while (true);
            } while (continuar == "si");
            
        }
    }
}
