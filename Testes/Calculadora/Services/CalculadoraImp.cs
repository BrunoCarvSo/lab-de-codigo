using System;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public string ParOuImpar(int num)
        {
            if (num % 2 == 0)
            {
                return "Par";
            }
            else
            {
                return "Ímpar"; 
            }
        }
    }
}