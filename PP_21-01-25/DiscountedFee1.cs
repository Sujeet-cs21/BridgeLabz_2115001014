using System;

class DiscountedFee1
{
    static void Main(string[] args)
    {
        Console.Write("Enter the course fee : ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = (fee * discountPercent) / 100;

        double discountedFee = fee - discount;

        Console.WriteLine("The discount amount is INR " + discount.ToString("F2") + 
                  " and final discounted fee is INR " + discountedFee.ToString("F2"));
    }
}
