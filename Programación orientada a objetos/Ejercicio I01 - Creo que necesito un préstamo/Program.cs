using Entidades.Cuenta;
/*
 Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
 */
namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new("Pepe", 40000);
            Cuenta cuenta2 = new("Mario", 160000);
            Console.WriteLine("Original");
            Console.WriteLine("------------------------");
            Console.WriteLine($"{cuenta1.Mostrar()}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"{cuenta2.Mostrar()}");
            Console.WriteLine("------------------------");
            Console.WriteLine("Retiro");
            Console.WriteLine("------------------------");
            cuenta1.Retirar(10000);
            cuenta2.Retirar(50000);
            Console.WriteLine($"{cuenta1.Mostrar()}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"{cuenta2.Mostrar()}");
            Console.WriteLine("------------------------");
            Console.WriteLine("Ingreso");
            Console.WriteLine("------------------------");
            cuenta1.Ingresar(20000);
            cuenta2.Ingresar(30000);
            Console.WriteLine($"{cuenta1.Mostrar()}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"{cuenta2.Mostrar()}");
        }
    }
}
