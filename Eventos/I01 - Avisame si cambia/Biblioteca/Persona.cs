namespace Biblioteca
{
    public delegate void DelegadoString(string msg);
    
    public class Persona
    {
        public event DelegadoString EventoString;

        string apellido;
        string nombre;
        public Persona()
        {
            
        }

        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mostrar()
        {
            return $"{nombre} {apellido}";
        }

        public void EventoStringMsg(string msg)
        {
            if (EventoString is not null)
            {
                EventoString.Invoke(msg);
            }
        }
    }
}
