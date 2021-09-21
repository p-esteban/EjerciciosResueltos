using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    internal class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito() 
        {

        }
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
