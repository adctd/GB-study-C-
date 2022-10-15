// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7


using static System.Console;
Clear();
int[,] matrix = GetMatrixArray(new int[3,4]);
PrintMatrix(matrix);
WriteLine();
ChangeMatrix(matrix);
PrintMatrix(ChangeMatrix(matrix));

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

//Функция, которая заменяет строки на столбцы и проверяет возможно ли это
int[,] ChangeMatrix(int[,] myMatrix)
{
    int[,] result = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
    if(myMatrix.GetLength(0)!=myMatrix.GetLength(1))
    {
    WriteLine("Невозможно это сделать!");
    return myMatrix;
    }
    else
    {
     for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            result[i,j] = myMatrix[j,i];
        }
    }
    return result;
    }
    
}
