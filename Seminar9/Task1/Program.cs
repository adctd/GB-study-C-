// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;
Clear();
Write("Введите число >1 : ");
int number=int.Parse(ReadLine()!);
string numbersStr=GetNumbers3(number);
WriteLine(numbersStr);
GetNumbers2(number);


//Функция, которая выводит все натуральные числа в промежутке от 1 до N (рекурсия)
string GetNumbers(int n)
{
    if(n==1) return n.ToString();
    else return GetNumbers(n-1)+" "+n;
}

//2ая Функция, которая выводит все натуральные числа в промежутке от 1 до N (рекурсия)
void GetNumbers2(int n)
{
    if(n==1) Write(n);
    else 
    {
        GetNumbers2(n-1);
        Write(" "+n);
    }
}

//3 Функция, которая выводит все натуральные числа в промежутке от 1 до N (рекурсия)
string GetNumbers3(int n)
{
    // if(n==1) return n.ToString();       //это можно заменить
    // else return GetNumbers(n-1)+" "+n;  //тернарным оператором
    return (n==1) ? n.ToString() : GetNumbers3(n-1)+" "+n;
}
