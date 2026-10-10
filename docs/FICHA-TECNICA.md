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
---

### 5.5 Historia de usuario: US-02 Calcular área de un rectángulo

**Historia:** *Como usuario quiero calcular el área de un rectángulo para conocer su superficie a partir de base y altura.*

### 5.6 Pseudocódigo

```
INICIO

CLASE Rectangulo HEREDA DE Figura
    PROPIEDAD Base: decimal
    PROPIEDAD Altura: decimal

    CONSTRUCTOR(base, altura)
        SI base <= 0 ENTONCES
            LANZAR ArgumentOutOfRangeException("La base debe ser mayor a 0")
        FIN SI
        SI altura <= 0 ENTONCES
            LANZAR ArgumentOutOfRangeException("La altura debe ser mayor a 0")
        FIN SI
        Base = base
        Altura = altura
    FIN CONSTRUCTOR

    FUNCIÓN SOBRESCRITA CalcularArea() RETORNA decimal
        RETORNAR Base * Altura
    FIN FUNCIÓN
FIN CLASE

FIN
```

### 5.7 Relación entre pseudocódigo y POO

| Pilar POO | Líneas del pseudocódigo | Descripción |
|---|---|---|
| **Abstracción** | 3 | `Rectangulo` hereda el contrato de `Figura` |
| **Encapsulamiento** | 6-14 | Base y altura validadas en el constructor |
| **Herencia** | 3 | `Rectangulo : Figura` |
| **Polimorfismo** | 16-18 | `CalcularArea()` sobrescrito con fórmula b×h |

### 5.8 Criterios de aceptación

- [ ] Dado base=4, altura=5, el área es 20
- [ ] Dado base=0, se lanza `ArgumentOutOfRangeException`
- [ ] Dado base=-1, se lanza `ArgumentOutOfRangeException`
- [ ] Dado altura=0, se lanza `ArgumentOutOfRangeException`
- [ ] Dado altura=-3, se lanza `ArgumentOutOfRangeException`
---

### 5.9 Historia de usuario: US-03 Calcular área de un triángulo

**Historia:** *Como usuario quiero calcular el área de un triángulo para conocer su superficie a partir de base y altura.*

### 5.10 Pseudocódigo

```
INICIO

CLASE Triangulo HEREDA DE Figura
    PROPIEDAD Base: decimal
    PROPIEDAD Altura: decimal

    CONSTRUCTOR(base, altura)
        SI base <= 0 ENTONCES
            LANZAR ArgumentOutOfRangeException("La base debe ser mayor a 0")
        FIN SI
        SI altura <= 0 ENTONCES
            LANZAR ArgumentOutOfRangeException("La altura debe ser mayor a 0")
        FIN SI
        Base = base
        Altura = altura
    FIN CONSTRUCTOR

    FUNCIÓN SOBRESCRITA CalcularArea() RETORNA decimal
        RETORNAR (Base * Altura) / 2
    FIN FUNCIÓN
FIN CLASE

FIN
```

### 5.11 Relación entre pseudocódigo y POO

| Pilar POO | Líneas del pseudocódigo | Descripción |
|---|---|---|
| **Abstracción** | 3 | `Triangulo` hereda el contrato de `Figura` |
| **Encapsulamiento** | 6-14 | Base y altura validadas en el constructor |
| **Herencia** | 3 | `Triangulo : Figura` |
| **Polimorfismo** | 16-18 | `CalcularArea()` sobrescrito con fórmula (b×h)/2 |

### 5.12 Criterios de aceptación

- [ ] Dado base=6, altura=4, el área es 12
- [ ] Dado base=0, se lanza `ArgumentOutOfRangeException`
- [ ] Dado base=-1, se lanza `ArgumentOutOfRangeException`
- [ ] Dado altura=0, se lanza `ArgumentOutOfRangeException`
- [ ] Dado altura=-2, se lanza `ArgumentOutOfRangeException`
---

## 6. Metodología ágil aplicada

### 6.1 Historias de usuario completadas

| ID | Historia | Pruebas | Estado |
|---|---|---|---|
| US-01 | Calcular área de un círculo | 4 | ✅ |
| US-02 | Calcular área de un rectángulo | 5 | ✅ |
| US-03 | Calcular área de un triángulo | 5 | ✅ |
| **Total** | | **14** | ✅ |

### 6.2 Ciclo TDD aplicado por historia

| Historia | Commit rojo | Commit verde |
|---|---|---|
| US-01 Círculo | `e3c12dd4` | `7349f31` |
| US-02 Rectángulo | `709e597` | `2a1d303` |
| US-03 Triángulo | `649c98b` | `88e4aed` |

### 6.3 Pipeline CI

El archivo `.github/workflows/ci.yml` ejecuta automáticamente en cada push a `main` y en cada PR:

1. Descarga el código
2. Instala .NET 8
3. Compila `Figuras.Core.csproj` en Release
4. Ejecuta las 14 pruebas

Si alguna prueba falla, el PR queda bloqueado.

