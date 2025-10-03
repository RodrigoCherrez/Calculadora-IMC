using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Calculadora de IMC");
            Console.WriteLine("Para estar en la misma sintonia se agregan los ejemplos de como debe colocar los datos: Altura 1.79, Peso: 75.3");
            Console.WriteLine("Ingrese su Peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su Altura");
            double altura = double.Parse(Console.ReadLine());

            Operacion op = new Operacion(peso, altura);
            double img = op.Resultado();
            Console.WriteLine($" Tu IMC es : {img}");
            Console.WriteLine($"Estás en : {op.Info()}");


        }   
    }
}
