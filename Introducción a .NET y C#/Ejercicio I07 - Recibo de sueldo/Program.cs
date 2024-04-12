/*
 Consigna
Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.

No es necesario ni se deben utilizar vectores/arrays.
 */
using System.Text.RegularExpressions;

namespace Ejercicio_I07___Recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            string nombre;
            string antiguedad;
            int aniosAntiguedad;
            int cantidadHoras;
            string continuar;
            decimal importeBruto;
            decimal descuento;
            decimal porcentaje = 13;
            decimal importeNeto;
            do
            {
                do
                {
                    Console.WriteLine("Ingresar valor hora");
                    if (float.TryParse(Console.ReadLine(), out valorHora))
                    {
                        do
                        {
                            Console.WriteLine("Ingresar su nombre");
                            nombre = Console.ReadLine().ToLower();
                            bool soloLetras = Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
                            if (soloLetras)
                            {
                                do
                                {
                                    Console.WriteLine("Ingresar antiguedad en años");
                                    antiguedad = Console.ReadLine();
                                    bool esAnio = Regex.IsMatch(antiguedad, @"^[1-9]{1}$|^[1-9]{1}[0-9]{1}$");
                                    if (esAnio)
                                    {
                                        aniosAntiguedad = int.Parse(antiguedad);
                                        do
                                        {
                                            Console.WriteLine("Ingresar cantidad de horas trabajadas en el mes");
                                            if (int.TryParse(Console.ReadLine(), out cantidadHoras))
                                            {
                                                break;
                                            }

                                        } while (true);
                                        break;
                                    }

                                } while (true);
                                break;
                            }

                        } while (true);

                        break;
                    }
                } while (true);
                descuento = porcentaje / 100;
                importeBruto = (decimal)((valorHora * cantidadHoras) + (aniosAntiguedad * 150));
                importeNeto = importeBruto - (importeBruto * descuento);

                Console.WriteLine($"Nombre: {nombre}\nAntiguedad: {aniosAntiguedad}\nValor hora: {valorHora}\nTotal neto: {importeBruto}\nTotal bruto: {importeNeto}");
                Console.ReadLine();

                do
                {
                    Console.WriteLine("Desea continuar cargando? s/n");
                    continuar = Console.ReadLine();
                    if (continuar == "s" || continuar == "n")
                    {
                        break;
                    }
                } while (true);
                
            } while (continuar != "n");        
        }
    }
}
