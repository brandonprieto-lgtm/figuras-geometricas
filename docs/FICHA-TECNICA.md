# Ficha Técnica - Sistema de Figuras Geométricas

**Temática:** 2 - Introducción a la Programación Avanzada
**Asignatura:** Programación Avanzada (ISP01)
**Estudiante:** Brandon Prieto
**Fecha:** Octubre 2026
**Repositorio:** https://github.com/brandonprieto-lgtm/figuras-geometricas

---

## 1. Datos generales del proyecto

| Campo | Descripción |
|---|---|
| **Nombre del proyecto** | Sistema de Figuras Geométricas |
| **Objetivo general** | Calcular el área de distintas figuras geométricas aplicando los 4 pilares de POO |
| **Lenguaje de programación** | C# (.NET 8) |
| **IDE utilizado** | Visual Studio Code + C# Dev Kit |
| **Control de versiones** | Git + GitHub |
| **Metodología** | Scrum + TDD |

### 1.1 Descripción del problema

> Un sistema educativo necesita una biblioteca reutilizable que permita calcular el área de diferentes figuras geométricas (círculo, rectángulo, triángulo) usando un diseño orientado a objetos que facilite agregar nuevas figuras en el futuro sin modificar el código existente.

### 1.2 Alcance del proyecto

**Incluye:**
- Cálculo del área de un círculo
- Cálculo del área de un rectángulo
- Cálculo del área de un triángulo
- Validación de valores positivos
- Pruebas unitarias automatizadas
- Pipeline de Integración Continua

**No incluye (fuera de alcance):**
- Interfaz gráfica
- Cálculo de perímetro
- Cálculo de volumen (figuras 3D)
- Persistencia en base de datos

---

## 2. Fundamentos de POO aplicados al proyecto

### 2.1 Abstracción

| Pregunta | Respuesta |
|---|---|
| **¿Qué se abstrajo?** | El concepto de "Figura geométrica" con la propiedad esencial `CalcularArea()` |
| **¿Por qué?** | Todas las figuras comparten que se puede calcular su área, sin importar su forma |
| **Clase abstracta creada** | `Figura` |

### 2.2 Encapsulamiento

| Pregunta | Respuesta |
|---|---|
| **¿Qué se encapsula?** | Las propiedades `Radio`, `Base`, `Altura`, `LadoA`, `LadoB`, `LadoC` con validación |
| **¿Cómo se controla?** | Los valores deben ser mayores que 0, si no, se lanza `ArgumentOutOfRangeException` |
| **Modificadores usados** | `public` para propiedades y métodos, con setters que validan |

### 2.3 Herencia

| Pregunta | Respuesta |
|---|---|
| **Clase base** | `Figura` |
| **Clases derivadas** | `Circulo`, `Rectangulo`, `Triangulo` |
| **Métodos heredados** | `CalcularArea()` (abstracto, cada hija lo implementa) |
| **Ventaja** | Agregar una nueva figura no requiere modificar el código existente |

### 2.4 Polimorfismo

| Pregunta | Respuesta |
|---|---|
| **Método polimórfico** | `CalcularArea()` |
| **Clases que lo implementan** | `Circulo` (π·r²), `Rectangulo` (b·h), `Triangulo` (b·h/2) |
| **Diferencia** | Cada clase aplica su propia fórmula matemática |

---

## 3. Entorno de desarrollo y configuración

### 3.1 IDE y herramientas

| Herramienta | Versión | Propósito |
|---|---|---|
| Visual Studio Code | 1.141.0 | Editor de código |
| C# Dev Kit | Última | Soporte para C# |
| .NET SDK | 8.0 | Compilador y runtime |
| Git | Última | Control de versiones |
| GitHub | - | Repositorio remoto |

### 3.2 Estructura del proyecto

```
figuras-geometricas/
├── docs/
│   └── FICHA-TECNICA.md            # Este documento
├── src/
│   └── Figuras.Core/               # Biblioteca de clases (lógica de negocio)
│       ├── Figura.cs
│       ├── Circulo.cs
│       ├── Rectangulo.cs
│       ├── Triangulo.cs
│       └── Figuras.Core.csproj
├── tests/
│   └── Figuras.Tests/              # Pruebas unitarias
│       ├── FiguraTests.cs
│       └── Figuras.Tests.csproj
└── .gitignore
```

### 3.3 Configuración del proyecto

| Configuración | Valor | Justificación |
|---|---|---|
| **TargetFramework** | `net8.0` | LTS (Long Term Support) |
| **Nullable** | `enable` | Evita errores con `null` |
| **ImplicitUsings** | `enable` | Menos código repetitivo |
| **Framework de pruebas** | xUnit | Estándar en .NET |

### 3.4 Dependencias

| Paquete | Versión | Uso |
|---|---|---|
| xunit | 2.9.3 | Framework de pruebas |
| Microsoft.NET.Test.Sdk | 17.14.1 | SDK de pruebas |
| coverlet.collector | 6.0.4 | Cobertura de código |

---

## 4. Documentación del código

### 4.1 Documentación XML aplicada

Todos los métodos públicos de las clases se documentarán con XML:

```csharp
/// <summary>
/// Calcula el área de la figura.
/// </summary>
/// <returns>Área calculada en unidades cuadradas.</returns>
public override double CalcularArea()
{
    return Math.PI * Radio * Radio;
}
```

### 4.2 Etiquetas XML usadas en el proyecto

| Etiqueta | Uso |
|---|---|
| `<summary>` | Descripción general del método |
| `<param>` | Descripción de cada parámetro |
| `<returns>` | Descripción del valor retornado |
| `<exception>` | Excepciones que puede lanzar |

---

## 5. Pseudocódigo con fundamento técnico

### 5.1 Historia de usuario: US-01 Calcular área de un círculo

**Historia:** *Como usuario quiero calcular el área de un círculo para conocer su superficie a partir del radio.*

### 5.2 Pseudocódigo

```
INICIO

CLASE ABSTRACTA Figura
    FUNCIÓN ABSTRACTA CalcularArea() RETORNA decimal
FIN CLASE

CLASE Circulo HEREDA DE Figura
    PROPIEDAD Radio: decimal

    CONSTRUCTOR(radio)
        SI radio <= 0 ENTONCES
            LANZAR ArgumentOutOfRangeException("El radio debe ser mayor a 0")
        FIN SI
        Radio = radio
    FIN CONSTRUCTOR

    FUNCIÓN SOBRESCRITA CalcularArea() RETORNA decimal
        RETORNAR PI * Radio * Radio
    FIN FUNCIÓN
FIN CLASE

FIN
```

### 5.3 Relación entre pseudocódigo y POO

| Pilar POO | Líneas del pseudocódigo | Descripción |
|---|---|---|
| **Abstracción** | 3-4 | Clase `Figura` define el contrato `CalcularArea()` |
| **Encapsulamiento** | 10-14 | El radio se valida en el constructor |
| **Herencia** | 6 | `Circulo` hereda de `Figura` |
| **Polimorfismo** | 17-19 | `Circulo` sobrescribe `CalcularArea()` con su fórmula |

### 5.4 Criterios de aceptación

- [ ] Dado radio = 1, el área es π (≈ 3.14159)
- [ ] Dado radio = 0, se lanza `ArgumentOutOfRangeException`
- [ ] Dado radio = -5, se lanza `ArgumentOutOfRangeException`
- [ ] Dado radio = 10, el área es 100π (≈ 314.159)
