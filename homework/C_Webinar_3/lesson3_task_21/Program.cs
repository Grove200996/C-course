// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите первую точку: ");
double xa = Convert.ToDouble(Console.ReadLine());
double xb = Convert.ToDouble(Console.ReadLine());
double xc = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите вторую точку: ");
double ya = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double yc = Convert.ToDouble(Console.ReadLine());



double Coordinates(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

}
double result = Coordinates(xa, xb, ya, yb, xc, yc);

Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));