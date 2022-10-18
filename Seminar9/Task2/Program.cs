// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();
Write("Введите первое число: ");
int M=int.Parse(ReadLine()!);
Write("Введите второе число: ");
int N=int.Parse(ReadLine()!);
WriteLine(NumbersRec2(M, N));


//Функция, которая выводит все натуральные числа в промежутке от M до N (рекурсия)
string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty;
}

//Функция, которая выводит все натуральные числа в промежутке от M до N (рекурсия)
// 2ой вариант:
string NumbersRec2(int a, int b)
{
 if (a == b) 
 {
    return b.ToString();
 }
 return NumbersRec2(a, b-1) + " " + b;
}