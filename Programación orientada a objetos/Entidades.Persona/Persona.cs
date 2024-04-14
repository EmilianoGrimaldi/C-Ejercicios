using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades.Persona
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }
        
        public string GetFechaNacimiento() 
        {
            return fechaDeNacimiento.ToString("dd/MM/yyyy");
        }

        public int GetDni() 
        {
            return dni;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public void SetDni(int dni) 
        {
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            DateTime anioActual = DateTime.Now;
            return anioActual.Year - fechaDeNacimiento.Year;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaNacimiento()}");
            sb.AppendLine($"Dni: {GetDni()}");
            sb.AppendLine($"Edad: {CalcularEdad()}");
            sb.AppendLine($"{EsMayorDeEdad()}");
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            if (CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }

            return "Es menor";
        }
    }
}
