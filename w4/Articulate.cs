/*Inheritance is a concept in object-oriented programming that allows you to create new classes from existing classes. The new classes are called derived classes, and the existing class is called the base class.
Benefits of inheritance

Inheritance has several benefits, including:
Code reuse: Inheritance allows you to reuse the code from the base class in derived classes. This reduces the amount of code that needs to be written, making your code more efficient and easier to maintain.
Functional extension: Inheritance allows you to extend the functionality of the base class in derived classes. This allows you to create classes that are more specific to a particular task.
Code organization: Inheritance allows you to organize your code into classes that are related to each other. This makes your code easier to understand and maintain
 example:
 */
 // Base class Animal
public class Animal
{
    public string Name { get; set; }

    public void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Derived class Dog
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Dog object
        Dog dog = new Dog();

        // Assign values to the Dog object's properties
        dog.Name = "Fido";

        // Call the Speak() method on the Dog object
        dog.Speak();

        // Call the Bark() method on the Dog object
        dog.Bark();
    }
}
