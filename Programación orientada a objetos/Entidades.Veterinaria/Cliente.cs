using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Veterinaria
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
        private List<Mascota> mascotas;

        public Cliente(string domicilio, string nombre, string apellido, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            mascotas = new();
        }

        public void SetMascota(Mascota mascotaNueva)
        {
            mascotas.Add(mascotaNueva);
        }
        private string MostrarMascotas()
        {
            string auxiliar = "";
            if (mascotas.Count > 0)
            {
                foreach (var mascota in mascotas)
                {
                    auxiliar += $"{mascota.MostrarDatos()}\n";
                }
            }
            else
            {
                auxiliar = "No hay mascotas cargadas";
            }
            return auxiliar;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Domicilio: {domicilio}");
            sb.AppendLine($"Telefono: {telefono}");
            sb.AppendLine($"Mascotas:");
            sb.Append($"{MostrarMascotas()}");            
            return sb.ToString();
        }
    }
}
