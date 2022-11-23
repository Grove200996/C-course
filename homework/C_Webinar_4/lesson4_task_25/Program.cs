// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

Console.Write("Enter A number: ");
int first = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Enter B number: ");
int second = Convert.ToInt32(Console.ReadLine());
int PowDigit(int a, int b)
{
    int summ = a * a;
    for (int i = 2; i < b; i++)
    {
        summ *= a;
    }
    return summ;
}
if (second < 0) System.Console.WriteLine("wrong data");
else Console.WriteLine(PowDigit(first, second));
