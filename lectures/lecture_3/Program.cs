// Методы: продолжение.

// -------Первый вид

void Method1()
{
    Console.WriteLine("Первый метод");

}

// Method1();


// -------Второй вид


void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

// Method2("Текст");



//--------Третий вид

int Method3()
{
    return DateTime.Today.Year;
}

// System.Console.WriteLine(Method3());

//--------Четвертый вид

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result += text;
//         i++;
//     }
//     return result;
// }
// Console.WriteLine(Method4(4,"z"));




// string Method4(int count, string text)
// {

//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result += text;

//     }
//     return result;
// }

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }


string text = "Ска́зка — один из жанров фольклора, либо литературы."
            + "Эпическое, преимущественно прозаическое произведение с волшебным,"
            + "героическим или бытовым сюжетом. Сказку характеризует отсутствие"
            + "претензий на историчность повествования, нескрываемая вымышленность сюжета";


// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == OldValue) result += NewValue;
//         else result += text[i];
//     }
//     return result;
// }
// System.Console.WriteLine(Replace(text, ' ', '-'));
// System.Console.WriteLine(Replace(text, 'к', 'К'));
// System.Console.WriteLine(Replace(text, 'С', 'с'));


// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void ArrayPrint(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// void Sorting(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minNum = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minNum]) minNum = j;
//         }
//         int temp = array[i];
//         array[i] = array[minNum];
//         array[minNum] = temp;
//     }
// }
// ArrayPrint(arr);
// Sorting(arr);
// ArrayPrint(arr);




