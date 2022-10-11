// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
int[,] matrix = GetMatrixArray(new int[3,4]);
PrintMatrix(matrix);
CheckAverage(matrix);


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

//Функция, находящая среднее арифметическое элементов в каждом столбце
void CheckAverage(int[,] inMatrix)
{
    double sum = 0;
    double average = 0;
     for(int j=0; j < inMatrix.GetLength(1); j++)
    {
        for(int i=0; i < inMatrix.GetLength(0); i++)
        {
            sum=sum+inMatrix[i,j];
        }
        average = sum/inMatrix.GetLength(0);
        WriteLine($"среднее арифметическое элементов в столбце {average}");
        sum = 0;
    }
}