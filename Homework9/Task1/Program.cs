// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();
Write("Введите число: ");
int number=int.Parse(ReadLine()!);
string numbersStr=GetNumbers(number);
WriteLine(numbersStr);


//Функция, которая выводит все натуральные числа в промежутке от N до 1 (рекурсия)
string GetNumbers(int n)
{
    if(n==1) return n.ToString();
    else return n +" "+ GetNumbers(n-1);
}