﻿namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta = (short)(this.tinta + tinta);

            if(this.tinta >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else if(this.tinta <= 0)
            {
                this.tinta = 0;
            }
        }

        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = "";

            if(this.tinta == 0)
            {
                dibujo = "No pude pintar";
                return false;
            }

            while(gasto > 0 && this.tinta > 0)
            {
                cadenaAux = cadenaAux + "*";
                this.SetTinta(-1);
                gasto--;
            }

            dibujo = cadenaAux;

            return true;
        }

    }
}