// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N 
// вне зависимости от того, какое число больше
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();
Write("Введите первое число: ");
int M=int.Parse(ReadLine()!);
Write("Введите второе число: ");
int N=int.Parse(ReadLine()!);
WriteLine(NumbersRec(M, N));


//Функция, которая выводит все натуральные числа в промежутке от M до N (рекурсия)
//вне зависимости от того, какое число больше
string NumbersRec(int a, int b)
{
 if (a == b) return b.ToString();
 else return (a < b) ? NumbersRec(a, b-1) + " " + b : NumbersRec(a-1, b) + " " + a;
}