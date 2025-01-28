using System;

public class Matrix
{
    // Method to create a random matrix of given rows and columns
    public static int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10); // Random value between 1 and 9
            }
        }
        return matrix;
    }

    // Method to add two matrices
    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Method to subtract two matrices
    public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    // Method to multiply two matrices
    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);


        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    // Method to find the transpose of a matrix
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }

    // Method to find the determinant of a 2x2 matrix
    public static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Method to find the inverse of a 2x2 matrix
    public static double[,] Inverse2x2(int[,] matrix)
    {
        int determinant = Determinant2x2(matrix);
        if (determinant == 0)
        {
            Console.WriteLine("Determinant is zero, inverse does not exist.");
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / (double)determinant;
        inverse[0, 1] = -matrix[0, 1] / (double)determinant;
        inverse[1, 0] = -matrix[1, 0] / (double)determinant;
        inverse[1, 1] = matrix[0, 0] / (double)determinant;

        return inverse;
    }

    // Method to find the determinant of a 3x3 matrix
    public static int Determinant3x3(int[,] matrix)
    {
        int a = matrix[0, 0];
        int b = matrix[0, 1];
        int c = matrix[0, 2];
        int d = matrix[1, 0];
        int e = matrix[1, 1];
        int f = matrix[1, 2];
        int g = matrix[2, 0];
        int h = matrix[2, 1];
        int i = matrix[2, 2];

        return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
    }

    // Method to find the inverse of a 3x3 matrix
    public static double[,] Inverse3x3(int[,] matrix)
    {
        int determinant = Determinant3x3(matrix);
        if (determinant == 0)
        {
            Console.WriteLine("Determinant is zero, inverse does not exist.");
        }

        double[,] inverse = new double[3, 3];
        int a = matrix[0, 0];
        int b = matrix[0, 1];
        int c = matrix[0, 2];
        int d = matrix[1, 0];
        int e = matrix[1, 1];
        int f = matrix[1, 2];
        int g = matrix[2, 0];
        int h = matrix[2, 1];
        int i = matrix[2, 2];

        inverse[0, 0] = (e * i - f * h) / (double)determinant;
        inverse[0, 1] = (c * h - b * i) / (double)determinant;
        inverse[0, 2] = (b * f - c * e) / (double)determinant;
        inverse[1, 0] = (f * g - d * i) / (double)determinant;
        inverse[1, 1] = (a * i - c * g) / (double)determinant;
        inverse[1, 2] = (c * d - a * f) / (double)determinant;
        inverse[2, 0] = (d * h - e * g) / (double)determinant;
        inverse[2, 1] = (b * g - a * h) / (double)determinant;
        inverse[2, 2] = (a * e - b * d) / (double)determinant;

        return inverse;
    }

    // Method to print a matrix
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Main method
    public static void Main(string[] args)
    {
        // Input matrix size
        Console.Write("Enter the number of rows for the matrices: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns for the matrices: ");
        int cols = int.Parse(Console.ReadLine());

        // Create two random matrices
        Console.WriteLine("Matrix A:");
        int[,] matrixA = CreateRandomMatrix(rows, cols);
        PrintMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        int[,] matrixB = CreateRandomMatrix(rows, cols);
        PrintMatrix(matrixB);

        // Matrix Addition
        int[,] resultAdd = AddMatrices(matrixA, matrixB);
        Console.WriteLine("Matrix A + Matrix B:");
        PrintMatrix(resultAdd);

        // Matrix Subtraction
        int[,] resultSub = SubtractMatrices(matrixA, matrixB);
        Console.WriteLine("Matrix A - Matrix B:");
        PrintMatrix(resultSub);

        // Matrix Multiplication (only works if colsA == rowsB)
        if (matrixA.GetLength(1) == matrixB.GetLength(0))
        {
            int[,] resultMul = MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("Matrix A * Matrix B:");
            PrintMatrix(resultMul);
        }
        else
        {
            Console.WriteLine("Matrix A and Matrix B cannot be multiplied.");
        }

        // Matrix Transpose
        int[,] resultTranspose = TransposeMatrix(matrixA);
        Console.WriteLine("Transpose of Matrix A:");
        PrintMatrix(resultTranspose);

        // Determinant and Inverse (only for 2x2 matrices)
        if (rows == 2 && cols == 2)
        {
            Console.WriteLine("Determinant of Matrix A: " + Determinant2x2(matrixA));
            double[,] inverse = Inverse2x2(matrixA);
            Console.WriteLine("Inverse of Matrix A:");
        }
        else
        {
            Console.WriteLine("Matrix A is not 2x2.");
        }

        // Determinant and Inverse (only for 3x3 matrices)
        if (rows == 3 && cols == 3)
        {
            Console.WriteLine("Determinant of Matrix A: " + Determinant3x3(matrixA));
            double[,] inverse = Inverse3x3(matrixA);
            Console.WriteLine("Inverse of Matrix A:");
        }
        else
        {
            Console.WriteLine("Matrix A is not 3x3.");
        }
    }
}