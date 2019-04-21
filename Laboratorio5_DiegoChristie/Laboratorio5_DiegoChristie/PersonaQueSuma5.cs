using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_DiegoChristie
{
    class PersonaQueSuma5 : ICalcular
    {
        public int Calcular(int valorI)
        {
            return (valorI + 5);
        }
    }
}
