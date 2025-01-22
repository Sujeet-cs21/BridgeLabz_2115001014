using System;

class HeightConversion
{
    static void Main(string[] args)
    {
      
        Console.Write("Enter height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double cmToInches = 2.54;
        double inchesInFoot = 12;

        double heightInches = heightCm / cmToInches;

        int feet = (int)(heightInches / inchesInFoot);
        int inches = (int)(heightInches % inchesInFoot);

        Console.WriteLine("Your Height in cm is " + heightCm +" while in feet is " + feet +" and inches is " + inches);
    }
}
