//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();
Write("Введите два числа: ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = Convert.ToInt32(ReadLine());
if(num1 == num2)
    {
    Write($"Числа равны");
    }
else 
    {
    if(num1 > num2)
        {
        Write($"{num1} больше чем {num2} ");
        }
    else
        {
        Write($"{num2} больше чем {num1} ");
        }
    }