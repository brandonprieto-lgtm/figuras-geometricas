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
    /// <exception cref="ArgumentOutOfRangeException">Si el radio es menor o igual a 0.</exception>
    public Circulo(double radio)
    {
        if (radio <= 0)
            throw new ArgumentOutOfRangeException(nameof(radio), "El radio debe ser mayor a 0.");

        Radio = radio;
    }

    /// <summary>
    /// Calcula el área del círculo.
    /// </summary>
    /// <returns>Área calculada (π × radio²).</returns>
    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}