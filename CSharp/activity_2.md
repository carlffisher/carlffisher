# Activity 2
## Introduction to Object-Oriented Programming (OOP)

## Exercise 2.1 - Introductory Reading - Object-Oriented Programming (OOP)

### What is a Object-Oriented Programming (OOP)?

Object-Oriented Programming (OOP) is a Software Engineering paradigm to enable the ability to model real-world things as 'objects' in code. The blueprint on how to make these 'objects' are defined by 'classes'.

For example, I have a class which sets out the blueprint on how to make a gingerbread loaf cake. If I'm hungry, I can make many objects (instances) of a gingerbread loaf cake. Yummy! This process has a fancy name called 'instantiation'.

### Can you tell me what the Four Pillars of OOP are?

The Four Pillars of OOP are:

- Abstraction
- Encapsulation
- Inheritance
- Polymorphism

We've already explored the first pillar, which is **Abstraction** in Activity 1. Here's a quick recap.

### Pillar 1 - What is 'Abstraction'?

A model is a representation of reality; a computer model is a representation of reality in computational form. In Software Engineering, we need to think about the detail we are trying to capture and how we're going to abstract it, i.e. capture the information we need to enable us to represent the behaviours of a given system in code.

Our next pillar is **Encapsulation**.

### Pillar 2 - What is Encapsulation?

Encapsulation means hiding the details of an object which is not supposed to be open for interaction publicly. Any private details are kept well-encapsulated and hidden away, so that only the details which are allowed to interact with other objects can be accessed from outside of that object. In Software Engineering, this is important to protect an object from misuse.

---

## Exercise 2.2 - Introductory Reading - Class Diagrams & the Unified Modelling Language (UML)

### What is a Class Diagram?

The Unified Modelling Language (UML) is a visualisation technique to visualize/model the design of a system in Software Engineering and can be applied to any set of programming languages or technologies.

A Class Diagram is part of the Unified Modelling Language (UML). You can read more about the Class Diagram [here](https://www.visual-paradigm.com/guide/uml-unified-modeling-language/what-is-class-diagram/).

---

## Exercise 2.3 - Draw a class diagram to represent a `Bird` class

In this exercise, use the Class Diagram from the Unified Modelling Language (UML) to model a `Bird` class with the following attributes and methods (behaviours).

These attributes and methods (behaviours) are often called 'members' of a class. All of the following class members are public, i.e. they are open for interaction from outside of that class.

You can use pen and paper or any digital drawing tool you prefer.

Attributes:
- Name, Color

The attributes will be represented as string data types.

Methods:
- Speak, Fly

The methods don't have a return data type as they will be writing output strings to the console.

An example solution to the diagram is available [here](../solutions/activity_2_exercise_2.3.png).

---

## Exercise 2.4 - Translate the class diagram into code to create a `Bird` class

- Create a new .NET 6 Console Application Project.

You can refer to the Microsoft Documentation on how to do this for [Visual Studio 2022](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio) or [Visual Studio for Mac](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac). Throughout the programme, we recommend you conduct your own research using the Microsoft Documentation.

- Add an empty class called `Bird`

- Add the following code to create the `Bird` class

```csharp

public class Bird
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void Speak() 
    {
        Console.WriteLine($"My name is {Name} and I am a {Color} bird.");
    }

    public void Fly() 
    {
        Console.WriteLine($"I'm {Name} and I can fly high in the blue sky!");
    }
}

```

---

## Exercise 2.5 - Run your console application

- Add the following code to the `main` method in the `program.cs` file.

```csharp

Bird myBird = new Bird("Tweety", "Yellow");
myBird.Speak();
myBird.Fly();

```

- Run your console application. You should see the following output to your console.

```

My name is Tweety and I am a Yellow bird.
I'm Tweety and I can fly high in the blue sky!

```
---

### What's next?

What if we wanted to create a pigeon that behaves just like a bird? It wouldn't be good to repeat the same code again in another class called `Pigeon`. What if there was a `Chicken` as well, it wouldn't be nice to have that code again every time we wanted to replicate the same set of attributes and behaviours. How can we form relationships between classes in code? Could we borrow the concept of inheritance from the natural world to help us? Head over to [Introduction to Inheritance in Activity 3](./activity_3.md) to find out more.

---

### Key Study Notes

- *Object-Oriented Programming* - Object-Oriented Programming (OOP) is a Software Engineering paradigm to enable the ability to model real-world things as 'objects' in code. The blueprint on how to make these 'objects' are defined by 'classes'.

- *Encapsulation* - Encapsulation means hiding the details of an object which is not supposed to be open for interaction publicly.