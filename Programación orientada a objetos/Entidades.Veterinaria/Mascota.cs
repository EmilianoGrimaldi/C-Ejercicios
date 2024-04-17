using System.Text;

namespace Entidades.Veterinaria
{
    public class Mascota
    {
        
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private List<Vacuna> vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            vacunas = new();
        }

        public void SetVacuna(Vacuna vacuna)
        {
            vacunas.Add(vacuna);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($" Especie -> {especie}");
            sb.AppendLine($" Nombre -> {nombre}");
            sb.AppendLine($" Fecha de nacimiento -> {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($" Vacunas -> {MostrarVacunas()}");
            return sb.ToString();
        }
        private string MostrarVacunas()
        {
            string auxiliar = "";
            if (vacunas.Count > 0)
            {
                auxiliar = SepararVacunas(", ");
            }
            else
            {
                auxiliar = "No tiene";
            }
            return auxiliar;
        }

        private string SepararVacunas(string separador)
        {
            List<string> vacs = new();

            foreach (var vac in vacunas)
            {
                vacs.Add(vac.GetNombre());
            }

            return string.Join(separador, vacs);
        }
    }
}
