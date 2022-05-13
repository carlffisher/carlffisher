# Activity 4
## Introduction to Polymorphism

## Exercise 4.1 - Introductory Reading - Polymorphism & Abstract Classes

### Pillar 4 - What is 'Polymorphism'?

Polymorphism means many shapes or forms. Building on top of what we know about classes, abstraction, encapsulation and inheritance so far, we can now apply Polymorphism to provide flexibility for subclasses to implement something in many different forms. 

If we use animals as an example, all animals might speak and therefore our animal classes might have a `speak()` method inherited from their `Animal` class parent. But the way that each `Animal` speaks might be different. A `Dog` barks, a `Bird` sings etc. 

To use Polymorphism in JavaScript we override the methods we want to change. Overriding methods in JavaScript is simple - we just redefine them.

---

## Exercise 4.1 - Edit the `Pigeon` class to override methods defined by the `Bird` class

- In your existing `Pigeon` class, add the following implementation for the `speak()` method by overriding the Bird class' `speak()` method. This will allow the `Pigeon` to be able to `speak()`, as it's related to the `Bird`, but now it has a different form i.e. it can speak in a different way.

- Notice that for the `Pigeon` class, we'd like to use the default implementation for `fly()` which is defined in the parent class.


```JavaScript

class Pigeon extends Bird {
    constructor(name, color) {
        super(name, color);
    }

    // Here we are overriding the speak() method
    speak() {
        // and adding a different console.log() message
        console.log(`Yo! I'm ${this.name} and I'm a ${this.color} pigeon.`);
    };

    eatPizza() {
        console.log("Delicious pizza!");
    }
}

```

---
## Exercise 4.2 - Run your console application

- Run your console application. You should see the following output to your console.

```
My name is Tweety and I am a Yellow bird.
I'm Tweety and I can fly high in the blue sky!
Yo! I'm Pippa and I'm a Grey pigeon.
I'm Pippa and I can fly high in the blue sky!
Delicious pizza!

```

---

## Exercise 4.3 - Add the `Penguin` class to your UML diagram

- Update and add a `Penguin` subclass to your diagram. The `Penguin` extends the base class `Bird` and it will override the methods `speak()` and `fly()`.

An example solution to the diagram is available [here](../solutions/activity_4_exercise_4.6.png).

---

## Exercise 4.4 - Create the additional subclass `Penguin` to extend the base class `Bird`

- Add an empty class called `Penguin`
- Add the following code to make the `Penguin` class extend base class `Bird`

```JavaScript

class Penguin extends Bird {
    constructor(name, color) {
        super(name, color); 
    }
    // We override Birds speak() method
    speak() {
        console.log(`Hi! I'm ${this.name} and I'm a ${this.color} penguin.`);
    };
    // We override Birds fly() method too
    fly() {
        console.log(`Whoops, I can't fly. Waddle waddle.`);
    }
}

```

---

## Exercise 4.5 - Run your console application

- Add the following code beneath your existing code

```JavaScript

const pingu = new Penguin("Pingu", "Black & White");
pingu.speak();
pingu.fly();

```

- Run your console application. You should see the following output to your console.

```

My name is Tweety and I am a Yellow bird.
I'm Tweety and I can fly high in the blue sky!
Yo! I'm Pippa and I'm a Grey pigeon.
I'm Pippa and I can fly high in the blue sky!
Delicious pizza!
Hi! I'm Pingu and I'm a Black & White penguin.
Whoops, I can't fly. Waddle waddle.


```
---

## Exercise 4.9 - Create a Parrot

In this exercise, create your very own `Parrot` class that extends the base class `Bird`. Have it `speak()` a funny message!

---

### What's next?

Head over to [Introduction to Interfaces in Activity 5](./activity_5.md) to learn more.

---

### Key Study Notes

- *Polymorphism* - means many shapes or forms.