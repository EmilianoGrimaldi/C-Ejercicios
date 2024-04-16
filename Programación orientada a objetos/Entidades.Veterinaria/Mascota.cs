using System.Text;

namespace Entidades.Veterinaria
{
    public class Mascota
    {
        /*
        De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.
        */
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private List<string> vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            vacunas = new();
        }

        public void SetVacuna(string vacuna)
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
                auxiliar = string.Join(", ",vacunas);
            }
            else
            {
                auxiliar = "No tiene";
            }
            return auxiliar;
        }
    }
}
