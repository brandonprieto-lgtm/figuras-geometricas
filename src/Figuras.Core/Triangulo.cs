namespace Figuras.Core;

/// <summary>
/// Representa un triángulo geométrico.
/// </summary>
public class Triangulo : Figura
{
    /// <summary>
    /// Base del triángulo (debe ser mayor a 0).
    /// </summary>
    public double Base { get; }

    /// <summary>
    /// Altura del triángulo (debe ser mayor a 0).
    /// </summary>
    public double Altura { get; }

    /// <summary>
    /// Crea un nuevo triángulo con base y altura especificadas.
    /// </summary>
    /// <param name="base">Base del triángulo (mayor a 0).</param>
    /// <param name="altura">Altura del triángulo (mayor a 0).</param>
    /// <exception cref="ArgumentOutOfRangeException">Si base o altura son menores o iguales a 0.</exception>
    public Triangulo(double @base, double altura)
    {
        if (@base <= 0)
            throw new ArgumentOutOfRangeException(nameof(@base), "La base debe ser mayor a 0.");

        if (altura <= 0)
            throw new ArgumentOutOfRangeException(nameof(altura), "La altura debe ser mayor a 0.");

        Base = @base;
        Altura = altura;
    }

    /// <summary>
    /// Calcula el área del triángulo.
    /// </summary>
    /// <returns>Área calculada ((base × altura) / 2).</returns>
    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}