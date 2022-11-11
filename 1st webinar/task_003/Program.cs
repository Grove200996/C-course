// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
String first = "Понедельник";
String second = "Вторник";
String third = "Среда";
String fourth = "Четверг";
String fifth = "Пятница";
String sixth = "Суббота";
String seventh = "Воскресенье";

if (num == 1)
{
    Console.WriteLine(first);
}
else if (num == 2)
{
    Console.WriteLine(second);
}
else if (num == 3)
{
    Console.WriteLine(third);
}
else if (num == 4)
{
    Console.WriteLine(fourth);
}
else if (num == 5)
{
    Console.WriteLine(fifth);
}
else if (num == 6)
{
    Console.WriteLine(sixth);
}
else if (num == 7)
{
    Console.WriteLine(seventh);
}
else
{
    Console.WriteLine("Wrong data");
}