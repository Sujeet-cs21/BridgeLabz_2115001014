using System;

class MatrixToArray
{
    static void Main(string[] args)
    {
        //user input for the number of rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        // Create a 2D array with the given rows and columns
        int[,] matrix = new int[rows, columns];

        // Get the elements of the matrix from the user
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Enter element at position (" + (i + 1) + "," + (j + 1) + "): ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Create a 1D array with size equal to the total number of elements in the matrix
        int[] oneDArray = new int[rows * columns];

        // Copy the elements of the 2D array into the 1D array
        int index = 0; // Index for the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                oneDArray[index] = matrix[i, j];
                index++; // Increment index for the 1D array
            }
        }

        // Display the elements of the 1D array
        Console.Write("The elements in the 1D array are: ");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.Write(oneDArray[i] + " ");
        }
        Console.WriteLine();
    }
}
