# Activity 5
## Introduction to Interfaces

## Exercise 5.1 - Introductory Reading - Interfaces

### What is 'Multiple inheritance'?

Multiple inheritance is a programming concept where a subclass can inherit from more than one parent class. This can be useful as there might be many subclasses, that want some or all of various parent classes members or behaviours. However! Be aware! This can lead to something called the **Diamond Problem** where the same state or behaviour is defined in multiple parent classes, so the subclass doesn't know which one to inherit from. 🐛

Some programming languages have solved this problem with language restrictions i.e. you can't have multiple inheritance in C# or Java. If you try and inherit from multiple parent classes your IDE flags the issue.

**JavaScript doesn't support multiple inheritance. A subclass can only inherit from one base class.**

However it is useful to know about this concept because many languages *do* support multiple inheritance. Importantly, this issue is part of the reason interfaces were invented.

### What is an 'Interface'?

**Interfaces were invented as a way of defining the things an object can do i.e. their jobs**
- Interfaces are a way of getting round the Diamond of Death issue. If there is behaviour you would like many classes to implement, you can create an interface.

- Interfaces were invented as a way of defining the things an object can do i.e. their jobs. Another benefit is it lets unrelated classes do the same job.

- For example, if we had a `Person` class and subclasses of `Mum`, `Developer`, `Chef` and they are unrelated; but we wanted all of them to be able to sing then we can make an interface containing the method name for `sing()`. It is up to the `Mum`, `Developer` and `Chef` to sing in their own ways.

- This essentially means any class that implements an interface *must* implement *all* of the members defined in the interface. A 'contract' is also a term used to describe interfaces. This means that developers can have a higher degree of control on setting restrictions on what the classes implementing an interface must do.

**A class can only inherit from a *single* base class, but a class can implement *many* interfaces.**

- Interfaces can help keep code D.R.Y (don't repeat yourself)
If many classes share a behaviour, you can abstract this class into an interface. This saves repetition in your code.

---

## Exercise 5.1 - Representing interfaces in Unified Modelling Language (UML) diagrams

- Can you do some research to find out how to represent interfaces in UML diagrams?

- Draw a diagram to show the `Bird` class implementing the interface `IDance`

- The `IDance` interface contains the following methods that classes implementing the interface will provide an implementation for:

- Spin
- DoTheCaterpillar
- Jump

You can use pen and paper or any digital drawing tool you prefer.

An example solution to the diagram is available [here](../solutions/activity_5_exercise_5.1.png).

---

## Some bad news for JavaScript developers! 

Unlike C# or Java, JavaScript doesn't have an in-built way to use Interfaces (as of July 2021).

Therefore, many JS developers have developed their own solutions to create some sort of interface-like thing (not a true interface) - that mimics some of the behaviours interfaces offer. The solutions differ in approaches and pros and cons. Therefore there is no standardised way of achieving interfaces (yet!). 

For example:
	
[This person](https://geedew.com/basic-interfaces-in-nodejs/) makes an interface in using the ES6 class/constructor approach i.e. by creating a parent class or 'interface' 😉 that checks for a certain condition (i.e. if `getItems` exists as a function), and throws an error if the condition isn't met (in this case if `getItems` doesn't exist throw an error):

```JavaScript

class MenuInterface {
constructor() {
    //any object implementing the MenuInterface must have getItems otherwise an error is thrown
    if(!this.getItems) { 
      throw new Error("Menu's must have items!");  
    }
  }
}
```
	
[This person](https://codeburst.io/interfaces-in-javascript-with-es6-naive-implementation-91b703110a09) proposed a solution based on the ES6 Symbols.
	
Other people have developed their own custom [npm packages](https://www.npmjs.com/package/es6-interface) to create an interface-like solutions using JavaScript. 

[TypeScript](https://www.typescriptlang.org/docs/handbook/2/objects.html#interfaces-vs-intersections) is increasingly preferred since it offers the `Interface` keyword.

This [course](https://codecraft.tv/courses/angular/es6-typescript/classinterface/) is brilliant if you'd like to learn more about JavaScript ES6 features and TypeScript.

---

### What's next?

JavaScript has other concepts which are important, as already touched upon e.g. prototypal chains. JavaScript has cool design patterns e.g. module patterns such as IIFEs. We will be going into these in detail on the course to come.

For now, feel free to head back to review the OOP concepts again. We encourage you to do some of your own research and experimentation in your own time to explore these concepts further.

---

### Key Study Notes

- *Interfaces* - invented as a way of defining the things objects can do i.e. their jobs. Any class that implements an interface must implement all of the members defined in the interface.

- *Interfaces* - although JavScript doesn't have built in Interfaces just yet, developers have come up with a variety of different workarounds 