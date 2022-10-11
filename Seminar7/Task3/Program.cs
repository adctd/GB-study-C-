// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 4 4

using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);
WriteLine();
EditMatrix(matrix);
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

void EditMatrix(int[,] myMatrix)
{
    for(int i=0; i < myMatrix.GetLength(0); i++)
    {
        for (int j=0; j < myMatrix.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0)
            {
                myMatrix[i,j]=Convert.ToInt32(Math.Pow(myMatrix[i,j],2));
            }
        }
    }
}