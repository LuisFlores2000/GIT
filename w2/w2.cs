/* Name :Luis Gerardo Flores Condori
•	Explain the meaning of Abstraction
Abstraction is a pillar or characteristic of object-oriented programming that will allow objects to interact without needing to know the details of their operation. In this way, the focus is on relevant aspects of the entities.
•	Highlight a benefit of Abstraction
It serves to understand the interrelation that may exist between various ideas or elements, and allows you to imagine and develop new ideas, as well as learn from past experiences and take advantage of all that knowledge to reflect on the future.
•	Provide an application of Abstraction
Abstraction is a powerful tool that can help simplify and modularize complex systems. This can improve the clarity, ease of use, and maintainability of the system.
*/

class Animal:
    def __init__(self, name):
        self.name = name

    def make_sound(self):
        raise NotImplementedError("The make_sound method must be implemented by subclasses")


class Dog(Animal):
    def make_sound(self):
        print("Woof!")


class Cat(Animal):
    def make_sound(self):
        print("Meow!")


# Create a dog
dog = Dog("Peter")

# Make the dog make a sound
dog.make_sound()

# Create a cat
cat = Cat("Tom")

# Make the cat make a sound
cat.make_sound()

/*We are using abstraction to hide the implementation details of the specific animals. We just need to know that animals can make sounds. We don't need to know how a specific animal makes a sound.*/
