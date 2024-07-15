using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supervisor : Empleado
    {
        private static float valorHora;  
        static Supervisor()
        {
            valorHora = 1025.50F;
        }
        private Supervisor(string legajo) : this(legajo, "n/a", new TimeSpan(09, 00, 00))
        {
            //error new Supervisor(legajo);
        }
        public Supervisor(string legajo, string nombre, TimeSpan horaIngreso) : base(legajo, nombre, horaIngreso)
        {         
        }
        public static float ValorHora
        {
            get
            {
                return valorHora;
            }
            set
            {
                if (value > 0)
                {
                    valorHora = value;
                }
                else
                {
                    valorHora = 1025.50F;
                }
            }
        }

        public override string EmitirFactura()
        {
            return $"Factura de: {nombre} {legajo} {horaIngreso} {horaEgreso} {valorHora}\nImporte a facturar: {Facturar()}";
        }
        protected override double Facturar()
        {
            return base.Facturar() * valorHora;
        }

        public static implicit operator Supervisor(string legajo)
        {
            return new Supervisor(legajo);
        }
        //falta toString supervisor 2do error
        public override string ToString()
        {
            return $"{this.GetType().Name} - {legajo} - {nombre}"; 
        }
    }
}
