// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.

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

int[,] MatrixMul(int[,] mtrx1, int[,] mtrx2)
{
    int[,] matrix = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    for (int i = 0; i < mtrx1.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < mtrx2.GetLength(0); k++)
            {
                matrix[i, j] += mtrx1[i, k] * mtrx2[k, j];
            }
        }
    }
    return matrix;
}



Console.Write("Число строк в первой матрице: ");
int rowF = Convert.ToInt32(Console.ReadLine());
Console.Write("Число строк во второй матрице: ");
int rowS = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов в первой матрице: ");
int columnsF = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов во второй матрице: ");
int columnsS = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateArray(rowF, columnsF);
int[,] matrix2 = CreateArray(rowS, columnsS);
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] result = MatrixMul(matrix1, matrix2);
    PrintMatrix(matrix1);
    System.Console.WriteLine();
    PrintMatrix(matrix2);
    System.Console.WriteLine();
    PrintMatrix(result);
}
else Console.WriteLine("Такую матрицу не умножить.");

