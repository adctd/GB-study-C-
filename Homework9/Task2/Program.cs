// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();
Write("Введите первое число: ");
int M=int.Parse(ReadLine()!);
Write("Введите второе число: ");
int N=int.Parse(ReadLine()!);
WriteLine(SumNumber(M, N));


//Функция, которая находит сумму натуральных элементов в промежутке от M до N (рекурсия)
int SumNumber(int a, int b)
{
    if(a==b) return a;
    else return a + SumNumber(a+1, b);
}