﻿using System;

namespace Sobrescrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio No38 Guía 2017";
            Sobrescrito sobrecarga = new SobreSobrescrito();

            Console.WriteLine(sobrecarga.MiMetodo());

            Console.WriteLine("------------------");

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
        }
    }
}
