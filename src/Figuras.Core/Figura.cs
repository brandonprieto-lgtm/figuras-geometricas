namespace Figuras.Core;

/// <summary>
/// Clase base abstracta para todas las figuras geométricas.
/// Define el contrato que todas las figuras deben implementar.
/// </summary>
public abstract class Figura
{
    /// <summary>
    /// Calcula el área de la figura.
    /// </summary>
    /// <returns>Área calculada en unidades cuadradas.</returns>
    public abstract double CalcularArea();
}