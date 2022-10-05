// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max=int.Parse(ReadLine()!);
int[] array=GetArray(length, min, max);
WriteLine($"[{String.Join(",", array)}]");
ReverseArrayValue(array);


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

//Функция меняющая положит элементы массива на отриц и наоборот
void ReverseArrayValue (int[] reverseArray)
{
    for(int i = 0; i < reverseArray.Length; i++)
    {
        reverseArray[i]= reverseArray[i] * (-1);
    }
    WriteLine($"[{String.Join(",", reverseArray)}]");
}