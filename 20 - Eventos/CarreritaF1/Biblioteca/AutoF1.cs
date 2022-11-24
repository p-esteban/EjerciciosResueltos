using System;

namespace Biblioteca
{
    public class AutoF1
    {
        string escuderia;
        int posicion;
        int puntoPartida;
        int velocidad;
      
        public AutoF1()
        {
        }

        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.velocidad = velocidad;
            this.puntoPartida = puntoPartida;

        }

        public string Escuderia { get => escuderia; set => escuderia = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int UbicacionEnPista { get => puntoPartida; set => puntoPartida = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }


        public void Acelerar()
        {
            puntoPartida += velocidad;
        }

        public override string ToString()
        {
            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";
        }
    }
}
