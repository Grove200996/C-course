// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int Quarter(int xc, int yc)
// {
//     if(xc > 0 && yc > 0) return 1;
//     if(xc < 0 && yc > 0) return 2;
//     if(xc < 0 && yc < 0) return 3;
//     if(xc > 0 && yc < 0) return 4;
//     return 0;
// }

// int quarter = Quarter(x, y);
// string result = quarter > 0
//         ? $"Указанные координаты соответствуют четверти -> {quarter}"
//         : "Введены некорректны координаты";

// Console.WriteLine(result);


// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());


// string Quarter(int num)
// {
//     if (num == 1) return "x > 0 and y > 0";
//     if (num == 2) return "x < 0 and y > 0";
//     if (num == 3) return "x < 0 and y < 0";
//     if (num == 4) return "x > 0 and y < 0";
//     return "Введены некорректны координаты";
// }

// string res = Quarter(number);
// Console.WriteLine(res);


// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21




// System.Console.WriteLine("Введите первую точку: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// double xb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Введите вторую точку: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// double yb = Convert.ToDouble(Console.ReadLine());

// double Theorem(double x1, double y1, double x2, double y2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// }
// double result = Theorem(xa, xb, ya, yb);

// System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));




// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// void Mul(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.WriteLine($"{i,4} = {i * i,4}");

//     }

// }

// Mul(10);