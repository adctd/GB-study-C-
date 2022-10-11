// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
int count = 0;
do
{
    Write("Введите число:");
    if(int.Parse(ReadLine()!)>0) count++;
    WriteLine($"Сумма положительных чисел: {count}");
    WriteLine("Продолжим? Да - enter, Нет - n");
} while (!(ReadLine()!.Equals("n")));
WriteLine($"Итак, конечная сумма положительных чисел: {count}");

// Второй вариант (Enter продолжаем, любая другая клавиша выход)
// int count = 0;
// do
// {
// Write("Input number: ");
// if (int.Parse(ReadLine()!) > 0) count++;
// WriteLine($"Positive numbers = {count}");
// WriteLine("Continue? Yes - enter, No - any key");
// } while (ReadKey().Key==ConsoleKey.Enter);