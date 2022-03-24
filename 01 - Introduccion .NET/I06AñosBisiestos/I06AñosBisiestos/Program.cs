using System;

namespace I06AñosBisiestos
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Año inicio");
            string auxInicio = Console.ReadLine();
            Console.WriteLine("año final");
            string auxFinal = Console.ReadLine();
            Int32.TryParse(auxInicio, out int inicio);
            Int32.TryParse(auxFinal, out int final);

            for (int i = inicio; i <= final; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine($"ES este {i}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ES {i}");
                    }
                }



            }
        }
    }
}
