using System.Text;

namespace Entidades
{
    public class CentroDeAtencion
    {
        int cantidadRacsPorSuper;
        List<Empleado> empleados;
        string nombre;

        public CentroDeAtencion(string nombre, int cantidadRacsPorSuper)
        {
            this.nombre = nombre;
            this.cantidadRacsPorSuper = cantidadRacsPorSuper;
            empleados = new();
        }

        public List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public static bool operator ==(CentroDeAtencion c, Empleado e)
        {
            if (c.empleados is not null)
            {
                foreach (Empleado empleado in c.empleados)
                {
                    if (empleado == e)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(CentroDeAtencion c, Empleado e)
        {
            return !(c == e); 
        } 
        private bool ValidaCantidadDeRacs() 
        {
            int contadorRacs = 0;
            foreach (Empleado empleado in empleados)
            {
                if (empleado is Rac)
                {
                    contadorRacs += 1;
                }
            }

            if (contadorRacs > cantidadRacsPorSuper)
            {
                return true;
            }
            return false;     
        }
        public static bool operator +(CentroDeAtencion c, Empleado e)
        {
            if (c != e)
            {
                c.empleados.Add(e);
                return true;
            }
            return false;
        }

        public static string operator -(CentroDeAtencion c, Empleado e) 
        {
            string msj = "Empleado no encontrado";

            if (c == e) 
            {
                e.HoraEgreso = DateTime.Now.TimeOfDay;
                msj = e.EmitirFactura(); 
                c.empleados.Remove(e);
                msj = "Empleado removido";
            }
            
            return msj;
        }

        public string ImprimirNomina()
        {
            StringBuilder sb = new();
            if (empleados is not null)
            {
                foreach (Empleado empleado in empleados)
                {
                    sb.AppendLine(empleado.EmitirFactura());
                }        
            }
            return sb.ToString();
        }
    }
}
