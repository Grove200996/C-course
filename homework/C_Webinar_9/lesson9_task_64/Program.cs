// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());


void NaturalNumbers(int n)
{
   
    if(n == 0) return ;
    Console.Write($"{n} ");
    NaturalNumbers(n-1);
    
}
NaturalNumbers(num);