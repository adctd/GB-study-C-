// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();
Write("Введите позицию элемента в строке: ");
int x= int.Parse(ReadLine()!);
Write("Введите позицию элемента в столбце: ");
int y= int.Parse(ReadLine()!);
int[,] matrix = GetMatrixArray(new int[3,4]);
PrintMatrix(matrix);
CheckElement(matrix,x,y);


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

//Функция, проверяющая наличие элемента в массиве
void CheckElement(int[,] myMatrix, int pos1, int pos2)
{
     if(pos1 < myMatrix.GetLength(0) && pos2 < myMatrix.GetLength(1))
     {
        WriteLine($"Значение элемента на текущей позиции массива {myMatrix[pos1,pos2]}");
     }
     else
     {
        WriteLine("Такого элемента в массиве нет");
     }
}