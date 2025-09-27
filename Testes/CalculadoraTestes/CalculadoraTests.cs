namespace CalculadoraTestes;
using Calculadora.Services;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar8Com9ERetornar17()
    {
        //Arrange
        int numero1 = 8;
        int numero2 = 9;

        //Act
        int resultado = _calc.Somar(numero1, numero2);

        //Assert

        Assert.Equal(17, resultado);

    }

    [Fact]
    public void DeveAnalisar8ERetornarPar()
    {
        //Arrange
        int numero = 8;

        //Act
        string resultado = _calc.ParOuImpar(numero);

        //Assert
        Assert.Equal("Par",resultado);
    }

    [Theory]
    [InlineData(23)]
    [InlineData(55)]
    [InlineData(89)]
    [InlineData(17)]
    [InlineData(11)]
    public void DeveVerificarNumerosERetornarImpar(int numero)
    {
        //Arrange
        //Act
        string resultado = _calc.ParOuImpar(numero);

        //Assert
        Assert.Equal("Ímpar", resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 8, 10})]
    [InlineData(new int[] {66,88,1024})]
    public void DeveVerificarNumerosERetornarPar(int[] numeros)
    {
        //Arrange
        //Act e Assert
        Assert.All(numeros, num => Assert.Equal("Par", _calc.ParOuImpar(num)));
    }
}
