// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает
//  что третьей цифры нет. Выполнить с помощью числовых операций 
//  (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int ThirdDigit(int number)
{
    while (number > 1000)
    {
        number /= 10;
    }
    return number % 10;
}

int third_digit = ThirdDigit(num);
if(num < 100){
    System.Console.WriteLine("There is no third digit!");
}
else {
    System.Console.WriteLine(third_digit);
}