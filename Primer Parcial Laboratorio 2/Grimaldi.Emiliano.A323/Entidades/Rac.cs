using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rac : Empleado
    {
        public enum EGrupo
        {
            CALL_IN,
            CALL_OUT,
            RRSS
        }
        protected EGrupo eGrupo;
        protected static double valorHora;

        static Rac()
        {
            valorHora = 875.90F;
        }
        public Rac(string legajo, string nombre, TimeSpan horaIngreso): base(legajo, nombre, horaIngreso)
        {
        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo eGrupo) : base(legajo, nombre, horaIngreso)
        {
            this.eGrupo = eGrupo;
        }

        public EGrupo Grupo
        {
            get
            {
                return eGrupo;
            }
        }
        public double ValorHora
        {
            get
            {
                return valorHora;
            }
            set
            {
                if (value > 0 )
                {
                    valorHora = value;
                }
                else
                {
                    valorHora = 875.90F;
                }
            }
        }
        public override string EmitirFactura()
        {
            return $"Factura de: {nombre} {legajo} {horaIngreso} {horaEgreso} {eGrupo} {valorHora}\nImporte a facturar: ${Facturar()}.";
        }
        private double CalcularBonoDeGrupo()
        {
            if (EGrupo.CALL_IN == eGrupo)
            {
                return 0;
            }
            else
            {
                if (EGrupo.CALL_OUT == eGrupo)
                {
                    return 0.1;
                }
                else
                {
                    return 0.2;
                }
            }
        }
        protected override double Facturar()
        {
            double valorHoraConBono = CalcularBonoDeGrupo();
            return base.Facturar() * valorHoraConBono;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {eGrupo} - {legajo} - {nombre}";
        }
    }
}
