using System.Diagnostics;

namespace Biblioteca
{
    public static class Estancion
    {
        public enum Estaciones
        {
            Invierno,
            Otonio,
            Primavera,
            Verano
        }

        public static string ObtenerPlacaCronicaTV(this DateTime fecha, Estaciones estacion)
        {
            string aux = string.Empty;
            int anioActual = fecha.Year;
            double dias = default;
            DateTime invierno = new DateTime(anioActual, 6, 21);
            DateTime primavera = new DateTime(anioActual, 9, 21);
            DateTime verano = new DateTime(anioActual, 12, 21);
            DateTime otonio = new DateTime(anioActual, 3, 21);

            if (estacion == Estaciones.Invierno)
            {
                if (fecha < invierno)
                {
                    dias = invierno.Subtract(fecha).TotalDays;
                }
                else
                {
                    fecha = fecha.AddYears(1);
                    dias = fecha.Subtract(invierno).TotalDays;
                }

                aux = $"Faltan {dias} dias para el invierno";
            }
            else if (estacion == Estaciones.Primavera)
            {
                if (fecha < primavera)
                {
                    dias = primavera.Subtract(fecha).TotalDays;
                }
                else
                {
                    fecha = fecha.AddYears(1);
                    dias = fecha.Subtract(primavera).TotalDays;
                }

                aux = $"Faltan {dias} dias para el primavera";
            }    
            else if (estacion == Estaciones.Verano)
            {
                if (fecha < verano)
                {
                    dias = verano.Subtract(fecha).TotalDays;
                }
                else
                {
                    fecha = fecha.AddYears(1);
                    dias = fecha.Subtract(verano).TotalDays;
                }

                aux = $"Faltan {dias} dias para el verano";
            }
            else
            {
                if (fecha < otonio)
                {
                    dias = otonio.Subtract(fecha).TotalDays;
                }
                else
                {
                    fecha = fecha.AddYears(1);
                    dias = fecha.Subtract(otonio).TotalDays;
                }

                aux = $"Faltan {dias} dias para el otoño";
            }

            return aux;
        }
    }
}
