// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");

}


int SummOfOddPos(int[] array)
{
    int summ = 0;
    int i = 1;
    while (i < array.Length)
    {
        summ += array[i];
        i+=2;
    }
    return summ;
}
int[] array = CreateArray(6);
PrintArray(array);
System.Console.WriteLine($"Сумма чисел на нечетных позициях равна --> {SummOfOddPos(array)}");
