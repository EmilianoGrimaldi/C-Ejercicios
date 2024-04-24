using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.LaEstanteria
{
    public class Producto
    {
        private string marca;
        private string codigoDeBarra;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public static string MostrarProducto(Producto p)
        { 
            StringBuilder sb = new();
            sb.AppendLine($"Marca: {p.marca}");
            sb.AppendLine($"Codigo de barra: {p.codigoDeBarra}");
            sb.Append($"Precio: {p.precio}");

            return sb.ToString();
        }
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2) 
        {
            if (p1 is null || p2 is null)
            {
                return false;
            }
            return ((p1.marca == p2.marca) | p1.codigoDeBarra == p2.codigoDeBarra);
        }

        public static bool operator !=(Producto p1, Producto p2) 
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string str)
        { 
            return p.marca == str;
        }
        public static bool operator !=(Producto p, string str)
        {
            return !(p == str);
        }
    }
}
