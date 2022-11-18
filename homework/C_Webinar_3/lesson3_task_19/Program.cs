// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


void IsPalindrome(int number)
{   number = Math.Abs(number);
    int fifthDig = number % 10;
    int fourthDig = (number / 10) % 10;
    int thirdDig = (number / 100) % 10;
    int secondDig = (number / 1000) % 10;
    int firstDig = number / 10000;
    if (fifthDig == firstDig && fourthDig == secondDig)
    {
        Console.WriteLine("Yes, it's palindrome");

    }
    else
    {
        Console.WriteLine("No,It's not");

    }
}
IsPalindrome(-23412);