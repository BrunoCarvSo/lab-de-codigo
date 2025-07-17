using System;

public class Iphone : Smartphone
{
    public Iphone(string numero) : base(numero)
    {

    }

    public override void InstalarAplicativo(string NomeApp)
    {
        Console.WriteLine($"Bem vindo a Apple Store! Instalando: {NomeApp}.");
    }
}
