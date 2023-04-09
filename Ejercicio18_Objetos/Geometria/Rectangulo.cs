﻿namespace Geometria
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
            //this.vertice2 = Math.Abs(vertice2);
        }

        public float Area()
        {
            return this.area;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }
    }
}