---

## 7. Autoevaluación

| Criterio | ¿Cumplido? | Observaciones |
|---|---|---|
| Modelé clases con atributos esenciales | ✅ | `Figura`, `Circulo`, `Rectangulo`, `Triangulo` |
| Apliqué los 4 pilares de POO | ✅ | Abstracción, Herencia, Polimorfismo, Encapsulamiento |
| Documenté con XML los métodos públicos | ✅ | Todas las clases y métodos |
| Configuré correctamente el proyecto | ✅ | .NET 8 LTS, xUnit, GitHub Actions |
| Usé Git para versionar | ✅ | Ramas por feature, PRs, commits atómicos |
| Construí pseudocódigo fundamentado | ✅ | Sección 5 con tablas POO |
| Apliqué TDD (rojo → verde) | ✅ | 3 ciclos completos |
| Usé Integración Continua | ✅ | Pipeline en cada PR |

---

## 8. Conclusiones

El desarrollo de este proyecto permitió aplicar los fundamentos de la programación avanzada mediante un enfoque disciplinado y ágil:

1. **POO en la práctica:** La clase abstracta `Figura` definió un contrato que las clases `Circulo`, `Rectangulo` y `Triangulo` implementaron, demostrando los 4 pilares fundamentales.

2. **TDD como disciplina:** Cada historia comenzó con pruebas que fallaban, seguidas por la implementación mínima para pasarlas, garantizando código verificado desde el inicio.

3. **Integración Continua:** El pipeline de GitHub Actions detecta errores automáticamente antes del merge, reduciendo el riesgo de bugs.

4. **Documentación XML:** Todos los métodos públicos están documentados, facilitando el mantenimiento y el trabajo en equipo.

5. **Metodología ágil:** El uso de ramas por feature, PRs, Issues y tablero Kanban estructuró el trabajo en incrementos pequeños y verificables.

Este flujo de trabajo es replicable en cualquier proyecto profesional de software.
---

## 6. Metodología ágil aplicada

### 6.1 Historias de usuario completadas

| ID | Historia | Pruebas | Estado |
|---|---|---|---|
| US-01 | Calcular área de un círculo | 4 | ✅ |
| US-02 | Calcular área de un rectángulo | 5 | ✅ |
| US-03 | Calcular área de un triángulo | 5 | ✅ |
| **Total** | | **14** | ✅ |

### 6.2 Ciclo TDD aplicado por historia

| Historia | Commit rojo | Commit verde |
|---|---|---|
| US-01 Círculo | `e3c12dd4` | `7349f31` |
| US-02 Rectángulo | `709e597` | `2a1d303` |
| US-03 Triángulo | `649c98b` | `88e4aed` |

### 6.3 Pipeline CI

El archivo `.github/workflows/ci.yml` ejecuta automáticamente en cada push a `main` y en cada PR:

1. Descarga el código
2. Instala .NET 8
3. Compila `Figuras.Core.csproj` en Release
4. Ejecuta las 14 pruebas

Si alguna prueba falla, el PR queda bloqueado.

---

## 7. Autoevaluación

| Criterio | ¿Cumplido? | Observaciones |
|---|---|---|
| Modelé clases con atributos esenciales | ✅ | `Figura`, `Circulo`, `Rectangulo`, `Triangulo` |
| Apliqué los 4 pilares de POO | ✅ | Abstracción, Herencia, Polimorfismo, Encapsulamiento |
| Documenté con XML los métodos públicos | ✅ | Todas las clases y métodos |
| Configuré correctamente el proyecto | ✅ | .NET 8 LTS, xUnit, GitHub Actions |
| Usé Git para versionar | ✅ | Ramas por feature, PRs, commits atómicos |
| Construí pseudocódigo fundamentado | ✅ | Sección 5 con tablas POO |
| Apliqué TDD (rojo → verde) | ✅ | 3 ciclos completos |
| Usé Integración Continua | ✅ | Pipeline en cada PR |

---

## 8. Conclusiones

El desarrollo de este proyecto permitió aplicar los fundamentos de la programación avanzada mediante un enfoque disciplinado y ágil:

1. **POO en la práctica:** La clase abstracta `Figura` definió un contrato que las clases `Circulo`, `Rectangulo` y `Triangulo` implementaron, demostrando los 4 pilares fundamentales.

2. **TDD como disciplina:** Cada historia comenzó con pruebas que fallaban, seguidas por la implementación mínima para pasarlas, garantizando código verificado desde el inicio.

3. **Integración Continua:** El pipeline de GitHub Actions detecta errores automáticamente antes del merge, reduciendo el riesgo de bugs.

4. **Documentación XML:** Todos los métodos públicos están documentados, facilitando el mantenimiento y el trabajo en equipo.

5. **Metodología ágil:** El uso de ramas por feature, PRs, Issues y tablero Kanban estructuró el trabajo en incrementos pequeños y verificables.

Este flujo de trabajo es replicable en cualquier proyecto profesional de software.