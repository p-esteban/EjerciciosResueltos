using System;

namespace Biblioteca
{
    public class CalculadoraString
    {

        public int Add(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
                return 0;

            char[] separadores = { ',', '\n', ' ' }; ;

            if (numeros.StartsWith("//"))
            {
                separadores[2] = numeros[2];
                numeros = numeros.Remove(0, 3);
            }

            int total = 0;

            foreach (string numero in numeros.Split(separadores, StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.Parse(numero) < 0)
                {
                    throw new NegativoNoPermitidoException(numero);
                }
                else
                {
                    total += int.Parse(numero);
                }
            }
            return total;
        }
    }
}
