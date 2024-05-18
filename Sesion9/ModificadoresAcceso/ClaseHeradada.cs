using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso
{
    public class ClaseHeradada : ClasePublica
    {

        Nullable<int> enteroQuePuedeSerNulo = null;
        int nullo = null;
        int? otroEnteroQuePuedeSerNulo = null;

        public void MetodoConProtectedHeradado()
        {
            MetodoConProtected();
        }
    }
}
