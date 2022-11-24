using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIblioteca
{
    public class Covid19:Microrganismo
    {
        public Covid19(string nombre) : base(nombre)
        {

        }
        public override long IndiceDeContagiosidad
        {
            get
            {
                return contador *= 5;
            }
        }
    }
}
