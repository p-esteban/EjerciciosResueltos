using System;

namespace I01MinMax
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int num;
            int control = 1;
            int acumulado = 0;
            float promedio;
            string auxString;
            int min = int.MaxValue;
            int max = int.MinValue;

            do
            {
                Console.WriteLine("ingrese num");
                auxString = Console.ReadLine();

                if (Int32.TryParse(auxString, out num))
                {
                    if (num < min)
                    {
                        min = num;
                    }
                    if (num > max)
                    {
                        max = num;
                    }
                    acumulado += num;
                    control++;
                }
            } while (control <= 5);
            promedio = acumulado / 5;
            Console.WriteLine($"Valor max: {max} Valor min: {min} Promedio {promedio}");
        }
    }
}
