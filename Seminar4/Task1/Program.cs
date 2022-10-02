//Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А

using static System.Console;
Clear();
Write("Введите число: ");
int A = int.Parse(ReadLine()!);
int sum = GetSum2(A);
WriteLine($"Сумма чисел от 1 до А = {sum}");


//Метод получения суммы:
int GetSum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result+=number;
        number--;
    }
    return result;
}
// Получение суммы методом for
int GetSum2(int number)
{
    int result = 0;
    for(int i=1; i<=number;i++)
    {
        result+=i;
    }
    return result;
}