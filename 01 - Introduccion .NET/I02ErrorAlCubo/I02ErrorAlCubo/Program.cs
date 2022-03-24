using System;

namespace I02ErrorAlCubo
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int num;
            bool flag;
            double resultado;


            do
            {
                Console.WriteLine("Ingrese num");
                string aux = Console.ReadLine();
                if (Int32.TryParse(aux, out num) && num > 0)
                {
                    resultado = Math.Pow(num, 2);
                    Console.WriteLine($"resultado {resultado}");
                    Console.ReadKey();
                    flag = false;
                }
                else
                {
                    Console.WriteLine("ERROR!!");
                    flag = true;
                }
            } while (flag);
        }
    }
}
