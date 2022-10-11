// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


using static System.Console;
Clear();
Write("Введите размер матрицы: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0],parameters[1]);
PrintMatrix(matrix);
WriteLine(SumMatrix(matrix));





//Функция, создающая новый двумерный массив
int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for(int i=0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j=0; j < resultMatrix.GetLength(1); j++ )
        {
            resultMatrix[i,j]=new Random().Next(1,10);
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
//Функция, находящая сумму элементов, находящихся на главной диагонали
// void SumMatrix(int[,] myMatrix)
// {
//     int result=0;
//     for(int i=0; i < myMatrix.GetLength(0); i++)
//     {
//         for (int j=0; j < myMatrix.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 result=result + myMatrix[i,j];
//             }
//         }
//     }
//     Write($"Сумма элементов, находящихся на главной диагонали равна {result} ");
// }

//Функция, находящая сумму элементов, находящихся на главной диагонали
int SumMatrix(int[,] myMatrix)
{
    int result=0;
    for(int i=0; i < myMatrix.GetLength(0); i++)
    {
        for (int j=0; j < myMatrix.GetLength(1); j++)
        {
            if(i == j)
            {
                result=result + myMatrix[i,j];
            }
        }
    }
    return result;
}