// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

using static System.Console;
Clear();
WriteLine("Введите размер массива, мин и макс значения через пробел:");
string[] parameters=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[] array1 = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]),int.Parse(parameters[2]));
int[] array2 = new int[array1.Length];
for(int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}
WriteLine($"[{String.Join(",", array1)}]");
WriteLine($"[{String.Join(",", array2)}]");


//Функция создающая массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;
}
