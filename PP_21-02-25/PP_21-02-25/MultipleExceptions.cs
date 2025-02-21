using System;

namespace PP_21_02_25
{
    class MultipleExceptions
    {
        public static void Main4()
        {
            int[] numbers = null;

            try
            {
                Console.Write("Enter the size of the array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + i + ": ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter an index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Value at index " + index + ": " + numbers[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
