using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportivaEntidades
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre -> {Nombre}");
            sb.Append($"Fecha nacimiento -> {fechaNacimiento}");

            return sb.ToString();
        }

        // Dos directores técnicos serán iguales si tienen el mismo nombre y fecha de nacimiento
        public static bool operator ==(DirectorTecnico tecnico1, DirectorTecnico tecnico2)
        {
            return (tecnico1.Nombre == tecnico2.Nombre) && (tecnico1.fechaNacimiento == tecnico2.fechaNacimiento);
        }

        public static bool operator !=(DirectorTecnico tecnico1, DirectorTecnico tecnico2)
        {
            return !(tecnico1 == tecnico2);
        }
    }
}
