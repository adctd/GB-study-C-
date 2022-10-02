// Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();
Write("Введите 2 числa: ");
int numberA = int.Parse(ReadLine()!);
int numberB = int.Parse(ReadLine()!);
int Exp=Exponent(numberA);
WriteLine($"{numberA} в {numberB} степени равно {Exp}");

//метод возведения числа А в степень В
int Exponent(int number)
{   
    int result = 1;
    for(int i=1; i<=numberB; i++)
    {
        result=result*numberA;
    }
    return result;
}