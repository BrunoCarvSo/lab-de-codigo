using System;


public class Nokia : Smartphone
{
    public Nokia(string numero) : base(numero) //Se á um construtor na classe pai preciso por um construtor com a base para ele.
    {

    }

    public override void InstalarAplicativo(string NomeApp) //Sou obrigado a criar os métodos abstratos da classe pai nos filhos
	{
        Console.WriteLine($"Bem vindo a Play Store! Instalando: {NomeApp}.");
    }
}
