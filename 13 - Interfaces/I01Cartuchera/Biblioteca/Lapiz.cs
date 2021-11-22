using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return tamanioMina; }
            set { throw new NotImplementedException(); }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (tamanioMina >= texto.Length *0.1  )
            {
                tamanioMina -= texto.Length * 0.1f;

                return new EscrituraWrapper(((IAcciones)this).Color, texto);
            }
            return null;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Lapiz color: {((IAcciones)this).Color} cantidad de mina: {tamanioMina}";
        }
    }
}
