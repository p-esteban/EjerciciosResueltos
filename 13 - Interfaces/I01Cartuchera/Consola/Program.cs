using System;
using Biblioteca;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo( ConsoleColor.Green,20);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();

            Boligrafo b1 = new Boligrafo(ConsoleColor.Green, 5);
            Boligrafo b2 = new Boligrafo(ConsoleColor.Green, 10);
            Lapiz l1 = new Lapiz(5);
            Lapiz l2 = new Lapiz(10);


            







        }
    }
}
