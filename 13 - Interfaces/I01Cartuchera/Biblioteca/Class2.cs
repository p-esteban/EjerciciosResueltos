using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class2
    {
        public List<Boligrafo> boli;
        public List<Lapiz> lapiz;
        public Class2()
        {
            boli = new List<Boligrafo>();
            lapiz = new List<Lapiz>();
        }
        public bool Recorrer()
        {
            bool result = false;
            foreach (IAcciones item in boli)
            {
                if (item.UnidadesDeEscritura > 1)
                {
                    item.Escribir("*");
                    result = true;
                }
                else
                {
                    item.Recargar(20);
                    result = false;
                }
            }
            
            foreach (IAcciones item in lapiz)
            {
                if (item.UnidadesDeEscritura > 1)
                {
                    item.Escribir("*");
                    result = true;
                }
                else
                {
                    item.Recargar(20);
                    result = false;
                }
            }
            return result;
            
        }
    }
}
