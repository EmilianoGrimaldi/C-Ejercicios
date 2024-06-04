using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;
        public SistemaOperativo SistemaOperativo { get => sistemaOperativo; }
        protected abstract int Tamanio { get; }
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        //El operador implícito recibirá una lista de aplicaciones y devolverá la instancia de la aplicación que más tamaño tenga.
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int appMaxTam = int.MinValue;
            Aplicacion? aplicacionMaximoTamanio = null;
            foreach (Aplicacion app in listaApp)
            {
                if (app.Tamanio > appMaxTam)
                {
                    appMaxTam = app.Tamanio;
                    aplicacionMaximoTamanio = app;
                }
            }

            return aplicacionMaximoTamanio;
        }

        public virtual string ObtenerInformacionApp()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre -> {nombre}");
            sb.AppendLine($"Sistema Operativo -> {sistemaOperativo}");
            sb.AppendLine($"Tamaño MB -> {Tamanio}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return nombre;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion aplicacion in listaApp)
            {
                if (aplicacion.nombre == app.nombre)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }

            return false;
        }
    }
}
