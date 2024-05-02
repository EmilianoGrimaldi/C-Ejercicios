namespace AtencionAlCliente
{
    public class Cliente
    {
        string nombre;
        int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero;}

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1.numero == c2.numero)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
