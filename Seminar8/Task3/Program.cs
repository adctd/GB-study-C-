//Преобразование массива одного типа данных в другие

using static System.Console;
Clear();

int[] arr = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),Convert.ToInt32);

foreach (var item in arr)
{
    WriteLine(item);
}