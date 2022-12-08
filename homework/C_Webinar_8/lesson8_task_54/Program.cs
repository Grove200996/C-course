// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArray(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) System.Console.Write($"{array[i, j]}, ");
            else System.Console.Write($"{array[i, j]}");
        }
        System.Console.WriteLine("]");
    }
}


void SortInOrder(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int num = 0;
        while (num < matrix.GetLength(0))
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
            num++;
        }
    }
}

int[,] array2D = CreateArray(4, 4);
PrintMatrix(array2D);
System.Console.WriteLine();
SortInOrder(array2D);
PrintMatrix(array2D);