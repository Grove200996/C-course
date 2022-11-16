// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


// int num = new Random().Next(10,99);
// int a = num % 10;
// int b = num / 10;
// System.Console.WriteLine(num);
// // System.Console.WriteLine(Math.Max(a,b));
// if(a > b) System.Console.WriteLine(a);
// else System.Console.WriteLine(b);


// int MaxNum(int num) {
//     int a = num % 10;
//     int b = num / 10;
//     if(a > b) return a;
//     return b;
// }
// int max_digit = MaxNum(num);
// System.Console.WriteLine(max_digit);


// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



// int Number(int num)
// {

//     int a = num / 100;
//     int b = num % 10;
//     int result = a * 10 + b;
//     return result;

// }

// int number = new Random().Next(100, 1000);
// System.Console.WriteLine(number);
// int mn = Number(number);
// System.Console.WriteLine(mn);



// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.WriteLine("Введите 2 числа: ");
// int a = Convert.ToInt32(System.Console.ReadLine());
// int b = Convert.ToInt32(System.Console.ReadLine());

// int isMultiple(int num1, int num2)
// {
//     return num1 % num2;

// }

// int result = isMultiple(a, b);
// if (result == 0) System.Console.WriteLine("Кратное");

// else System.Console.WriteLine($"Не кратное, остаток {result}");




// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// System.Console.WriteLine("Enter a number:  ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool isMultiple(int num)
// {
//     return num % 7 == 0 && num % 23 == 0;
// }

// bool result = isMultiple(number);
// string resultStr = result ? "Да" : "Нет";
// System.Console.WriteLine($"{number} --> {resultStr}");



// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// System.Console.WriteLine("Enter two numbers: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// bool isSquare(int num, int num1) { 
//     return num * num == num1 || num1 * num1 == num;
// }

// bool result = isSquare(a,b);
// string resultStr = result ? "Да" : "Нет";
// System.Console.WriteLine($"{a}, {b} --> {resultStr}");





// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей
//  цифры нет. Выполнить с помощью числовых операций 
//  (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

