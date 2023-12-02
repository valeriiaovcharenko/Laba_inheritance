using System;

// Завдання 1: Фігура
public class Figure
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0;
    }
}

public class Circle : Figure
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

// Завдання 2: Фрукт
public class Fruit
{
    public string Name { get; set; }
}

public class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

public class Pear : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

// Завдання 3: Тварини
public abstract class Animal
{
    public float Weight { get; set; }
    public string Color { get; set; }

    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    public abstract string MakeSound();
}

public abstract class AnimalWithTail : Animal
{
    public float TailLength { get; set; }

    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    private string Purr()
    {
        return "purrrrrrrr";
    }

    private string Meow()
    {
        return "Meow";
    }

    public override string MakeSound()
    {
        return Purr() + Meow();
    }

    public override string ToString()
    {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

public class Dog : AnimalWithTail
{
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    public override string MakeSound()
    {
        return "Woof";
    }

    public override string ToString()
    {
        return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

class Program
{
    static void Main()
    {
        // Завдання 1: Фігура
        Circle circle = new Circle { Radius = 5 };
        Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };

        Console.WriteLine($"Circle Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");

        // Завдання 2: Фрукт
        Apple apple = new Apple { Name = "Apple", Variety = "Red Delicious", Color = "Red" };
        Pear pear = new Pear { Name = "Pear", Variety = "Bartlett", Color = "Yellow" };

        Console.WriteLine($"Apple: {apple.Name}, Variety: {apple.Variety}, Color: {apple.Color}");
        Console.WriteLine($"Pear: {pear.Name}, Variety: {pear.Variety}, Color: {pear.Color}");

        // Завдання 3: Тварини
        Cat cat = new Cat("Gray", 7.5f, 12.3f);
        Dog dog = new Dog("Brown", 15.2f, 20.1f);

        Console.WriteLine(cat.ToString());
        Console.WriteLine($"Cat says: {cat.MakeSound()}");

        Console.WriteLine(dog.ToString());
        Console.WriteLine($"Dog says: {dog.MakeSound()}");
    }
}