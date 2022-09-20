//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)
using static System.Console;
Clear();
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());
if(num%2 == 0)
    {
        Write($"Число {num} четное!");
    }
else
    {
        Write($"Число {num} нечетное!");
    }