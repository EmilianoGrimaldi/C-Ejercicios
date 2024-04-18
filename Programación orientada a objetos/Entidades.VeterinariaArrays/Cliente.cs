using System.Text;

namespace Entidades.VeterinariaArrays
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            mascotas = new Mascota[3];
        }
        private int BuscarEspacio()
        {

            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] == null)
                {
                    return i;
                }     
            }

            return -1;
        }

        public void SetMascota(Mascota mascotaNueva)
        {
            int index = BuscarEspacio();
            if (BuscarEspacio() != -1)
            {
                mascotas[index] = mascotaNueva;
            }
            else
            {
                Array.Resize(ref mascotas, mascotas.Length + 1);
                mascotas[index] = mascotaNueva;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} - Apellido: {1} - Domicilio: {2} - Telefono: {3}\n\n", nombre, apellido, domicilio, telefono);
            sb.AppendLine("Mascotas:\n");

            foreach (Mascota item in mascotas)
            {
                if (item != null)
                {
                    sb.AppendLine(item.MostrarDatos());
                }  
            }
            return sb.ToString();
        }
    }
}
