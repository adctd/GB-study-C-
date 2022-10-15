// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();
int[,] matrix = GetMatrixArray(new int[4,4]);
PrintMatrix(matrix);
WriteLine();
int[,] matrix2 = MinMaxMatrix(matrix);
PrintMatrix(matrix2);

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

//Функция, упорядочивающая по убыванию элементы каждой строки двумерного массива
int [,] MinMaxMatrix(int[,] myMatrix)
{
    for(int i=0; i < myMatrix.GetLength(0); i++)
    {
        for (int j=0; j < myMatrix.GetLength(1); j++ )
        {
            for (int k = 0; k < myMatrix.GetLength(1) - 1; k++)
            {
                if(myMatrix[i,k]<myMatrix[i,k+1])
                {
                    int temp = myMatrix[i,k];
                    myMatrix[i,k]=myMatrix[i,k+1];
                    myMatrix[i,k+1]=temp;
                }
            }
        }
    }
        return myMatrix;
}
