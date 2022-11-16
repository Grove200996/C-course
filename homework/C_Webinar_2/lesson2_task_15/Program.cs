// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("Enter a number: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num == 6 || num == 7)
{
    System.Console.WriteLine($"{num} -> да");
}
else if (num < 1 || num > 7)
{
    System.Console.WriteLine("Wrong data");

}
else
{
    System.Console.WriteLine($"{num} -> нет");
}

