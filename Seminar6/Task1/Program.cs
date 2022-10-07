// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using static System.Console;
Clear();
WriteLine("Введите размер массива, мин и макс значения через пробел:");
string[] parameters=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]),int.Parse(parameters[2]));
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"[{String.Join(",", ReverseArray(array))}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");

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

//Функция разворачивающая массив (создает новый массив на базе текущего)

int[] ReverseArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i]=inArray[inArray.Length-1-i];
    }
    return result;
}

//Функция разворачивающая массив (разворачивает текущий массив)

void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i] = temp;
    }
}