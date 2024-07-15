using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empleado
    {
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;
        protected string legajo;
        protected string nombre;

        protected Empleado(string legajo, string nombre,TimeSpan horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public TimeSpan HoraEgreso { get { return horaEgreso; } set { horaEgreso = ValidarHoraEgreso(value); } }
        public TimeSpan HoraIngreso { get { return horaIngreso; } }
        public string Legajo { get { return legajo; } }
        public string Nombre { get { return nombre; } }
        public abstract string EmitirFactura();
        private TimeSpan ValidarHoraEgreso(TimeSpan horaEgreso) 
        {
            if (horaEgreso.Hours > this.HoraIngreso.Hours)
            {
                return horaEgreso;
            }

            return DateTime.Now.TimeOfDay;
        }
        protected virtual double Facturar()
        {
            return horaIngreso.TotalHours - horaEgreso.TotalHours;
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            return emp1.legajo == emp2.legajo;
        }
        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
