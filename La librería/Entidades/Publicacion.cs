using System.Text;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected string nombre;
        protected int stock;
        protected float importe;

        protected abstract bool EsColor { get; }
        /*
         La propiedad HayStock será virtual, retornará true siempre y cuando haya stock y el importe sea mayor a 0 (cero).
         */
        public virtual bool HayStock 
        {
            get
            {
                if (stock == 0)
                {
                    return false;
                }
                if (stock > 0 && importe > 0)
                {
                    return true;
                }

                return false;
            }
        }
        public float Importe { get { return importe; } }
        /*
         La propiedad Stock solo asignará si lo recibido es mayor a 0 (cero).
         */
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
            }
        }
        /*
         El método ObtenerInformacion retornará los datos de la Publicacion utilizando StringBuilder (deberá utilizar todos los métodos Append disponibles). Completar las palabras en mayúscula con los datos de cada elemento según corresponda:
         */
        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            string auxiliar = "No";
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Stock: {stock}");
            if (EsColor)
            {
                auxiliar = "Si";
            }           
            sb.AppendLine($"Es color: {auxiliar}");
            sb.Append($"Valor: ${importe}");
            return sb.ToString();
        }
        public Publicacion(string nombre)
        { 
            this.nombre = nombre;
        } 
        public Publicacion(string nombre, int stock):this(nombre)
        { 
            this.stock = stock;
        }
        public Publicacion(string nombre, int stock, float importe):this(nombre, stock)
        { 
            this.importe = importe;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
