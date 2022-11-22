// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// System.Console.Write("Enter a number: ");
// int NumSum(int num)
// {
//     int summ = 0;
//     for (int i = 1; i <= num; i++) summ += i;
//     return summ;
// }
// if (a > 0) System.Console.WriteLine(NumSum(a));
// else System.Console.WriteLine("WRONG DATA");


// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



// void DigAmount(string num)
// {   int length = num.Length;
//     System.Console.WriteLine(length);
// }
// DigAmount(a);


// System.Console.Write("Enter a number: ");
// int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int DigAmount(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count == 0 ? 1 : count;
// }
// Console.WriteLine(DigAmount(a));


// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// System.Console.Write("Enter a number: ");
// int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// int MulNum(int num)
// {
//     if (n == 0) return 0;
//     else
//     {
//         int summ = 1;
//         for (int i = 1; i <= num; i++)
//         {
//             summ *= i;
//         }
//         return summ;
//     }
// }

// Console.WriteLine(MulNum(n));


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}
FillArray(array);
PrintArray(array);

