using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIblioteca
{
    public  class Gripe : Microrganismo
    {
        public Gripe(string nombre, ETipo tipo, EContagiosidad contagiosidad)
            :base(nombre, tipo, contagiosidad)
        {

        }
        public override long IndiceDeContagiosidad
        {
            get
            {
               
                return contador *= 2;
            }
        }
    }
}
