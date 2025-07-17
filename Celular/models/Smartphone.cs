using System;

public abstract class Smartphone
{

	public string Numero { get; set; }
	public string Modelo { get; set; }
	public string IMEI { get; set; }
	public int Memoria { get; set; }

	public Smartphone(string numero)
	{	
		Numero = numero;
	}

	public void Ligar(string numero)
	{
		Console.WriteLine($"Ligando para {numero}...");
	}

	public void ReceberLigacao()
	{
		Console.WriteLine("Você está recebendo uma ligação.");
	}

	public abstract void InstalarAplicativo(string NomeApp);

	
}
