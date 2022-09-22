// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
using static System.Console;

Clear();
Write("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
if(num%7 == 0 && num%23 == 0)
    {
        Write($"Число {num} кратно 7 и 23");
    }
else
{
    Write($"Число {num} некратно 7 и 23");
}