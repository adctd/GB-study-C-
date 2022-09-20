using static System.Console;

Clear();
Write("Введите число: ");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
if(num2*num2 == num1)
    {
        Write($"Число {num1} является квадратом числа {num2}");
    }
else 
    {
        Write($"Число {num1} не является квадратом числа {num2}");
    }