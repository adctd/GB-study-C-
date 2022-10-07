// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
WriteLine("Введите числа через пробел:");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
WriteLine($"[{String.Join(",", array)}]");
PodschetChisel(array);


void PodschetChisel(int[] newArray)
{
    int result = 0;
    foreach(int item in newArray)
    {
        if(item > 0)
        result++;
    }
    WriteLine($"Сумма положительных чисел: {result}");
}

