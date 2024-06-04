using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        List<string> listaCanciones;

        protected override int Tamanio
        {
            get
            {
                int tamanioCanciones = listaCanciones.Count * 2;
                return tamanioMb + tamanioCanciones;
            }
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) : this(nombre, sistemaOperativo, tamanioMb, new List<string>())
        {

        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> listaCanciones) : base(nombre,sistemaOperativo,tamanioMb)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("Lista de canciones");
            foreach (string cancion in listaCanciones)
            {
                    sb.AppendLine(cancion);   
            }
    
            return sb.ToString();
        }
    }    
}
