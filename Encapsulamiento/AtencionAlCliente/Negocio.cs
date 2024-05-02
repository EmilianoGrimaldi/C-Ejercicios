using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;
        public Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            /*
             La propiedad Cliente retornará el próximo cliente en la cola de atención en el get. El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
             */
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            /*El operador == retornará true si el cliente se encuentra en la colección.*/
            if (n is not null && c is not null)
            {
                foreach (Cliente cliente in n.clientes)
                {
                    if (cliente == c)
                    {
                        return true;
                    }
                }
            }  
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }           
            return false;
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }
    }
}
