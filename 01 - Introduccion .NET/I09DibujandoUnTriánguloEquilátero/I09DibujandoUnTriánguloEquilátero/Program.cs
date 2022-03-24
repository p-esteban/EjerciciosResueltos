using System;

namespace I09DibujandoUnTriánguloEquilátero
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int filas;
            int i;
            Console.WriteLine("ingrese can filas");
            string aux = Console.ReadLine();

            if (Int32.TryParse(aux, out filas))
            {
                for (i = 1; i <= filas; i++)
                {
                    for (int j = 1; j <= filas - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < (i * 2); k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
