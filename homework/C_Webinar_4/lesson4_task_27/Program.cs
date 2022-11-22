// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("Enter a number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));


int SummOfDigits(int num)
{   
    int summ = 0;
    while(num > 0)
    {
        summ += num % 10;
        num = num / 10;
        
    }
    return summ;
}   

Console.WriteLine(SummOfDigits(number));