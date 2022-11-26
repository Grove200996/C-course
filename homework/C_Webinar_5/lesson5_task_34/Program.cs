// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int amount)
{
    int[] array = new int[amount];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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
int AmountOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}


System.Console.Write("Amount of digits in array: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) System.Console.WriteLine("Wrong data.");
else
{
    int[] array = CreateArray(number);
    PrintArray(array);
    System.Console.WriteLine($"Amount of even numbers equals --> {AmountOfEven(array)}");
}