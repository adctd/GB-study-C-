// Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]

using static System.Console;
Clear();
int[] array = new int[8];
GetArray(array);
PrintArray(array);

//Метод создает массив
void GetArray(int[] array)
{
    int length = 8;
    for(int i=0; i<length; i++)
    {
        array[i]=new Random().Next(1,100);
    }
}

//Метод печатает массив
void PrintArray(int[] array)
{
    Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Write($"{array[i]},");
    }
    Write($"{array[array.Length-1]}] ");
}