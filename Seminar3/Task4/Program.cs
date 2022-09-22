// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
using static System.Console;
Clear();
Write("Введите число: ");
int number=int.Parse(ReadLine()!);
int count = 1;
while(count <= number)
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count++;
}