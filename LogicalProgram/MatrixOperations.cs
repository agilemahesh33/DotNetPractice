using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class MatrixOperations
    {
        static void Main()
        {
            Console.WriteLine("Enter rows and columns for Matrix A:");
            int rowsA = int.Parse(Console.ReadLine());
            int colsA = int.Parse(Console.ReadLine());

            int[,] matrixA = ReadMatrix(rowsA, colsA, "A");

            Console.WriteLine("Enter rows and columns for Matrix B:");
            int rowsB = int.Parse(Console.ReadLine());
            int colsB = int.Parse(Console.ReadLine());

            int[,] matrixB = ReadMatrix(rowsB, colsB, "B");

            Console.WriteLine("\nMatrix A:");
            PrintMatrix(matrixA);
            Console.WriteLine("Matrix B:");
            PrintMatrix(matrixB);

            if (rowsA == rowsB && colsA == colsB)
            {
                Console.WriteLine("Addition (A + B):");
                PrintMatrix(Add(matrixA, matrixB));

                Console.WriteLine("Subtraction (A - B):");
                PrintMatrix(Subtract(matrixA, matrixB));

                Console.WriteLine("Element-wise Division (A / B):");
                PrintMatrix(Divide(matrixA, matrixB));

                Console.WriteLine("Are A and B equal? " + (AreEqual(matrixA, matrixB) ? "Yes" : "No"));
            }
            else
            {
                Console.WriteLine("Addition, Subtraction, Division, and Comparison not possible (size mismatch).");
            }

            if (colsA == rowsB)
            {
                Console.WriteLine("Multiplication (A * B):");
                PrintMatrix(Multiply(matrixA, matrixB));
            }
            else
            {
                Console.WriteLine("Multiplication not possible (A's columns ≠ B's rows).");
            }

            Console.WriteLine("Transpose of A:");
            PrintMatrix(Transpose(matrixA));

            Console.WriteLine("Transpose of B:");
            PrintMatrix(Transpose(matrixB));
        }

        static int[,] ReadMatrix(int rows, int cols, string name)
        {
            int[,] matrix = new int[rows, cols];
            Console.WriteLine($"Enter elements of Matrix {name}:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1} (space-separated):");
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = int.Parse(input[j]);
            }
            return matrix;
        }

        static int[,] Add(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }

        static int[,] Subtract(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = a[i, j] - b[i, j];
            return result;
        }

        static int[,] Multiply(int[,] a, int[,] b)
        {
            int rowsA = a.GetLength(0), colsA = a.GetLength(1);
            int colsB = b.GetLength(1);
            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsB; j++)
                    for (int k = 0; k < colsA; k++)
                        result[i, j] += a[i, k] * b[k, j];
            return result;
        }

        static int[,] Divide(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0), cols = a.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = b[i, j] != 0 ? a[i, j] / b[i, j] : 0;
            return result;
        }

        static bool AreEqual(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0), cols = a.GetLength(1);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (a[i, j] != b[i, j])
                        return false;
            return true;
        }

        static int[,] Transpose(int[,] matrix)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[j, i] = matrix[i, j];
            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
