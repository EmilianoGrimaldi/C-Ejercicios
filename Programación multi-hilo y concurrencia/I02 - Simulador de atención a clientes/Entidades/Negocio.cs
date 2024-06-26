using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        static RealNameGenerator realNameGenerator;
        static Random random;
        ConcurrentQueue<string> clientes;
        List<Caja> cajas;

        static Negocio()
        {
            realNameGenerator = new RealNameGenerator();
            random = new Random();
        }

        public Negocio(List<Caja> cajas)
        {
            clientes = new();
            this.cajas = cajas;
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> tasks = new List<Task>();
            foreach (Caja item in cajas)
            {
                tasks.Add(item.IniciarAtencion());
            }
            Task task = Task.Run(SimularClientes);
            Task task2 = Task.Run(AsignarClienteCaja);
            tasks.Add(task);
            tasks.Add(task2);

            return tasks;
        }

        public void SimularClientes()
        {
            while (true) 
            {
                clientes.Enqueue(realNameGenerator.Generate());
                Thread.Sleep(random.Next(1000));
            }
        }
        public void AsignarClienteCaja()
        {
            while (true)
            {
                IEnumerable<Caja> cajasOrdenada = cajas.OrderBy(caja => caja.CantidadDeClientesALaEspera);
                Caja caja = cajasOrdenada.First();
                string cliente;
                if (clientes.TryDequeue(out cliente) && !string.IsNullOrEmpty(cliente) && cliente is not null)
                {
                    caja.AgregarCliente(cliente);
                }             
            }
        }
    }
}
