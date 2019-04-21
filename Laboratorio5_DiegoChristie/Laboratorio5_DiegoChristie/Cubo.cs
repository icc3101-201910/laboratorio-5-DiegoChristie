using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_DiegoChristie
{
    class Cubo : ICalcular
    {
        public int Calcular(int valorI)
        {
            int val1 = (valorI * valorI * valorI);
            return val1;
        }
    }
}
