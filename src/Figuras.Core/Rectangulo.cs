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
    public Rectangulo(double @base, double altura)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calcula el área del rectángulo.
    /// </summary>
    /// <returns>Área calculada (base × altura).</returns>
    public override double CalcularArea()
    {
        throw new NotImplementedException();
    }
}