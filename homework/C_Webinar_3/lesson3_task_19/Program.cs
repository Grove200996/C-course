// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


string IsPalindrome(int number)
{
    number = Math.Abs(number);
    if (number > 100000 || number < -100000)
    {
        return "wrong data";
    }
    else
    {
        int fifthDig = number % 10;
        int fourthDig = (number / 10) % 10;
        int thirdDig = (number / 100) % 10;
        int secondDig = (number / 1000) % 10;
        int firstDig = number / 10000;
        if (fifthDig == firstDig && fourthDig == secondDig)
        {
            return "Yes, it's palindrome";

        }
        else
        {
            return "No,It's not";

        }
    }
}

System.Console.WriteLine(IsPalindrome(-23432));