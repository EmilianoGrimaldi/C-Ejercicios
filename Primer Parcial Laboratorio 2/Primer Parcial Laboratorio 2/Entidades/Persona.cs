using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected DateTime nacimiento;
        protected string barrioResidencia;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get
            { 
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }      
        }

        public string NombreCompleto
        {
            get
            {
                return $"{apellido}, {nombre}";
            }
        }

        public override string ToString()
        {
            return $"{apellido}, {nombre}";
        }
        public string FichaPersona(Persona p)
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{p.ToString()}");
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine($"Nacimiento: {p.nacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Barrio residencial: {p.barrioResidencia}");

            return sb.ToString();       
        }
        internal abstract string FichaExtra();
    }
}
