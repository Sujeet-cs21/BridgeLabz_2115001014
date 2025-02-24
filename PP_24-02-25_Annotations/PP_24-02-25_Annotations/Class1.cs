using System;

namespace PP_24_02_25_Annotations
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Aniaml makes sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Class1
    {
        public static void Main1()
        {
            Animal dog = new Dog();
            dog.MakeSound();
        }
    }
}
