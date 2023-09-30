/*Encapsulation.-  Encapsulation is a mechanism for bringing together data and methods within a structure by hiding the implementation of the object, that is, preventing access to the data by any means other than the proposed services.
•	Highlight a benefit of Encapsulation.- Encapsulation provides two advantages: User actions can be controlled internally. The second advantage is being able to make changes/improvements without affecting the way users interact with the application.
/
/*En este código específico, la encapsulación se usa para proteger el texto de la escritura y una lista de palabras. Estos datos se pueden acceder solo a través de los métodos públicos GetText() y GetWords().
using System;*/

namespace Encapsulation
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is {0}.", name);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Create a new person
            Person person = new Person("John Doe");

            // Set the person's name
            person.Name = "Jane Doe";

            // Say hello
            person.SayHello();
        }
    }
}
