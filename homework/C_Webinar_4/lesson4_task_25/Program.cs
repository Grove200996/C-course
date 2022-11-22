// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16
Console.Write("Enter A number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B number: ");
int second = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int PowDigit(int a, int b)
{
    int summ = a * a;
    for (int i = 2; i < b; i++)
    {
        summ *= a;
    }
    return summ;
}
Console.WriteLine(PowDigit(first, second));
