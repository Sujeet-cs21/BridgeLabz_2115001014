using System;

class OTP
{
    //Method to generate OTP
    public static int GenerateOTP()
    {
        Random random = new Random();
        int otp = random.Next(100000, 1000000);
        return otp;
    }

    //Method to store OTP in an array
    public static int[] GetOTPArray(int count)
    {
        int[] otps = new int[count];
        for (int i = 0; i < count; i++)
        {
            otps[i] = GenerateOTP();
        }
        return otps;
    }

    //Method to check if each OTP is unique
    public static bool IsUniqueOTP(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
    
    //main method
    public static void Main(string[] args)
    {
        int count = 10;

        //Generate OTPs
        int[] otps = GetOTPArray(count);
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        //Check if each OTP is unique
        bool isUnique = IsUniqueOTP(otps);
        Console.WriteLine("Are all OTPs unique? " + isUnique);
    }
}