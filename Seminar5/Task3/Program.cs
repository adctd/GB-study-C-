// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.


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
Write("Введите число, которое нужно найти: ");
int element=int.Parse(ReadLine()!);
FindElement(array, element);


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


//Функция, которая ищет заданный элемент в массиве
void FindElement(int[] myArray, int number)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] == number)
        {
            WriteLine($"Число {number} в массиве присутствует");
            return;
        }
    }
    WriteLine($"Число {number} в массиве отсутствует");
}