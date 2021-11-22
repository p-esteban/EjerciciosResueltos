using System;
using System.Runtime.Serialization;

namespace Biblioteca
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException()
        {
        }

        public NegativoNoPermitidoException(string message) : base(message)
        {
        }

    }
}