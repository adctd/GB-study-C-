// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();
WriteLine("Введите координату b1:");
double b1 = double.Parse(ReadLine()!);
WriteLine("Введите координату b2:");
double b2 = double.Parse(ReadLine()!);
WriteLine("Введите координату k1:");
double k1 = double.Parse(ReadLine()!);
WriteLine("Введите координату k2:");
double k2 = double.Parse(ReadLine()!);
PeresechenieTochek(b1,b2,k1,k2);

void PeresechenieTochek(double a, double b, double c, double d)
{
    double x = (b-a)/(c-d);
    double y = (b*c-a*d)/(c-d);
    WriteLine($"Точка пересечения двух прямых: ({x};{y})");
}