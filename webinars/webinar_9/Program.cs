// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// System.Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// void NaturalNumber(int num)
// {
//     if (num == 0) return;
//     Console.Write($"{num} ");
//     NaturalNumber(num - 1);
// }


// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// System.Console.Write("Введите натуральное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите еще одно натуральное число: ");
// int m = Convert.ToInt32(Console.ReadLine());


// void NaturalNumber(int num1,int num2)
// {
//     if (num1 > num2)
//     {
//         Console.Write($"{num1} ");
//         NaturalNumber(num1 - 1, num2);
//     }
//     else if (num1 < num2 )
//     {   
//         Console.Write($"{num1} ");
//         NaturalNumber(num1 + 1,num2);
//     }
//     else Console.Write($"{num1} ");
// }

// NaturalNumber(n,m);



// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// System.Console.Write("Введите натуральное число: ");
// int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// int SumOfDigits(int num)
// {
//     if(num == 0) return 0;
//     return num % 10 + SumOfDigits(num / 10);
// }

// System.Console.WriteLine(SumOfDigits(n));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


System.Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите еще одно натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());


int Exponentiate(int num1, int num2)
{
    if(num2 == 1) return num1;
    return num1 * Exponentiate(num1,num2 - 1);
}
System.Console.WriteLine(Exponentiate(n,m));