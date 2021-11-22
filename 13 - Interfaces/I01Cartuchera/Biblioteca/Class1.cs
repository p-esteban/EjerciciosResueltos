using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class1
    {
        public List<IAcciones> lista;
        public Class1()
        {
            lista = new List<IAcciones>();
        }
        public bool Recorrer()
        {
            bool result = false;
            foreach (IAcciones item in lista)
            {
                if (item.UnidadesDeEscritura > 1)
                {
                    item.Escribir("*");
                    result = true;
                }else
                {
                    item.Recargar(20);
                    result = false;
                }
            }
            return result;
        }
    }
}
