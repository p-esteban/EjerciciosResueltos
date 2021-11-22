using System;

namespace Biblioteca
{
    public class CalculadoraString
    {
        public int Add(string numeros)
        {

            if (string.IsNullOrEmpty(numeros))
                return 0;


            if (numeros.StartsWith("//"))
            {
                char separador = numeros[2];
                numeros = numeros.Substring(2).Replace(separador, ',');

            }


            string[] partes = numeros.Split(new char[] { ',','\n'}, StringSplitOptions.RemoveEmptyEntries);

            int total = 0;
            foreach (string numero in partes)
            {
                if (int.Parse(numero) < 0)
                {
                    throw new NegativoNoPermitidoException(numero);
                }
                total += int.Parse(numero);
            }

            return total;


        }
    }
}
