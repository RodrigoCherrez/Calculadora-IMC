using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Operacion
    {
        double Peso;
        double altura;

        public Operacion(double Pesoo, double alturaa) 
        {
            this.Peso = Pesoo;
            this.altura = alturaa;
        }

        
        public double Resultado() 
        {
           return Peso / (altura * altura);
        }
        public string Info()
        {
            double img = Resultado();
            if (img < 18.5) return "Peso Bajo";
            else if (img < 25) return "Peso Normal";
            else if (img < 30) return "Sobrepeso";
            else if (img < 40) return "Obsesidad";
            else return "Obesidad extrema";
        }
    }
}
