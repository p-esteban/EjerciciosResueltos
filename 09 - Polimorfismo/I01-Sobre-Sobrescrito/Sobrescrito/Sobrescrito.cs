using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    abstract class  Sobrescrito
    {
        protected string miAtributo;

        protected Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get;  }

        public abstract string MiMetodo();
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            /// varias formas de validar el tipo
            //return obj.GetType() == this.GetType();
            //return obj.GetType() == typeof(Sobrescrito);
            Sobrescrito aux = obj as Sobrescrito;
            if (aux is not null)
            {
                return true;
            }
            return false;
           // return obj is Sobrescrito ;
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
