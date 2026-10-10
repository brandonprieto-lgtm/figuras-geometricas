using Figuras.Core;
using Xunit;

namespace Figuras.Tests;

public class FiguraTests
{
    [Fact]
    public void Circulo_Radio1_CalculaAreaPi()
    {
        var circulo = new Circulo(1);
        Assert.Equal(Math.PI, circulo.CalcularArea(), precision: 5);
    }

    [Fact]
    public void Circulo_Radio10_CalculaArea100Pi()
    {
        var circulo = new Circulo(10);
        Assert.Equal(100 * Math.PI, circulo.CalcularArea(), precision: 5);
    }

    [Fact]
    public void Circulo_RadioCero_LanzaExcepcion()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circulo(0));
    }

    [Fact]
    public void Circulo_RadioNegativo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circulo(-5));
    }
}