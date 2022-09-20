//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N
using static System.Console;
Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
int num2=1;
while(num2<=num1)
{
    if(num2%2 == 0)
    {
    Write($"{num2} ");
    num2=num2+1;
    }
    else
    {
    num2=num2+1;
    }
}
    