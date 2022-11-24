using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BIblioteca
{
    public delegate void AvanceInfectados(int dia, long infectados);
    public delegate void FinInfectacion();
    public static class GrupoDePrueba<T> where T : Microrganismo
    {
        private static T enfermedad;
        private static long poblacion;

        public static event AvanceInfectados InformeDeAvance;
        public static event FinInfectacion FinalizaSimulacion;
        public static long Poblacion { get => poblacion; set => poblacion = value; }

        static GrupoDePrueba()
        {
            poblacion = 10000000;
        }
        public static void InfectarPoblacion(object obj)
        {
            T microrganismo = obj as T;
            int dia = 0;
            long infectados = 0;
            if (microrganismo is not null)
            {
                enfermedad = microrganismo;
                dia = 1;
                do
                {
                    infectados = enfermedad.IndiceDeContagiosidad;
                    if (InformeDeAvance is not null)
                    {
                        InformeDeAvance.Invoke(dia, infectados);
                        dia++;
                        Thread.Sleep(750);
                    }

                }
                while (infectados <= poblacion);

                FinalizaSimulacion?.Invoke();

            }

        }
    }
}
