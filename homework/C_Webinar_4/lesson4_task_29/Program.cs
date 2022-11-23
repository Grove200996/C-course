// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];
void FillArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-20, 20);
    }

}
void PrintArray(int[] arr)
{
    Console.Write("[");
    string res = string.Join(", ", array);
    Console.Write($"{res}]");
}
FillArray(array);
PrintArray(array);