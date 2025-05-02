using System;

namespace InheritancePolymorphism
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some Generic animal sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Back");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meaw");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
