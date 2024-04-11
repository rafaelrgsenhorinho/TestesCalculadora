using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }
    
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10Com5ERetornar5()
    {
        int num1 = 10;
        int num2 = 5;

        int resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveMultiplicar3Com2ERetornar6()
    {
        int num1 = 3;
        int num2 = 2;

        int resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(6, resultado);
    }

    [Fact]
    public void DeveDividir10Por2ERetornar5()
    {
        int num1 = 10;
        int num2 = 2;

        int resultado = _calc.Dividir(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(10,15);
        _calc.Subtrair(10,15);
        _calc.Multiplicar(10,15);
        _calc.Dividir(10,15);

        var lista = _calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
  
}