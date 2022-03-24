using System;

namespace I03LosPrimos
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("ingrese num");
                string aux = Console.ReadLine();
                flag = Int32.TryParse(aux, out num);
                if (flag)
                {
                    for (int i = 2; i <= num; i++)
                    {
                        int cantDivisores = 0;
                        for (int k = 1; k <= i; k++)
                        {
                            if (i % k == 0)
                            {
                                cantDivisores++;
                            }
                        }
                        if (cantDivisores < 3)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    flag = false;
                }
            } while (flag);
        }
    }
}
