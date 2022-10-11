// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using static System.Console;
Clear();
Write("Введите размер матрицы: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0],parameters[1]);
PrintMatrix(matrix);





//Функция, создающая новый двумерный массив
int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for(int i=0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j=0; j < resultMatrix.GetLength(1); j++ )
        {
            resultMatrix[i,j]=i+j;
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
//число строк и столбцов
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