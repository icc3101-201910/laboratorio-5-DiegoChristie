using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_DiegoChristie
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int valorI)
        {
            int val1 = 1;
            int val2 = 1;
            for (int i = 0; i < valorI; i++)
            {
                val1 = val1 * val2;
                val2 += 1;
            }
            return val1;
        }
    }
}
