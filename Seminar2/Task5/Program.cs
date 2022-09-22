// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
using static System.Console;

Clear();
Write("Введите два числа: ");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());

if(num2>num1)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

if(num1 == num2*num2)
{
    Write($"Число {num1} является квадратом числа {num2}");
}
else
{
    WriteLine($"Число {num1} НЕ является квадратом числа {num2}");
}