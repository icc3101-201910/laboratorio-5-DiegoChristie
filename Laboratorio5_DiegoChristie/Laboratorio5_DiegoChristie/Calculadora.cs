using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_DiegoChristie
{
    class Calculadora
    {
        private int numero;

        public List<ICalcular> calculadoras = new List<ICalcular>(); 
        public Calculadora(int valorInicial)
        {
            this.numero = valorInicial;
        }

        public void Calcular(int operacion, int valorI)
        {
            numero = calculadoras[operacion].Calcular(valorI);
        }
        public int GetNumero()
        {
            return numero;
        }
    }
}
