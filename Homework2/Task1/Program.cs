// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int num=int.Parse(ReadLine());
int a1=num/10;
int a2=a1%10;
WriteLine(a2);