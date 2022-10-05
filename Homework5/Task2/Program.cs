// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
int[] array = new int[10];
FillArray(array);
FindEvenElem(array);


//Функция, создающая массив
void FillArray(int[] myArray)
{
    int length = myArray.Length;
    int i = 0;
    while(i<length)
    {
        myArray[i] = new Random().Next(100,1000);
        i++;
    }
    WriteLine($"[{String.Join(",", myArray)}]");
}

//Функция, находящая четные числа в массиве
void FindEvenElem(int[] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if(item%2 == 0)
        {
            sum ++;
        }
    }
    Write($"В этом массиве {sum} четных элементов");
}