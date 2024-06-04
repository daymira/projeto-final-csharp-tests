namespace CalculadoraTests;
using Calculadora.Services;

public class CalculadoraTests
{
    private CalculadoraBasica _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraBasica();
    }

    [Theory]
    [InlineData(2,4,6)]
    [InlineData(450,20,470)]
    [InlineData(51,3,54)]
    public void SomaTeste(int n1, int n2, int resultado)
    {
        int resultadoSoma = _calc.Somar(n1, n2);

        Assert.Equal(resultado, resultadoSoma);
    }

    [Theory]
    [InlineData(10,4,6)]
    [InlineData(45,9,36)]
    [InlineData(100,50,50)]
    public void SubtracaoTeste(int n1, int n2, int resultado)
    {
        int resultadoSubtracao = _calc.Subtrair(n1, n2);

        Assert.Equal(resultado, resultadoSubtracao);
    }

    [Theory]
    [InlineData(2,10,20)]
    [InlineData(9,3,27)]
    [InlineData(40,3,120)]
    public void MultiplicacaoTeste(int n1, int n2, int resultado)
    {
        int resultadoMultiplicacao = _calc.Multiplicar(n1, n2);

        Assert.Equal(resultado, resultadoMultiplicacao);
    }

    [Theory]
    [InlineData(9,3,3)]
    [InlineData(20,5,4)]
    [InlineData(10,5,2)]
    public void DivisaoTeste(int n1, int n2, int resultado)
    {
        int resultadoDivisao = _calc.Dividir(n1, n2);

        Assert.Equal(resultado, resultadoDivisao);
    }

     [Theory]
    [InlineData(100,20,20)]
    [InlineData(450,10,45)]
    [InlineData(545,40,218)]
    public void PorcentagemTeste(int n1, int n2, int resultado)
    {
        decimal resultadoPorcentagem = _calc.Porcentagem(n1, n2);

        Assert.Equal(resultado, resultadoPorcentagem);
    }

    [Fact]
    public void DivisaoporZero()
    {
        Assert.Throws<DivideByZeroException>(() => 
            _calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(5,4);
        _calc.Subtrair(18,4);
        _calc.Multiplicar(5,5);
        _calc.Dividir(20,2);
        _calc.Porcentagem(100,50);
        _calc.Multiplicar(5,5);
        _calc.Subtrair(28,5);
        _calc.Multiplicar(7,4);
        _calc.Dividir(15,5);
        _calc.Somar(20,6);
        _calc.Multiplicar(12,5);
        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);
    }

    [Fact]
    public void TestarHistoricoVazio()
    {
        var lista = _calc.Historico();

        Assert.Empty(lista);
    }
}