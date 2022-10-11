// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Введите количество столбцов: ");
int m= int.Parse(ReadLine()!);
Write("Введите количество строк: ");
int n= int.Parse(ReadLine()!);
double[,] matrix = GetMatrixArray(new double [m,n]);
PrintMatrix(matrix);



//Функция, создающая новый двумерный массив
double[,] GetMatrixArray(double[,] newMatrix)
{
    for(int i=0; i < newMatrix.GetLength(0); i++)
    {
        for (int j=0; j < newMatrix.GetLength(1); j++ )
        {
            newMatrix[i,j]=Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return newMatrix;
}

//Функция, выводящая двумерный массив в консоль
void PrintMatrix(double[,] inMatrix)
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