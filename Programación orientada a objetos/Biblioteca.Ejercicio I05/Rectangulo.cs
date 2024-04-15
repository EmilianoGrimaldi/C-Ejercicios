using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            CalcularAreaYPerimetro();
        }

        public Punto GetVertice1()
        { 
            return vertice1;
        }
        public Punto GetVertice2()
        {
            return vertice2;
        }
        public Punto GetVertice3()
        {
            return vertice3;
        }
        public Punto GetVertice4()
        {
            return vertice4;
        }
        public float Area()
        {
            return area;
        }
        public float Perimetro()
        {
            return perimetro;
        }
        private void CalcularAreaYPerimetro()
        {
            float baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
            float alturaRectangulo = Math.Abs(vertice1.GetY() - vertice3.GetY());
            area = baseRectangulo * alturaRectangulo;
            perimetro = 2 * (baseRectangulo + alturaRectangulo);
        }

    }
}
