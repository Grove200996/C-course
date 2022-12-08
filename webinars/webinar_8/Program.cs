// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// int[,] CreateMatrixRndInt(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = rnd.Next(1,10);
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


// void ValueSwap(int[,] matrix)
// {   
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
//         matrix[matrix.GetLength(0)-1,i] = temp;
// }
//     }



// int[,] matr = CreateMatrixRndInt(4,3,1,10);
// PrintArray(matr);
// ValueSwap(matr);
// System.Console.WriteLine();
// PrintArray(matr);













// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


// int[,] CreateMatrixRndInt(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 10);
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
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
//             else Console.Write($"{matrix[i, j]}");
//         }

//         Console.WriteLine("]");
//     }
// }


// int[,] ReplaceRwithC(int[,] matrix)
// {
//     int[,] rowsToColumns = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             rowsToColumns[i, j] = matrix[j, i];
//         }
//     }
//     return rowsToColumns;
// }


// int[,] matr = CreateMatrixRndInt(4, 4);
// PrintArray(matr);
// Console.WriteLine();
// if (matr.GetLength(0) == matr.GetLength(1))
// {
//     int[,] newMatr = ReplaceRwithC(matr);
//     PrintArray(newMatr);
// }
// else Console.WriteLine("Не квадрат.");



// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



// int[,] CreateMatrixRndInt(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return matrix;
// }


// void PrintArray2D(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
//             else Console.Write($"{matrix[i, j]}");
//         }

//         Console.WriteLine("]");
//     }
// }


// int[] ConvertToArray(int[,] matrix)
// {
//     int k = 0;
//     int[] arr = new int[matrix.Length];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arr[k] = matrix[i, j];
//             k++;
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] array)

// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
//         else System.Console.Write($"{array[i]}");
//     }
//     System.Console.WriteLine("]");

// }


// int[,] matrix = CreateMatrixRndInt(4, 3);
// PrintArray2D(matrix);
// int[] array = ConvertToArray(matrix);
// Array.Sort(array);
// PrintArray(array);


// void FindDuplicate(int[] array)
// {
//     int count = 1;
//     int number = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             count++;
//         }
//         else
//         {
//             System.Console.WriteLine($"Число {number} встречается {count} раз.");
//             count = 1;
//             number = array[i];
//         }
        
//     }
//     System.Console.WriteLine($"Число {number} встречается {count} раз.");
// }
// FindDuplicate(array);