// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

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
MultiElements(array); //строка для первого варианта
int[] resultArray = MultElement(array); //строка для второго варианта
WriteLine($"[{String.Join(",", resultArray)}]"); //строка для второго варианта


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


//Функция, которая умножает пары элементов массива (первый с последним и тд)
void MultiElements(int[] myArray)
{
    int arrayLength = (myArray.Length%2 == 0) ? myArray.Length/2 : myArray.Length/2 +1;
    int[] newArray = new int[arrayLength];
    for(int i = 0; i < (myArray.Length/2); i++)
    {
        int result=myArray[i] * myArray[myArray.Length-1-i];
        newArray[i] = result;
    }
    if(myArray.Length%2 != 0)
    {
        newArray[arrayLength-1] = myArray[myArray.Length/2];
    }
    WriteLine($"[{String.Join(",", newArray)}]");
}


//Вариант2: Функция, которая умножает пары элементов массива (первый с последним и тд)
int [] MultElement(int [] array)
{
    int len = array.Length;
    int size = len/2 + len%2;
    int [] multarray = new int [size];
    for(int i=0; i < size; i++)
    {
        if (i != len - 1 - i)
        {
            multarray[i] = array[i] * array[len - 1 - i];
        }
        else{multarray[i] = array[i];}
    }
    return multarray;
}