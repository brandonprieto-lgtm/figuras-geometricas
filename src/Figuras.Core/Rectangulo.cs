namespace Figuras.Core;

/// <summary>
/// Representa un rectángulo geométrico.
/// </summary>
public class Rectangulo : Figura
{
    /// <summary>
    /// Base del rectángulo (debe ser mayor a 0).
    /// </summary>
    public double Base { get; }

    /// <summary>
    /// Altura del rectángulo (debe ser mayor a 0).
    /// </summary>
    public double Altura { get; }

    /// <summary>
    /// Crea un nuevo rectángulo con base y altura especificadas.
    /// </summary>
    /// <param name="base">Base del rectángulo (mayor a 0).</param>
    /// <param name="altura">Altura del rectángulo (mayor a 0).</param>
    /// <exception cref="ArgumentOutOfRangeException">Si base o altura son menores o iguales a 0.</exception>
    public Rectangulo(double @base, double altura)
    {
        if (@base <= 0)
            throw new ArgumentOutOfRangeException(nameof(@base), "La base debe ser mayor a 0.");

        if (altura <= 0)
            throw new ArgumentOutOfRangeException(nameof(altura), "La altura debe ser mayor a 0.");

        Base = @base;
        Altura = altura;
    }

    /// <summary>
    /// Calcula el área del rectángulo.
    /// </summary>
    /// <returns>Área calculada (base × altura).</returns>
    public override double CalcularArea()
    {
        return Base * Altura;
    }
}