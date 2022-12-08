// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка




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

int[] FindInnerSums(int[,] matrix)
{
    int[] sumsArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumsArray[i] = sum;
    }
    return sumsArray;
}

int FindLowestString(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = CreateArray(5,5);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = FindInnerSums(matrix);
int result = FindLowestString(array);

Console.WriteLine($"{result + 1} строка");
