using EntidadesCentralita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C01___La_centralita_Episodio_II
{
    public partial class FrmMostrar : Form
    {
        TipoLlamada tipoLlamada;
        string titulo;
        string tipoFacturacion;
        Centralita c;
        public FrmMostrar(Centralita c, FrmMenu menu, string titulo)
        {
            InitializeComponent();
            StartPosition = menu.StartPosition;
            this.titulo = titulo;
            this.c = c;
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea volver al menu?", "Volver", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            Text = $"{titulo}";
            if (titulo == "Local")
            {
                foreach (Llamada item in c.Llamadas)
                {
                    if (item is Local l)
                    {
                        richTextBox.Text += l.ToString();                        
                    }
                }
                richTextBox.Text += $"\nGanancia Local total: {c.GananciasPorLocal.ToString()}";
            }
            else
            {
                if (titulo == "Provincial")
                {
                    foreach (Llamada item in c.Llamadas)
                    {
                        if (item is Provincial p)
                        {
                            richTextBox.Text += p.ToString();                       
                        }
                    }
                    richTextBox.Text += $"\nGanancia provincial total: {c.GananciasPorProvincial.ToString()}";
                }
                else
                {
                    foreach (Llamada item in c.Llamadas)
                    {
                        if (item is Local l)
                        {
                            richTextBox.Text += l.ToString();
                        }
                        else if (item is Provincial p)
                        {
                            richTextBox.Text += p.ToString();
                        }
                    }
                    richTextBox.Text += $"\nGanancia Total: {c.GananciasPorTotal.ToString()}";
                }
            }
            
        }
    }
}
