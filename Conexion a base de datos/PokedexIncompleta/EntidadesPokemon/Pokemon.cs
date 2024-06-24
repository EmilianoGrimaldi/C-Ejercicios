namespace EntidadesPokemon
{
    public class Pokemon
    {
        int id;
        string nombre;
        string tipo;
        string entrenador;
        string urlImagen;
        public Pokemon(string nombre, string tipo, string entrenador, string urlImagen)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.entrenador = entrenador;
            this.urlImagen = urlImagen;
        }
        public Pokemon(int id, string nombre, string tipo, string entrenador, string urlImagen) : this(nombre,tipo, entrenador,urlImagen)
        {
            this.id = id;     
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        public string UrlImagen { get => urlImagen; set => urlImagen = value; }
    }
}
