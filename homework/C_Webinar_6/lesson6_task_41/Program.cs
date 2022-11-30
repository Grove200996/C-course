// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3




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

int LargerThanZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] CreateAnArray(int amount)
{
    int[] array = new int[amount];
    int i = 0;
    while (amount > 0)
    {
        System.Console.WriteLine("Enter a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        amount--;
        i++;
    }
    return array;
}


Console.Write("Enter an amount of numbers: ");
int amount = Convert.ToInt32(Console.ReadLine());


int[] array = CreateAnArray(amount);
PrintArray(array);
System.Console.WriteLine(LargerThanZero(array));
