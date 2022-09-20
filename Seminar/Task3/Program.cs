//Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N

using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
int num2=-num1;

while(num2<=num1)
{
    Write($"{num2} ");
    num2=num2+1; //либо num2++
}