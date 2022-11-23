// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



void FillArray(int[] arr, int a, int b)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }

}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");

    }
    Console.Write("]");
}


System.Console.Write("Enter a number of digits: ");
int amount = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[amount];

bool IsTrue = true;
while (IsTrue)
{   
    System.Console.Write("Range start: ");
    int start = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Range finish: ");
    int finish = Convert.ToInt32(Console.ReadLine());
    if (start < finish)
    {
        FillArray(array, start, finish);
        PrintArray(array);
        IsTrue = false;
    }
    else System.Console.WriteLine("wrong data");
}

