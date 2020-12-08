# ITP Style Guide

A style guide for Introduction to Programming projects in IAM. 

## Table of Contents

- [ITP Style Guide](#itp-style-guide)
  - [Table of Contents](#table-of-contents)
  - [Golden Rules](#golden-rules)
  - [Naming](#naming)
    - [Descriptive Naming](#descriptive-naming)
    - [Casing](#casing)
  - [Brace Style](#brace-style)
  - [Indentation](#indentation)
  - [Access Level Modifiers](#access-level-modifiers)
  - [Remove Unused Code](#remove-unused-code)

## Golden Rules

- Favor clarity in your code. Code is meant to be read - by teammates or by yourself in the future - so aim to make your code readable.
- Use consistent style conventions when writing your code. When you write your code in a consistent style, it is easier to read.

The following two classes do the same thing - which of these is easier to read?

```cs
// Option 1 - inconsistent style and unclear names
class P {
    private string THISTHING;
    private int the_AGE;

    public P(string par1, int Par2) {
THISTHING = par1;
        the_AGE = Par2;


    }

public void speakthatthing()
{WriteLine($"I'm {THISTHING} and I'm {the_AGE} years old");}
        }

// Option 2 - consistent style and clear names
class Player {
    private string Name;
    private int Age;

    public Player(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Speak()
    {
        WriteLine($"I'm {Name} and I'm {Age} years old");
    }
}
```

## Naming

In gereral, naming should follow C# standards. See Microsoft's [naming conventions guide](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions) and [capitalization guide](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions).

### Descriptive Naming

- Favor clarity and readability over brevity. `CanScrollHorizontally` is more understandable than `ScrollableX`, and both are better than a random variable named `s`!
- Classes/variables/fields/properties should generally be nouns, `explosiveForce` instead of `explode`.
- Methods/functions should generally be verbs, `ApplyHorizontalForce` instead of `HorizontalForce`.
- Bool variables should generally be framed as a question, `isInvulernable` or `hasKey`.

### Casing

| Identifier      | Casing     | Example             |
| --------------- | ---------- | ------------------- |
| Class           | PascalCase | `RadialSlider`      |
| Methods         | PascalCase | `TakeItem()`        |
| Fields          | PascalCase | `CraftingInventory` |
| Properties      | PascalCase | `CurrentMusicTrack` |
| Parameters      | camelCase  | `playerLocation`    |
| Local Variables | camelCase  | `explosiveForce`    |

Here is an example that incorporates all of these:

```cs
// PascalCase for Class:
class VirtualPet
{
    // PascalCase for fields:
    protected string Type;
    protected double Weight;
    protected ConsoleColor Color;
    protected Present CurrentPresent;

    // PascalCase for properties:
    public string Name { get; protected set; }
    // Bool framed as a question:
    public bool IsHungry { get; protected set; } = false;

    // PascalCase for methods and camelCase for parameters:
    public VirtualPet(string name, ConsoleColor color, string type, double weight)
    {
        Name = name;
        Color = color;
        Type = type;
        Weight = weight;
    }

    // Method named as a verb, parameter named as a noun:
    public void TakePresent(Present present)
    {
        CurrentPresent = present;
    }

    // Method named as a verb, parameter named as a noun:
    public void Greet(string playerName)
    {
        ForegroundColor = Color;

        // camelCase for local variables:
        string message = $"Hi {playerName}, my name is {Name}.";
        message += $"I'm a {Type}.";
        WriteLine(message);

        // Proper nesting and spacing:
        if (CurrentPresent != null)
        {
            WriteLine($"I have {CurrentPresent.Quantity}x {CurrentPresent.Name}.");
        }
        else
        {
            WriteLine("I have no present.");
        }

        ResetColor();
    }
}
```

Tip: you can easily rename a field/method/class/etc. in Visual Studio. See [this guide](https://docs.microsoft.com/en-us/visualstudio/ide/reference/rename?view=vs-2019).

## Brace Style

All braces get their own line as it is a C# convention:

**AVOID:**

```csharp
class MyClass {
    void DoSomething() {
        if (someTest) {
          // ...
        } else {
          // ...
        }
    }
}
```

**PREFER:**

```csharp
class MyClass
{
    void DoSomething()
    {
        if (someTest)
        {
          // ...
        }
        else
        {
          // ...
        }
    }
}
```

## Indentation

Each nested code block should be indented over by one tab:

**AVOID:**

```csharp
class MyClass
{
void DoSomething()
{
if (someTest)
{
for (int i = 0; i < 10; i++)
{
    WriteLine($"The count is {i}");
}
}
else
{
    // ...
}
}
}
```

**PREFER:**

```csharp
class MyClass
{
    void DoSomething()
    {
        if (someTest)
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLine($"The count is {i}");
            }
        }
        else
        {
          // ...
        }
    }
}
```

## Access Level Modifiers

- Default to making everything `private`. Only use a more permissive access level (like `public`) when it is necessary.
- Use properties to control get and set access levels separately (e.g. `public string Name {get; private set;}`).

## Remove Unused Code

- Remove commented out code.
- Remove unused variables or methods.
