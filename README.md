# Figuras Geométricas

Biblioteca de clases en C# que calcula el área de figuras geométricas aplicando los 4 pilares de POO, TDD y un pipeline de Integración Continua en GitHub Actions.

## 📋 Descripción

- **Círculo** — π × radio²
- **Rectángulo** — base × altura
- **Triángulo** — (base × altura) / 2

Todas las figuras heredan de la clase abstracta `Figura` e implementan el método `CalcularArea()`.

## 🏗️ Estructura del proyecto

```
figuras-geometricas/
├── .github/workflows/ci.yml         # Pipeline CI
├── docs/
│   └── FICHA-TECNICA.md             # Ficha técnica completa
├── src/Figuras.Core/                # Biblioteca de clases
│   ├── Figura.cs
│   ├── Circulo.cs
│   ├── Rectangulo.cs
│   ├── Triangulo.cs
│   └── Figuras.Core.csproj
├── tests/Figuras.Tests/             # Pruebas unitarias
│   ├── FiguraTests.cs
│   └── Figuras.Tests.csproj
└── README.md
```

## 🚀 Cómo ejecutar

### Requisitos previos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git

### Clonar y ejecutar

```bash
git clone https://github.com/brandonprieto-lgtm/figuras-geometricas.git
cd figuras-geometricas
dotnet test tests/Figuras.Tests/Figuras.Tests.csproj
```

### Resultado esperado

```
Passed!  - Failed: 0, Passed: 14, Skipped: 0, Total: 14
```

## 🧪 Historias de usuario completadas

| ID | Historia | Estado |
|---|---|---|
| US-01 | Calcular área de un círculo | ✅ |
| US-02 | Calcular área de un rectángulo | ✅ |
| US-03 | Calcular área de un triángulo | ✅ |

## 🔄 Flujo de trabajo (Git + GitHub)

```
Rama → Pruebas (rojo) → Implementación (verde) → Commit → Push → PR → CI verde → Merge
```

## ⚙️ Pipeline CI

Cada push a `main` y cada Pull Request ejecuta automáticamente:

1. Descarga el código
2. Instala .NET 8
3. Compila en modo Release
4. Ejecuta las 14 pruebas

## 🛠️ Tecnologías

- **C# 12** (.NET 8 LTS)
- **xUnit** (framework de pruebas)
- **GitHub Actions** (CI/CD)
- **Scrum + TDD** (metodología)
- **POO** (4 pilares: abstracción, herencia, polimorfismo, encapsulamiento)

## 📚 Documentación adicional

- [Ficha Técnica](docs/FICHA-TECNICA.md)

## 👤 Autor

**Brandon Prieto**
Repositorio: [brandonprieto-lgtm/figuras-geometricas](https://github.com/brandonprieto-lgtm/figuras-geometricas)