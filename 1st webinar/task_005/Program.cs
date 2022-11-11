// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1000 && num > 99)
{
    num = num % 10;
    Console.WriteLine($"Third digit is {num}");
}
else
{
    Console.WriteLine($"Wrong data");
}
