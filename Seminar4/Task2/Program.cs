// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;
Clear();
Write("Введите число: ");
int A = int.Parse(ReadLine()!);
int sum = GetSum2(A);
WriteLine($"Количество цифр в числе {A} равно {sum}");

//Метод подсчета цифр:
int GetSum(int number)
{
    int result = 0;
    while(number > 0)
    {
        number/=10;
        result++;
    }
    return result;
}

//Метод подсчета цифр через for:
int GetSum2(int number)
{
    int result = 0;
    for(int i = 1; number > 0; i++)
    {
        number/=10;
        result++;
    }
    return result;
}