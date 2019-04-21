using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_DiegoChristie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos las clases
            Calculadora calculadora = new Calculadora(0);

            PersonaQueSuma5 personaQueSuma5 = new PersonaQueSuma5();
            RobotFibonacci robotFibonacci = new RobotFibonacci();
            PerroFactorial perroFactorial = new PerroFactorial();
            Cubo cubo = new Cubo();
            Cuadrado cuadrado = new Cuadrado();

            //Agregamos las clases a la lista en Calculadora
            calculadora.calculadoras.Add(personaQueSuma5);
            calculadora.calculadoras.Add(robotFibonacci);
            calculadora.calculadoras.Add(perroFactorial);
            calculadora.calculadoras.Add(cubo);
            calculadora.calculadoras.Add(cuadrado);

            //Menu
            Console.WriteLine("Calculadora 2000 TI Modelo 551-f");
            while (true)
            {
                //Opciones del usuario
                Console.WriteLine("Ingrese el numero de la operacion que desea realizar: ");
                Console.WriteLine("1.- Sumar 5");
                Console.WriteLine("2.- Calcular Fibonacci");
                Console.WriteLine("3.- Calcular Factorial");
                Console.WriteLine("4.- Calcular Cubo");
                Console.WriteLine("5.- Calcular Cuadrado");
                Console.WriteLine("6.- Apagar Calculadora");
                string operacionStr = Console.ReadLine();
                int operacion = Int32.Parse(operacionStr) - 1;

                if (operacion == 5)
                {
                    break;
                }
                else
                {
                    //Numero del usuario
                    Console.WriteLine("Ingrese el numero al que desea aplicarle la operacion: ");
                    Console.WriteLine("¡Maximo 46 para Fibonacci y 12 para Factorial!");
                    string valorIStr = Console.ReadLine();
                    int valorI = Int32.Parse(valorIStr);

                    //Calculo
                    calculadora.Calcular(operacion, valorI);
                    Console.WriteLine("Su resultado es: " + calculadora.GetNumero());
                }
            }
        }
    }
}
