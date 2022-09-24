// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using static System.Console;
Clear();
Write("Введите координаты первой точки: ");
int X1=int.Parse(ReadLine()!);
int Y1=int.Parse(ReadLine()!);
int Z1=int.Parse(ReadLine()!);
Write("Введите координаты второй точки: ");
int X2=int.Parse(ReadLine()!);
int Y2=int.Parse(ReadLine()!);
int Z2=int.Parse(ReadLine()!);
WriteLine(Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1)));