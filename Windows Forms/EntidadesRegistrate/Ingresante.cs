using System.Text;

namespace EntidadesRegistrate
{
    public class Ingresante
    {
        string nombre;
        string direccion;
        string genero;
        string pais;
        string[] cursos;
        int edad;
        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre -> {nombre}");
            sb.AppendLine($"Direccion -> {direccion}");
            sb.AppendLine($"Genero -> {genero}");
            sb.AppendLine($"Pais -> {pais}");
            sb.AppendLine($"Edad -> {edad}");
            sb.AppendLine($"Cursos"); 
            foreach (string curso in cursos)
            {
                if (curso is not null)
                {
                    sb.AppendLine(curso);
                }
            }
            return sb.ToString();
        }
    }
}
