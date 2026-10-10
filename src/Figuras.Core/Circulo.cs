namespace Figuras.Core;

/// <summary>
/// Representa un círculo geométrico.
/// </summary>
public class Circulo : Figura
{
    /// <summary>
    /// Radio del círculo (debe ser mayor a 0).
    /// </summary>
    public double Radio { get; }

    /// <summary>
    /// Crea un nuevo círculo con el radio especificado.
    /// </summary>
    /// <param name="radio">Radio del círculo (mayor a 0).</param>
    public Circulo(double radio)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calcula el área del círculo.
    /// </summary>
    /// <returns>Área calculada (π × radio²).</returns>
    public override double CalcularArea()
    {
        throw new NotImplementedException();
    }
}