// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
using static System.Console;
Clear();
Write("Введите координаты X и Y: ");
int numX=int.Parse(ReadLine()!);
int numY=int.Parse(ReadLine()!);
if(numX == 0 || numY == 0)
{
    WriteLine("Error!");
    return;
}
if(numX > 0 && numY > 0)
{
    Console.WriteLine("Первая четверь");
}
if(numX < 0 && numY > 0)
{
    Console.WriteLine("Вторая четверь");
}
if(numX < 0 && numY < 0)
{
    Console.WriteLine("Третья четверь");
}
if(numX > 0 && numY < 0)
{
    Console.WriteLine("Четвертая четверь");
}