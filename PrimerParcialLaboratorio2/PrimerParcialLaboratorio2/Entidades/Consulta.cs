using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        DateTime fecha;
        Paciente paciente;
        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        public DateTime Fecha { get => fecha; }
        public Paciente Paciente { get => paciente; }
        public override string ToString() 
        {
            return $"{fecha.ToString("dd/MM/yyyy")} se ha atendido a {paciente.ToString()}";
        }
    }
}
