using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Personaje : IJugador
    {
        decimal id;
        short nivel;
        string nombre;
        protected int puntosDeDefensa;
        protected int puntosDeVida;
        protected int puntosDePoder;
        static Random random;
        string titulo;
        const short NIVEL_MAX = 100;

        public event Action<Personaje, int> AtaqueLanzado;
        public event Action<Personaje, int> AtaqueRecibido;
        static Personaje()
        {
            random = new Random();
        }

        public Personaje(decimal id, string nombre, short nivel)


        {
            if (nivel > 0 && nivel <= NIVEL_MAX)
            {

                this.nivel = nivel;
                puntosDeDefensa = 100 * nivel;
                puntosDePoder = 100 * nivel;
                puntosDeVida = 500 * nivel;
                this.nombre = nombre;
                this.id = id;
            }
            else
            {
                throw new BusinessException("El nivel no es valido");
            }

        }

        public Personaje(decimal id, string nombre) : this(id, nombre, 1)

        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException();
            }
            this.nombre = nombre.Trim();
            this.id = id;
        }

        public short Nivel { get => nivel; } 

        public int PuntosDeVida { get => puntosDeVida; }

        public string Titulo { set => titulo = value; }


        public int Atacar()
        {
            Thread.Sleep(random.Next(1000, 5000));
        
            int putosDeAtaque = puntosDePoder * random.Next(10, 100) / 100;
            if (AtaqueLanzado is not null)
            {
                AtaqueLanzado.Invoke(this, putosDeAtaque);
            }
            return putosDeAtaque;
        }

        public void RecibirAtaque(int puntosDeAtaque)
        {
            puntosDeAtaque -= puntosDeDefensa * (random.Next(10, 100) / 100);///?
            puntosDeVida -= puntosDeAtaque;
            if (puntosDeVida < 0)
            {
                puntosDeVida = 0;
            }
            if (AtaqueRecibido is not null)
            {
                AtaqueRecibido.Invoke(this, puntosDeAtaque);
            }


        }


        public abstract void AplicarBeneficiosDeClase();




        //////
        public static bool operator ==(Personaje p1, Personaje p2)
        {
            return p1 is not null && p2 is not null && p1.GetHashCode() == p2.GetHashCode();
        }
        public static bool operator !=(Personaje p1, Personaje p2)
        {
            return !(p1 == p2);
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this == obj as Personaje;
        }
        public override string ToString()
        {
            return String.Format("{0}{1}", nombre, string.IsNullOrEmpty(titulo) ? "" : $" ,{titulo}");
        }
    }
}
