using System;

namespace ClassLibrary1
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        string nombre;
        string apellido;

        public event DelegadoString EventoString;

        public string Nombre 
        {
            get => nombre; 
            set 
            {
                nombre = value;
                EventoString(nombre);
            } 
        }
        public string Apellido { get => apellido;
            set
            {
                apellido = value;
                EventoString(apellido);
            }
        }

        public string Mostrar()
        {
            return $"{nombre} {apellido}";
        }
    }
}
