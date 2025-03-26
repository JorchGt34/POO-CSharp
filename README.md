# Programación Orientada a Objetos con C#

## Paradigma de la programación

Son las formas o estilos en los que podemos programar y estructurar nuestro código. Algunos de los paradigmas más importantes son:

* Programación funcional
* Programación estructurada
* Programación reactiva
* Programación orientada a aspectos
* Programación orientada a objetos

## C# - multiparadigma

Este lenguaje es multiparadigma, lo que significa que soporta diferentes formas o estilos de programación. Algunos de los paradigmas más desarrollados en C# son:

* Programación imperativa
* Programación funcional
* Programación orientada a objetos
* Programación reflectiva
* Programación genérica
* Programación estructurada

## ¿Qué es la programación orientada a objetos?

La programación orientada a objetos (POO) es un paradigma de la programación que tiene como objetivo extraer de la realidad los algoritmos en nuestro código. Se basa en dos conceptos muy importantes:

* **Clases**
* **Objetos**

Los elementos base para la programación orientada a objetos son las clases y objetos, donde estas definen propiedades y comportamientos como una plantilla.

* **Encapsulamiento**: Oculta valores reales o detalles que se encuentren en nuestras clases.
* **Herencia**: Permite reutilizar código en POO pasando propiedades de una clase a otra.
* **Polimorfismo**: Define diferentes comportamientos para el mismo método aceptando los mismos valores y propiedades.
* **Abstracción**: Permite omitir detalles de implementaciones en la clase, lo que facilita la reutilización de código para múltiples escenarios.

El objetivo de la POO es reutilizar código y crear múltiples objetos a partir de las clases.

## Prerrequisitos

- Conocimientos de C# y .NET
- .NET 7 o superior
- Visual Studio Code o Visual Studio

## Análisis

Es importante analizar un objeto de la realidad para llevarlo al código y definir sus características más importantes. Por ejemplo, las características más importantes de un control de Xbox serían:

- 20 botones (Xbox Elite específico, no en general)
- Color negro con detalles metálicos en gris
- 2 palancas
- 1 entrada jack de audio
- 1 puerto para accesorios de Xbox

Una vez hecho el análisis, se puede comenzar a realizar una clase que contenga estas características.

## Clases

Una clase define las características de un objeto en general. Son la plantilla para crear objetos y contienen propiedades (atributos) y métodos (comportamientos).

La estructura de una clase es la siguiente:

```csharp
class Plumon 
{
    public string Color;
}
```

Para crear un objeto de esta clase:

```csharp
Plumon plumonAzul = new Plumon();
```

Y asignar valores a sus propiedades:

```csharp
plumonAzul.Color = "Azul";
```

### Ejemplo de análisis de aves

Las aves tienen las siguientes propiedades:

- Nombre
- Color
- Tamaño
- Familia
- Ubicación
- Sexo biológico
- Es voladora

## Objetos

Los objetos son las instancias de las clases y se utilizan para almacenar datos o ejecutar acciones definidas en la clase.

En C#, los objetos deben ser declarados antes de que la clase se utilice.

Cabe destacar que POO no solo representa objetos reales, sino también objetos ficticios o abstractos.

## Arrays en C#

La declaración de un array en C# es la siguiente:

```csharp
string[] Superpoderes;
```

Si se declara en una clase, se debe inicializar antes de asignarle valores:

```csharp
superman.SuperPoderes = new[]{"Volar", "Superfuerza", "Visión láser"};
```

## Enumeraciones

Las enumeraciones son estructuras que contienen una lista de valores específicos:

```csharp
enum Nivel 
{
    NivelUno,
    NivelDos,
    NivelTres
}
```

## List<>

Las listas en C# permiten almacenar múltiples elementos de cualquier tipo de dato:

```csharp
List<string> poderesSuperman = new List<string>();
poderesSuperman.Add("Volar");
```

## Constructor y datos iniciales en una clase

El constructor inicializa los valores de una clase:

```csharp
public class Persona 
{
    private string apellido;
    private string nombre;

    public Persona()
    {
        apellido = "";
        nombre = "";
    }
}
```

## Métodos

Los métodos son instrucciones dentro de una clase que realizan una acción:

```csharp
public void UsarSuperPoderes()
{
    foreach (var poder in SuperPoderes)
    {
        Console.WriteLine($"{Nombre} está usando el superpoder {poder}");
    }
}
```

## Modificadores de acceso

Los modificadores de acceso definen el alcance de los elementos dentro de una clase:

* `public`: Acceso sin restricciones
* `protected`: Acceso limitado a la clase y sus derivadas
* `internal`: Acceso limitado al ensamblado actual
* `private`: Acceso limitado al tipo contenedor

## Namespace

Un `namespace` es un espacio de código que se puede reutilizar en otros archivos:

```csharp
using MiNamespace;
```

## Herencia

La herencia permite que una clase hija reutilice propiedades y métodos de una clase padre:

```csharp
public class ClaseHija : ClasePadre
```

## Abstracción

Una clase abstracta define métodos sin implementación:

```csharp
internal abstract class Heroe
{
    public abstract string Nombre { get; set; }
    public abstract string SalvarElMundo();
}
```

## Polimorfismo

El polimorfismo permite redefinir métodos en clases derivadas:

```csharp
public override string SalvarLaTierra()
{
    return $"{NombreEIdentidadSecreta} ha salvado la Tierra";
}
```

## Interfaces

Las interfaces definen un contrato para garantizar la estructura de una clase:

```csharp
internal interface ISuperHeroe
{
    int Id { get; set; }
    string Nombre { get; set; }
    string IdentidadSecreta { get; set; }
}
```

## Diferencia entre Clases Abstractas e Interfaces

| Característica          | Clases Abstractas | Interfaces |
|------------------------|-----------------|-----------|
| Permiten herencia única | Sí             | No        |
| Permiten múltiples implementaciones | No | Sí |
| Permiten implementación de métodos | Sí | No (hasta C# 8.0) |
| Se recomienda para | Reutilización de código | Patrones de diseño e inyección de dependencias |

## C# 8 - Métodos de interfaz por defecto

```csharp
interface IA
{
    void M() { Console.WriteLine("IA.M"); }
}