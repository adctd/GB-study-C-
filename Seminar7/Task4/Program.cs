//  Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// и потом разверните его

using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);
WriteLine();
PrintMatrix(ReverseMatrix(matrix));




//Функция, создающая новый двумерный массив
int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for(int i=0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j=0; j < resultMatrix.GetLength(1); j++ )
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return resultMatrix;
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

//Функция, возвращающая из строки числовые параметры: 
//число строк, столбцов, мин и макс значения
int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for(int i=0; i<parameterNum.Length; i++)
    {
        parameterNum[i]=int.Parse(parames[i]);
    }
    return parameterNum;
}

//Разворот матрицы
int[,] ReverseMatrix(int[,] inMatrix)
{
    int[,] result = new int[inMatrix.GetLength(0), inMatrix.GetLength(1)];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            result[i,j]=inMatrix[inMatrix.GetLength(0)-1-i,inMatrix.GetLength(1)-1-j];
        }
    }
    return result;
}

// void ReverseMatrix(int[,] inMatrix)
// {
//     for (int i = 0; i < inMatrix.GetLength(0)/2; i++)
//     {
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length-1-i];
//         inArray[inArray.Length-1-i] = temp;
//     }
// }