using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.VeterinariaArrays
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            vacunas = new Vacuna[3];
        }

        private int BuscarEspacio()
        {

            for (int i = 0; i < vacunas.Length; i++)
            {
                if (vacunas[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        public void SetVacuna(string vacuna)
        {
            int index = BuscarEspacio();
            if (index != -1)
            {
                vacunas[index] = new Vacuna(vacuna);
            }
            else
            {
                Array.Resize(ref vacunas, vacunas.Length + 1);
                vacunas[BuscarEspacio()] = new Vacuna(vacuna);
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} - Especie: {1} - Fecha de Nacimiento: {2}\n\n", nombre, especie, fechaNacimiento.ToString("dd/MM/yyyy"));
            sb.AppendLine("Vacunas:");

            foreach (Vacuna item in vacunas)
            {
                if (item != null)
                {
                    sb.AppendLine(item.GetNombre());
                }
            }

            return sb.ToString();
        }
    }
}
