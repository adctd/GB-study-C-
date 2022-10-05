// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max=int.Parse(ReadLine()!);
int[] array=GetArray(length, min, max);
// string strArray=String.Join(",", array);
// WriteLine($"[{strArray}]");
WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;
foreach(int item in array)
{
    // positiveSum +=item > 0 ? item : 0;   //это второй вариант решения вместо if
    // negativeSum +=item < 0 ? item : 0;   //тернарный вариант
    if(item>0)
    {
        positiveSum+=item;
    }
    if(item<0)
    {
        negativeSum+=item;
    }
}
WriteLine($"NegativeSum = {negativeSum}, positiveSum = {positiveSum}");

//Функция создающая рандомный массив
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[] result=new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i]=rnd.Next(minValue, maxValue+1);
    }
    return result;
}

