// string[,] table = new string[2,5];
// table[1,2] = "dicks";

// for (int row = 0; row < 2; row++)
// {
//     for (int column = 0; column < 5; column++)
//     {
//         Console.Write($"-{table[row, column]}-");
//     }
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }


// void FillMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,10);
//         }
//     }
// }


// int[,] matrix = new int[3, 4];
// PrintMatrix(matrix);
// FillMatrix(matrix);
// System.Console.WriteLine();
// PrintMatrix(matrix);



// int Factorial(int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// System.Console.WriteLine(Factorial(3));


// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine(Fibonacci(i));
// }