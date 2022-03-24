using System;

namespace I05TirameUnCentro
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int num;
            int sumaAntesCentro = 0;
            int n = 1;
            int sumaDespuesCentro = 1;

            Console.WriteLine("ingrese num");
            string aux = Console.ReadLine();

            do
            {
                if (Int32.TryParse(aux, out num))
                {
                    for (int i = 1; i < n; i++)
                    {
                        sumaAntesCentro += i;
                    }
                    for (int k = n + 1; k < n * 2; k++)
                    {
                        if (sumaAntesCentro == sumaDespuesCentro)
                        {
                            Console.WriteLine($"Centro {n}");
                            break;
                        }
                        else
                        {
                            sumaDespuesCentro += k;
                        }
                    }
                }
                n++;
                sumaDespuesCentro = 0;
                sumaAntesCentro = 0;
            } while (num > n);
        }
    }
}
