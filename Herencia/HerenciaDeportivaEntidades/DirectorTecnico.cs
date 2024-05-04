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

        private DirectorTecnico(string nombre) : base(nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre -> {nombre}");
            sb.AppendLine($"Fecha nacimiento -> {fechaNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        // Dos directores técnicos serán iguales si tienen el mismo nombre y fecha de nacimiento
        public static bool operator ==(DirectorTecnico tecnico1, DirectorTecnico tecnico2)
        {
            return (tecnico1.nombre == tecnico2.nombre) && (tecnico1.fechaNacimiento == tecnico2.fechaNacimiento);
        }

        public static bool operator !=(DirectorTecnico tecnico1, DirectorTecnico tecnico2)
        {
            return !(tecnico1 == tecnico2);
        }
    }
}
