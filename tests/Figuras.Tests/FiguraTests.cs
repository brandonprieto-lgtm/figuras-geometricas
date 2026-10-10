using Figuras.Core;
using Xunit;

namespace Figuras.Tests;

public class FiguraTests
{
    // ═══════════════════════════════════════════
    // US-01: Círculo
    // ═══════════════════════════════════════════

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

    // ═══════════════════════════════════════════
    // US-02: Rectángulo
    // ═══════════════════════════════════════════

    [Fact]
    public void Rectangulo_Base4Altura5_CalculaArea20()
    {
        var rectangulo = new Rectangulo(4, 5);
        Assert.Equal(20, rectangulo.CalcularArea());
    }

    [Fact]
    public void Rectangulo_Base10Altura3_CalculaArea30()
    {
        var rectangulo = new Rectangulo(10, 3);
        Assert.Equal(30, rectangulo.CalcularArea());
    }

    [Fact]
    public void Rectangulo_BaseCero_LanzaExcepcion()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangulo(0, 5));
    }

    [Fact]
    public void Rectangulo_AlturaCero_LanzaExcepcion()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangulo(4, 0));
    }

    [Fact]
    public void Rectangulo_AlturaNegativa_LanzaExcepcion()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangulo(4, -3));
    }
}