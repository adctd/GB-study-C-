// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();
Write("Введите число: ");
int N = int.Parse(ReadLine()!);
int sum = GetSum(N);
WriteLine($"Сумма цифр равна {sum}");


//Метод подсчета суммы цифр в числе:
int GetSum(int number)
{
    int result = 0;
    while(N > 0)
    {
        int num = N%10;
        result=result+num;
        N=N/10;
    }
    return result;
}