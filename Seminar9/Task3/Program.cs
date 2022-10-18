// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using static System.Console;
Clear();
Write("Введите число: ");
int number=int.Parse(ReadLine()!);
Write(SumNumber(number));



//Функция, возвращающая сумму цифр числа (рекурсия)
int SumNumber(int n)
{
    if(n/10==0) return n%10;
    else return SumNumber(n/10)+(n%10);
}