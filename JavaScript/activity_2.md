# Activity 2
## Introduction to Object-Oriented Programming (OOP)

## Exercise 2.1 - Introductory Reading - Object-Oriented Programming (OOP)

### What is a Object-Oriented Programming (OOP)?

Object-Oriented Programming (OOP) is a Software Engineering paradigm to enable the ability to model real-world things as 'objects' in code. The blueprint on how to make these 'objects' are defined by 'classes'.

For example, I have a class which sets out the blueprint on how to make a gingerbread loaf cake. If I'm hungry, I can make many objects (instances) of a gingerbread loaf cake. Yummy! This process has a fancy name called 'instantiation'.

### What is OOJS?

JavaScript isn't a classic Object-Oriented programming language like Java or C#. 

OOJS (Object-Oriented JavaScript) is the name given to describe how JavaScript can mimic Object-Oriented Programming features.

JavaScript has a Prototype-based Object-Oriented Programming model. It creates objects using other objects as blueprints. To implement inheritance, it manipulates something called the 'prototype chain'.

### What does that mean?!

For the sake of this tutorial don't worry about Prototypes just yet - we will be covering this later on in the course (phew!).

For now, just know that JavaScript isn't a truly Object-Oriented language. It *mimics* the behaviour of classes with syntactic sugar (i.e the fancy, complicated behaviour has been hidden away under the 'class' keyword so we don't have to worry about it).

Now, back to OOP concepts!

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

## Pre-Requisites

Before moving onto the next exercise which utilises JavaScript ECMAScript 2015 classes, make sure you are comfortable using JavaScript [Objects](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects).

## Exercise 2.3 - Draw a class diagram to represent a `Bird` class

Before the release of JavaScript ECMAScript 2015, the problem of inheritance was solved using JavaScript Prototypes. For the sake of brevity we won't be going into Prototypal Inheritance in this tutorial, instead focussing on modern JavaScript 'Classes'. However, if you are interested in learning about Prototypal Inheritance you can read about it [here](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Inheritance_and_the_prototype_chain).

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

- Create a new JavaScript Command Line project with node.js.

You can refer to Visual Studio Code's Node.js/JavaScript documentation tutorial on how to create and run a simple command line project [here](https://code.visualstudio.com/docs/nodejs/nodejs-tutorial).

- Add an empty class called `Bird`

- In your Project JavaScript file add the following code to create the `Bird` class

```JavaScript

class Bird {
  // The constructor method creates and initializes an object for our `Bird` class
  constructor(name, color) {
    // The 'this' keyword attaches properties to this new `Bird` object
    this.name = name;
    this.color = color;
  }

  speak() {
    console.log(`My name is ${this.name} and I am a ${this.color} bird.`);
  };

  fly() {
    console.log(`I'm ${this.name} and I can fly high in the blue sky!`);
  };
}
```

---

## Exercise 2.5 - Run your console application

- Add the following code to your JavaScript file underneath your bird class.

```JavaScript

const myBird = new Bird("Tweety", "Yellow");
myBird.speak();
myBird.fly();

```

### The 'new' keyword 
- creates a new, empty `Bird` object {}
- sets the value of the `this` keyword to be the new, empty object
- calls the constructor method 
- passes parameters to the constructor method


- Now run your console application. You should see the following output to your console:

```

My name is Tweety and I am a Yellow bird.
I'm Tweety and I can fly high in the blue sky!

```

#### Note: Under the hood, your Bird class is being converted into a [Prototypal Inheritance model](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Inheritance_and_the_prototype_chain) — the above way of writing classes in JavaScript is just [syntactic sugar](https://en.wikipedia.org/wiki/Syntactic_sugar). 


---

### What's next?

What if we wanted to create a pigeon that behaves just like a bird? It wouldn't be good to repeat the same code again in another class called `Pigeon`. What if there was a `Chicken` as well, it wouldn't be nice to have that code again every time we wanted to replicate the same set of attributes and behaviours. How can we form relationships between classes in code? Could we borrow the concept of inheritance from the natural world to help us? Head over to [Introduction to Inheritance in Activity 3](./activity_3.md) to find out more.

---

### Key Study Notes

- *Object-Oriented Programming* - Object-Oriented Programming (OOP) is a Software Engineering paradigm to enable the ability to model real-world things as 'objects' in code. The blueprint on how to make these 'objects' are defined by 'classes'.

- *Encapsulation* - Encapsulation means hiding the details of an object which is not supposed to be open for interaction publicly.