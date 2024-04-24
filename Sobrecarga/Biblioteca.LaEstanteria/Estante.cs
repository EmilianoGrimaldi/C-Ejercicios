using System.Reflection.Metadata;
using System.Text;

namespace Biblioteca.LaEstanteria
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        { 
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion):this(capacidad)
        { 
            ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos() 
        { 
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new();
            sb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");
            sb.AppendLine($"Productos:");
            
            foreach (var producto in e.GetProductos())
            { 
                sb.AppendLine(Producto.MostrarProducto(producto));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (var producto in e.GetProductos())
            {
                if (producto == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
