// See https://aka.ms/new-console-template for more information

// Bird myBird = new Bird("Tweety", "Yellow");
// myBird.Speak();
// myBird.Fly();

// Penguin pippa = new Penguin("Pippa", "White");
Pigeon pippa = new Pigeon("Pippa", "Grey");
pippa.Speak();
pippa.Fly();
pippa.EatPizza();
pippa.Spin();
pippa.DoTheCaterpillar();
pippa.Jump();

Penguin pingu = new Penguin("Pingu", "Black & White");
pingu.Speak();
pingu.Fly();
pingu.Spin();
pingu.DoTheCaterpillar();
pingu.Jump();

// Parrot eric = new Parrot("Eric the parrot", "Green");
// eric.Speak();

/*
public class Bird
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"My name is {Name} and I am a {Color} bird.");
    }

    public virtual void Fly()
    {
        //Default implementation
        Console.WriteLine("Hi there! I can fly.");
    }
    
    //public void Fly()
    //{
    //     Console.WriteLine($"I'm {Name} and I can fly high in the blue sky!");
    //}
}
*/

public abstract class Bird : IDance
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public abstract void Speak();

    public virtual void Fly()
    {
        Console.WriteLine("Hi there! I can fly.");
    }

    public void Spin()
    {
        Console.WriteLine($"{Name} spin!");
    }

    public void DoTheCaterpillar()
    {
        Console.WriteLine($"{Name} do the wriggly woo!");
    }

    public void Jump()
    {
        Console.WriteLine($"{Name} jump in the air!");
    }
}

public interface IDance
{
    void Spin();
    void DoTheCaterpillar();
    void Jump();
}

public class Parrot : Bird
{
    public Parrot(string name, string colour) : base(name, colour) { }

    public override void Speak()
    {
        Console.WriteLine($"I'm {Name} the parrot. B*ll***s. Another cup of tea Vicar?");
    }
}

public class Pigeon : Bird
{
    public Pigeon(string name, string colour) : base(name, colour){}

    public override void Speak()
    {
        Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
    }

    public void EatPizza()
    {
        Console.WriteLine("Delicious pizza!");
    }

    public void Sleep()
    {
        Console.WriteLine("I'm a sleeping pigeon");
    }
}

public class Penguin : Bird
{
    public Penguin(string name, string color) : base(name, color)
    {
    }

    public override void Speak()
    {
        Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} penguin.");
    }

    public override void Fly()
    {
        Console.WriteLine($"Whoops, I can't fly. Waddle waddle.");
    }
}

/*
public class Penguin : Bird
{
    public Penguin(string name, string colour) : base(name, colour) { }

    public override void Speak()
    {
        Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} penguin.");
    }

    public override void Fly()
    {
        //Default implementation
        Console.WriteLine("Yo there! I can fly.");
    }

    public void EatPizza()
    {
        Console.WriteLine("Delicious pizza!");
    }

    public void Sleep()
    {
        Console.WriteLine("I'm a sleeping penguin");
    }
}
*/


