using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_DiegoChristie
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int valorI)
        {
            //Vemos los casos para valores base
            //F0
            if (valorI == 0)
            {
                int val1 = 0;
                return val1;
            }
            //F1
            else if (valorI == 1)
            {
                int val2 = 1;
                return val2;
            }
            //Vemos el caso general
            //Fn
            else
            {
                int val1 = 0;
                int val2 = 1;
                int val3 = 0;
                for (int i = 0; i < (valorI-1); i++)
                {
                    val3 = val1 + val2;
                    val1 = val2;
                    val2 = val3;
                }
                return val3;
            }
        }
    }
}
