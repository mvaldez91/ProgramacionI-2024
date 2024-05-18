using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso
{
    internal class Demostracion
    {
        public void Probar() {
            ClasePublica objectoPublico = new ClasePublica();
            ClaseInternal claseInternal = new ClaseInternal();
        }
    }
}
