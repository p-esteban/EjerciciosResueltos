using System;

namespace BIblioteca
{
    public abstract class Microrganismo
    {
        public enum EContagiosidad { Baja,Moderada,Alta}
        public enum ETipo { Virus, Bacteria}

        protected long contador;
        private EContagiosidad contagiosidad;
        private string nombre;
        private ETipo tipo;

        protected Microrganismo(string nombre)
        {
            this.nombre = nombre;
            contador = 1;
           
        }
        protected Microrganismo(string nombre, ETipo tipo, EContagiosidad contagiosidad)
            :this(nombre)
        {
           
            this.tipo = tipo;
            this.contagiosidad = contagiosidad;
        }

        public abstract long IndiceDeContagiosidad { get; }

        public string Informe()
        {
            return $" {tipo} lleva el nombre de {nombre} y tiene una contagiosidad {contagiosidad}. Su impacto de contagios se calcula en {IndiceDeContagiosidad}.";
        }
    }
}
