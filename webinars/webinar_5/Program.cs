// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20


// int[] CreateArrayRndInt (int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }


// int GetSumPositiveElem(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] > 0) sum += array[i]; // sum = sum + array[i];
//     return sum;
// }

// int GetSumNegativeElem(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] < 0) sum += array[i]; // sum = sum + array[i];
//     return sum;
// }

// int[] arr = CreateArrayRndInt(12, -9, 9);
// PrintArray(arr);
// int sumPositive = GetSumPositiveElem(arr);
// int sumNegative = GetSumNegativeElem(arr);
// Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");



// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// void ArrayInv(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i > 0)
//         {
//             array[i] *= (-1);
//         }
//         else
//         {
//             array[i] *= 1;
//         }
//     }

// }

// int[] arr = CreateArray(8, -9, 9);

// PrintArray(arr);
// ArrayInv(arr);
// PrintArray(arr);


// string NumIsHere(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (array[i] == num)
//         {
//             return $"Число {array[i]} присутствует в списке.";
//         }
//     }
//     return $"Число отсутствует в списке.";
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(NumIsHere(arr, number));







int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)

{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");

}



// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int AmountOfDig(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 10 && array[i] < 99) count++;
//     }
//     return count;
// }



// int[] array = CreateArray(123,1,200);
// PrintArray(array);
// System.Console.WriteLine(AmountOfDig(array));



int AmountOfDigigts(int[] array)
{
    int amount = 0;
    if (array.Length % 2 == 0) amount = array.Length / 2;
    else amount = (array.Length / 2) + 1;
    return amount;
}
int[] Calculation(int[] array, int amount)
{   
    int[] emptyMassive = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        emptyMassive[i] += array[i] * array[array.Length-1 - i]; 
    }
    return emptyMassive;
}


int[] massive = (CreateArray(5,1,11));
PrintArray(massive);
PrintArray(Calculation(massive,AmountOfDigigts(massive)));