// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


using static System.Console;
Clear();
int[] array = new int[5];
FillArray(array);
FindMinMaxDif(array);


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

//Функция, находящая разницу между макс и мин значениями элементов массива
void FindMinMaxDif(int[] array)
{
    int dif = 0;
    int min = array[0];
    int max = array[0];
    for(int i= 0; i < array.Length; i++)
    {
        if(array[i]<min)
        min = array[i];
    }
for(int i= 0; i < array.Length; i++)
    {
        if(array[i]>max)
        max = array[i];
    }
    dif = max - min;
    Write($"Разница между макс и мин значениями элементов массива равна {dif}");
}