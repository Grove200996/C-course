// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 100), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");

}

string MinNMax(double[] array)
{
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] < min) min = array[i];
    }
    return $"Разница между максимальным и минимальными числами равна -> {max-min}";
}

double[] array = CreateArray(6);
PrintArray(array);

System.Console.WriteLine(MinNMax(array));