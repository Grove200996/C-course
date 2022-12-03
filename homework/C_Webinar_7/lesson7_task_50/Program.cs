// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет


//  -----------------Методы----------------
int[,] CreateAMatrix(int columns, int rows)
{
    int[,] matrix = new int[columns, rows];
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

void PrintAMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

int FindNumber(int[,] array, int row, int column)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        number = array[row, column];
    }
    return number;
}

// -----------------Переменные-------------

bool isTrue = true;
while (isTrue)
{
    System.Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || m == 0 || n < 0 || n == 0)
    {
        Console.WriteLine("Неверный диапазон.");
    }
    else isTrue = false;
    Console.Write("Введите два индекса числа через запятую: ");
    string values = Console.ReadLine();
    string[] val = values.Split(',');
    int row = Convert.ToInt32(val[0]);
    int column = Convert.ToInt32(val[1]);


// ------------------Создание массива и вывод числа--------
    int[,] matrix = CreateAMatrix(m, n);
    PrintAMatrix(matrix);
    System.Console.WriteLine();
    if (row < 0 || column < 0) Console.WriteLine("Неверный диапазон.");
    else
    {
        int dig = FindNumber(matrix, row, column);
        Console.WriteLine($"{row},{column} -> {dig}");
    }
}




