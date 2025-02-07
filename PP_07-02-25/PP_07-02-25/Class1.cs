using System;

namespace PP_07_02_25
{
    // Superclass
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Subclass: Dog
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Subclass: Cat
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    // Subclass: Bird
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }

    class Class1
    {
        public static void Main1()
        {
            Animal myDog = new Dog("Tommy", 3);
            Animal myCat = new Cat("Tom", 2);
            Animal myBird = new Bird("Tweety", 1);

            myDog.MakeSound();
            myCat.MakeSound();
            myBird.MakeSound();
        }
    }

}
