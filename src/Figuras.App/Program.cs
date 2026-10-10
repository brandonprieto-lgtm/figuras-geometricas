using Figuras.Core;

Console.OutputEncoding = System.Text.Encoding.UTF8;

bool continuar = true;

while (continuar)
{
    MostrarMenu();
    string? opcion = Console.ReadLine();

    try
    {
        switch (opcion)
        {
            case "1":
                CalcularCirculo();
                break;
            case "2":
                CalcularRectangulo();
                break;
            case "3":
                CalcularTriangulo();
                break;
            case "4":
                continuar = false;
                Console.WriteLine("\n¡Hasta luego!\n");
                break;
            default:
                Console.WriteLine("\n⚠️  Opción inválida. Intenta de nuevo.\n");
                break;
        }
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"\n❌ Error: {ex.Message}\n");
    }
    catch (FormatException)
    {
        Console.WriteLine("\n❌ Error: Debes ingresar un número válido.\n");
    }

    if (continuar && opcion != "4")
    {
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
}

static void MostrarMenu()
{
    Console.WriteLine("═══════════════════════════════════════════");
    Console.WriteLine("   CALCULADORA DE FIGURAS GEOMÉTRICAS");
    Console.WriteLine("═══════════════════════════════════════════");
    Console.WriteLine();
    Console.WriteLine("  1. Círculo");
    Console.WriteLine("  2. Rectángulo");
    Console.WriteLine("  3. Triángulo");
    Console.WriteLine("  4. Salir");
    Console.WriteLine();
    Console.Write("Elige una opción: ");
}

static void CalcularCirculo()
{
    Console.Write("\nIngresa el radio del círculo: ");
    double radio = double.Parse(Console.ReadLine()!);

    var circulo = new Circulo(radio);
    Console.WriteLine($"\n→ Área del círculo: {circulo.CalcularArea():F4}");
}

static void CalcularRectangulo()
{
    Console.Write("\nIngresa la base del rectángulo: ");
    double baseRect = double.Parse(Console.ReadLine()!);

    Console.Write("Ingresa la altura del rectángulo: ");
    double altura = double.Parse(Console.ReadLine()!);

    var rectangulo = new Rectangulo(baseRect, altura);
    Console.WriteLine($"\n→ Área del rectángulo: {rectangulo.CalcularArea():F4}");
}

static void CalcularTriangulo()
{
    Console.Write("\nIngresa la base del triángulo: ");
    double baseTri = double.Parse(Console.ReadLine()!);

    Console.Write("Ingresa la altura del triángulo: ");
    double altura = double.Parse(Console.ReadLine()!);

    var triangulo = new Triangulo(baseTri, altura);
    Console.WriteLine($"\n→ Área del triángulo: {triangulo.CalcularArea():F4}");
}