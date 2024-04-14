using System.Xml;

namespace Entidades.Cuenta
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        { 
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {

            return $"Titular: {GetTitular()}\nSaldo: {GetCantidad()}";
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            cantidad -= monto;
        }
    }
}
