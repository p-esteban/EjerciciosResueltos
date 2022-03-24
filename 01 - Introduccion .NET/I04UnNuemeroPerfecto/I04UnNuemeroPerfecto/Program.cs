using System;

namespace I04UnNuemeroPerfecto
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int length = 10000;
            for (int i = 1; i < length; i++)
            {
                int suma = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        suma += k;

                    }
                }
                if (suma == i && i != 1)
                {
                    Console.WriteLine($"num: {suma}");
                }
            }
        }
    }
}
