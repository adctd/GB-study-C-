// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.
using static System.Console;

Clear();
Write("Введите два числа: ");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());

if (num2 == 0)
{
    WriteLine("На 0 делить нельзя!");
    return;
}

if(num1>num2)
{
    int temp = num2;
    num2 = num1;
    num1 = temp;
}

if(num2%num1 == 0)
{
    Write($"Число {num2} кратно числу {num1}");
}
else
{
    WriteLine($"Остаток от деления равен {num2%num1}");
}