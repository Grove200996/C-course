// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ----------------------Методы------------------
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-10, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else System.Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

double[] SumOfNumbersInside(int[,] matrix)
{
    double[] summ = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {

            sum += matrix[j, i];

        }
        summ[i] += sum / matrix.GetLength(0);
    }
    return summ;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 2)}; ");
        else Console.Write($"{Math.Round(array[i], 2)}.");
    }
}



// ---------------------Переменные и проверка---------------
Console.Write("Введите количетво строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетво столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0) Console.WriteLine("Некорректные данные.");
else if(m == 0 || n == 0) Console.WriteLine("Количество строк или столбцов не может быть 0.");
else
{
    int[,] array = CreateMatrix(m, n);
    PrintMatrix(array);

    double[] matrix = SumOfNumbersInside(array);
    Console.WriteLine();
    Console.Write($"Среднее арифметическое каждого столбца: ");
    PrintArray(matrix);
}
