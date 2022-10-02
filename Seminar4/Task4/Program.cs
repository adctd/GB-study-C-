// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке

using static System.Console;
Clear();
Write("Введите размер массива: ");
int size=int.Parse(ReadLine()!);
int[] array=GetBinaryArray(size);
PrintArray(array);


// int[] array1={1,0,0,1};
// int[] array2=new int[4];

int[] GetBinaryArray(int length)
{
    int[] result=new int[length];

    for(int i=0; i<length; i++)
    {
        result[i]=new Random().Next(0,2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}