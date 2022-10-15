// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();
WriteLine("Введите размер матриц: ");
int size = int.Parse(ReadLine()!);
int[,] matrixA = GetMatrixArray(new int[size, size]);
PrintMatrix(matrixA);
WriteLine();
int[,] matrixB = GetMatrixArray(new int[size, size]);
PrintMatrix(matrixB);
WriteLine();
int[,] matrixC = MultMatrix(matrixA,matrixB);
PrintMatrix(matrixC);

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

//Функция, находящая произведение двух матриц
int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for(int i=0; i < newMatrix.GetLength(0); i++)
    {
        for (int j=0; j < newMatrix.GetLength(1); j++ )
        {
            for (int k = 0; k < newMatrix.GetLength(0); k++)
            {
                newMatrix[i, j] = newMatrix[i, j] + (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }
    return newMatrix;
}