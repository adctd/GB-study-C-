// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();
WriteLine("введите размер квадратного массива:");
int size = int.Parse(ReadLine()!);
int[,] matrix = GetMatrixArray(new int[size, size]);
PrintMatrix(matrix);
WriteLine();
MinSumMatrix(matrix);

//Функция, создающая новый двумерный массив
int[,] GetMatrixArray(int[,] newMatrix)
{
    for(int i=0; i < newMatrix.GetLength(0); i++)
    {
        for (int j=0; j < newMatrix.GetLength(1); j++ )
        {
            newMatrix[i,j]=new Random().Next(1,10);
        }
    }
    return newMatrix;
}


//Функция, выводящая двумерный массив в консоль
void PrintMatrix(int[,] inMatrix)
{
    for(int i=0; i < inMatrix.GetLength(0); i++)
    {
        for (int j=0; j < inMatrix.GetLength(1); j++ )
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}

//Функция, считающая сумму элементов в каждой строке 
//и выдающая номер строки с наименьшей суммой элементов
void MinSumMatrix(int[,] myMatrix)
{
    int minSum = Int32.MaxValue;
    int indexLine = 0;

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            sum = sum + myMatrix[i, j];        
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLine++;
        }
    }
WriteLine($"Строка с наименьшей суммой элементов под номером {indexLine}");
}