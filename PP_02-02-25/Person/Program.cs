using System;

class Person
{
    public string name;
    public int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person copyPerson)
    {
        this.name = copyPerson.name;
        this.age = copyPerson.age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Person1", 30); // Original person
        Person person2 = new Person(person1); // Copy constructor

        person1.DisplayInfo();
        Console.WriteLine("-----------------");
        person2.DisplayInfo();
    }
}
