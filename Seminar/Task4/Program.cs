//Напишите программу, которая принимает на вход
//трехзначное число и на выходе показывает **последнюю** цифру этого числа
using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());

WriteLine(num1%10);