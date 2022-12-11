// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumOfNaturalNumbers(int num1, int num2)
{

    if (num1 >= num2) return num1 + SumOfNaturalNumbers(num1 - 1, num2);
    else return 0;
}
int SumOfNaturalNumbers1(int num1, int num2)
{

    if (num1 <= num2) return num1 + SumOfNaturalNumbers1(num1 + 1, num2);
    else return 0;
}



System.Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m > n)
{
    int result = SumOfNaturalNumbers(m, n);
    System.Console.WriteLine(result);
}
else {
    int result1 = SumOfNaturalNumbers1(m, n);
    System.Console.WriteLine(result1);
}