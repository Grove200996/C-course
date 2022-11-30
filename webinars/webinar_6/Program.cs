// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)

// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
//         else System.Console.Write($"{array[i]}");
//     }
//     System.Console.WriteLine("]");

// }


// void ReverseArray (int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++) //2
//     {
//         int temp = array[i]; // 2
//         array[i] = array[array.Length - 1 - i]; // 1-5
//         array[array.Length - 1 - i] = temp;
//     }
// }

// int[] arr = CreateArrayRndInt(7, -23, 34);
// PrintArray(arr);
// ReverseArray(arr);
// PrintArray(arr);
// Array.Reverse(arr);
// PrintArray(arr);





// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// bool IsTriangle(int a, int b, int c)
// {
//     if (c < a + b && b < c + a && a < c + b)
//     {
//         return true;
//     }
//     return false;
// }

// System.Console.WriteLine(IsTriangle(4, 6, 3));




// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// string BinaryNum(int number)
// {
//     string res = "";
//     while (number > 0)
//     {
//         res = number % 2 + res;
//         number = number / 2;
//     }
//     return res;
// }

// string StringReverse(string str)
// {   
//     string output = "";
//     for (int i = str.Length - 1; i >= 0; i--)
//     {
//         output += str[i];
//     }
//     return output;
// }

// BinaryNum(46);
// // System.Console.WriteLine(StringReverse(res));
// System.Console.WriteLine(BinaryNum(46));

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8




// int[] Fibonachi(int num)
// {
    
//     int[] array = new int[num];
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }  

// void PrintArray(int[] array)

// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
//         else System.Console.Write($"{array[i]}");
//     }
//     System.Console.WriteLine("]");

// }

// int[] arr = Fibonachi(5);
// PrintArray(arr);


int[] CopyArray(int[] massive)
{
    int[] newArray = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        newArray[i] = massive[i];
    }
    return newArray;
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
int[] arr = { 5, 4, 6, 7 }; 
int[] newarr = CopyArray(arr);
PrintArray(newarr);
