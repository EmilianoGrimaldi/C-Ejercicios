namespace EntidadesMiPrimerCrud
{
    public class Persona
    {
        int id;
        string nombre;
        string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido):this(nombre,apellido)
        {
            this.id = id;
        }
        public int Id { get => id;}
        public string Nombre { get => nombre; set { nombre = value; } }
        public string Apellido { get => apellido; set { apellido = value; } }

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }
    }
}
