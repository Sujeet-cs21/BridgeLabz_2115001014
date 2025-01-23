using System;

class Friends
{
    static void Main(string[] args)
    {
        // Taking input for the age and height of the three friends
        Console.Write("Enter the age of Amar: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Amar (cm): ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the age of Akbar: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Akbar (cm): ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the age of Anthony: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of Anthony (cm): ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        // Finding the youngest friend
        if (amarAge <= akbarAge && amarAge <= anthonyAge)
        {
            Console.WriteLine("The youngest friend is Amar with age " + amarAge);
        }
        else if (akbarAge <= amarAge && akbarAge <= anthonyAge)
        {
            Console.WriteLine("The youngest friend is Akbar with age " + akbarAge);
        }
        else
        {
            Console.WriteLine("The youngest friend is Anthony with age " + anthonyAge);
        }

        // Finding the tallest friend
        if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
        {
            Console.WriteLine("The tallest friend is Amar with height " + amarHeight + " cm");
        }
        else if (akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
        {
            Console.WriteLine("The tallest friend is Akbar with height " + akbarHeight + " cm");
        }
        else
        {
            Console.WriteLine("The tallest friend is Anthony with height " + anthonyHeight + " cm");
        }
    }
}
