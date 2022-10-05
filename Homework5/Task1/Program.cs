// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

using static System.Console;
Clear();
int[] array = new int[123];
FillArray(array);
FindElem(array);


//Функция, создающая массив
void FillArray(int[] myArray)
{
    int length = myArray.Length;
    int i = 0;
    while(i<length)
    {
        myArray[i] = new Random().Next(1,100);
        i++;
    }
    WriteLine($"[{String.Join(",", myArray)}]");
}

//Функция, находящая элементы массива в отрезке [10,99]
void FindElem(int[] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if(item>=10 && item<=99)
        {
            sum ++;
        }
    }
    Write($"В этом массиве {sum} элементов, вошедших в отрезок [10,99]");
}