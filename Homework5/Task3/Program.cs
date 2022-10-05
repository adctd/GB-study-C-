// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
int[] array = new int[5];
FillArray(array);
FindSumOddElem(array);


//Функция, создающая массив
void FillArray(int[] myArray)
{
    int length = myArray.Length;
    int i = 0;
    while(i<length)
    {
        myArray[i] = new Random().Next(-99,100);
        i++;
    }
    WriteLine($"[{String.Join(",", myArray)}]");
}

//Функция, находящая сумму элементов, стоящих на нечётных позициях
void FindSumOddElem(int[] array)
{
    int sum = 0;
    for(int i= 0; i < array.Length; i++)
    {
        if(i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Write($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
}