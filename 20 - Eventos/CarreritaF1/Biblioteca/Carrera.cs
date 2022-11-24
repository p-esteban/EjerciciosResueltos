using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void InformacionDeAvance();
    public delegate void InformacionLlegada(string mensaje);
    public class Carrera
    {

        public event Action InformarAvance;
        public event Action<string> InformarLlegada;


        List<AutoF1> autos;
        int kms;

        public Carrera()
        {
            autos = new List<AutoF1>();
        }

        public Carrera(int kms) : this()
        {
            this.kms = kms;
        }

        public List<AutoF1> Autos { get => autos; set => autos = value; }
        public int Kms { get => kms; set => kms = value; }

        public void IniciarCarrera()
        {

            int i = 1;


            while (i < 3)
            {

                foreach (AutoF1 item in Autos)
                {

                    item.Acelerar();
                    this.InformarAvance();
                    Thread.Sleep(10);
                    if (item.UbicacionEnPista > Kms && item.Posicion == 0)
                    {

                        item.Posicion = i;
                        i++;
                        this.InformarLlegada.Invoke(item.ToString());
                        
                    }

                }
            }

        }
        public static Carrera operator +(Carrera c, AutoF1 a)
        {
            c.Autos.Add(a);
            return c;
        }
    }
}
