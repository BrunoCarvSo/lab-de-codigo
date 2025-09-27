using Calculadora.Services;

CalculadoraImp t = new CalculadoraImp(); 

int num1 = 5;
int num2 = 9;

Console.WriteLine($"{num1} + {num2} da como resultado: {t.Somar(num1,num2)}");