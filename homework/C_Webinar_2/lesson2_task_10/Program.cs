// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на
//  выходе показывает вторую цифру этого числа. Выполнить с помощью 
//  числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{   
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}

bool isTrue = true;
while(isTrue){
    System.Console.Write("Enter a three digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    if(number < 1000 && number > 100){
        System.Console.WriteLine($"Second digit is {SecondDigit(number)}");
        isTrue = false;
    }
}
