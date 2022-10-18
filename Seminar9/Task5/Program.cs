// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using static System.Console;
Clear();
Write("Введите первое число: ");
int A=int.Parse(ReadLine()!);
Write("Введите второе число: ");
int B=int.Parse(ReadLine()!);
WriteLine(GetNumber(A, B));


//Функция, которая возводит число А в целую степень B с помощью рекурсии
int GetNumber(int a, int b)
{
    if(b==1) return a;
    else return a * GetNumber(a, b-1);
}