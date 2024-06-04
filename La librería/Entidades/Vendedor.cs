using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        string nombre;
        List<Publicacion> ventas;

        private Vendedor()
        {             
            ventas = new List<Publicacion>();                
        }
        public Vendedor(string nombre):this()
        {          
            this.nombre = nombre;
        }
        /*
         El método ObtenerInformeDeVentas será de clase y retornará la información del vendedor, sus ventas y la ganancia total de las mismas con el siguiente formato:
NOMBRE
--------------------------------------
PUBLICACION: INFORMACION
--------------------------------------
PUBLICACION: INFORMACION

Ganancia Total: $GANANCIA
         */
        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            StringBuilder sb = new StringBuilder();
            float gananciaTotal = 0;
            sb.AppendLine($"{vendedor.nombre}");          
            foreach (var item in vendedor.ventas)
            {
                sb.AppendLine("-----------------");
                sb.AppendLine("PUBLICACION");
                sb.AppendLine(item.ObtenerInformacion());
                gananciaTotal += item.Importe;
            }
            sb.AppendLine($"Ganancia Total: ${gananciaTotal}");
            return sb.ToString();
        }
        /*
         El operador + agregará siempre y cuando haya stock suficiente para realizar una venta del producto, agregando en ese caso la información de la venta a la lista y descontando stock de la publicación.
         */
        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock -= 1;
                return true;
            }
            return false;
        }
    }
}
