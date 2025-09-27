using System;
using Calculadora.Services;
namespace CalculadoraTestes;

public class ValidacoesStringTests
{

	private ValidacoesString _validador;

	public ValidacoesStringTests()
	{
		_validador = new ValidacoesString();
	}

	[Fact]
	public void DeveContar5CaracteresEmBrunoERetornar5()
	{
		//Arrange
		string texto = "Bruno";

		//Act
		int resultado = _validador.ContarCaracteres(texto);

		//Assert
		Assert.Equal(5, resultado);
	}
}


