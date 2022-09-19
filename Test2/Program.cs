// Напишите программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями :
//y=k1*x+b1; y=k2*x+b2; где значения переменных задаются пользователем
using static System.Console;
WriteLine("Введите К1 ");
double k1 = int.Parse(Console.ReadLine());
WriteLine("Введите К2 ");
double k2 = int.Parse(Console.ReadLine());
WriteLine("Введите B1 ");
double b1 = int.Parse(Console.ReadLine());
WriteLine("Введите B2 ");
double b2 = int.Parse(Console.ReadLine());
double x =  (b2-b1)/(k1-k2);
double y = (k1*x)+b1;
WriteLine($"(x, y) = ({x}, {y} ) ");