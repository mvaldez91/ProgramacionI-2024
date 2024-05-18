using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion8
{
    interface IOrdenable
    {
        int Comparar(object obj);
        void Ordenar();
    }
}
