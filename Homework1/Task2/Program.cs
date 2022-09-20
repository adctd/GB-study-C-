//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
using static System.Console;
Clear();
Write("Введите три числа: ");
int num1 = Convert.ToInt32(ReadLine());
int num2 = Convert.ToInt32(ReadLine());
int num3 = Convert.ToInt32(ReadLine());
if(num1 > num2)
        {
        if(num1 > num3)
            {
                Write($"Максимальное число {num1}");
            }
        else
            {
                Write($"Максимальное число {num3}");
            }
        }
    else
        {
            if(num2 > num3)
            {
            Write($"Максимальное число {num2}");
            }
            else
            {
            Write($"Максимальное число {num3}");
            }
        }