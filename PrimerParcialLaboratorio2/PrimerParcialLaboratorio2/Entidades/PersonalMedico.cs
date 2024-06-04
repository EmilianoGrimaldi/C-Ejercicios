using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonalMedico : Persona
    {
        List<Consulta> consultas;
        bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            string auxResidente = "NO";
            StringBuilder sb = new StringBuilder();

            if (esResidente)
            {
                auxResidente = "SI";
            }

            sb.AppendLine($"¿Finalizo residencia? {auxResidente}");
            sb.AppendLine($"ATENCIONES");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }
        /*public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {

        }*/
    }
}
