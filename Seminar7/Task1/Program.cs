//  Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);





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