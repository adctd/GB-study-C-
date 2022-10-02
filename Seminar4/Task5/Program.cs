// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке
// и считает кол-во нулей в массиве

using static System.Console;
Clear();
Write("Введите размер массива: ");
int size=int.Parse(ReadLine()!);
int[] array=GetBinaryArray(size);
PrintArray(array);
WriteLine("");
WriteLine($"Количество нулей в массиве равно {CountZero(array)}");

//Метод создает массив
int[] GetBinaryArray(int length)
{
    int[] result=new int[length];

    for(int i=0; i<length; i++)
    {
        result[i]=new Random().Next(0,2);
    }
    return result;
}

//Метод печатает массив
void PrintArray(int[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}] ");
}

//Метод считает нули в массиве
int CountZero(int[] inArray)
{
    int count = 0;
    for(int i=0; i<size; i++)
    {
        if(array[i]==0)
        {
            count++;
        }
    }
    return count;
}