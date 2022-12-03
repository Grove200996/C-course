// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// int[,] CreateMatrixRndInt(int row, int column, int min, int max)
// {
//     int[,] matrix = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}, ");
//             else Console.Write($"{matrix[i,j]}");
//         }

//         Console.WriteLine("]");
//     }
// }

// int[,] array2d = CreateMatrixRndInt(3,4,1,9);
// PrintArray(array2d);



// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixRndInt(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i,j]}");
        }

        Console.WriteLine("]");
    }
}




// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.



void FoundAndMulti(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
            matrix[i, j] *= matrix[i, j];
    }
}


// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
// PrintArray(array2D);
// Console.WriteLine(" ");
// FoundAndMulti(array2D);
// PrintArray(array2D);




// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


int SumIndex (int[,]matrix)
{
    int sum = 0;
   for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
   {
      sum += matrix[i, i];    
   }
   return sum;
}


int[,] array2 = CreateMatrixRndInt(3,4,1,9);
PrintArray(array2);
System.Console.WriteLine(SumIndex(array2));