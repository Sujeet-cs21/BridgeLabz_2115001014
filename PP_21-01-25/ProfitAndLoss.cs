using System;

class ProfitAndLoss
{
    static void Main(string [] args)
    {
        double costPrice = 129;
        double sellingPrice = 191;

        double profit = sellingPrice - costPrice;
        double profitPercentage = (profit / costPrice) * 100;

        Console.WriteLine("The Cost Price is INR {0} and Selling Price is INR {1}\nThe Profit is INR {2} and the Profit Percentage is {3:F2}%", 
                            costPrice, sellingPrice, profit, profitPercentage);
    }
}
