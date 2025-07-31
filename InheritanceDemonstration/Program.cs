namespace InheritanceDemo
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class - Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class - Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Main entry point
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound(); // Should print "Some generic sound"
            dog.MakeSound();           // Should print "Bark"
            cat.MakeSound();           // Should print "Meow"
        }
    }
}
