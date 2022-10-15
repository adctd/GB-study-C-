// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент (первый найденный).

using static System.Console;
Clear();
int[,] matrix = GetMatrixArray(new int[4,4]);
PrintMatrix(matrix);
int[,] matrix2 = MinNumberDel(matrix);
WriteLine();
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

//Функция, находящая минимальный элемент в массиве и удаляющая строку и столбец
int [,] MinNumberDel(int[,] myMatrix)
{
    int[,] newMatrix = new int[myMatrix.GetLength(0)-1,myMatrix.GetLength(1)-1];
    int min = myMatrix[0,0];
    int rowX = 0;
    int colX = 0;
    for(int i=0; i < myMatrix.GetLength(0); i++)
    {
        for (int j=0; j < myMatrix.GetLength(1); j++ )
        {
            if(myMatrix[i,j]<min)
            {
                min = myMatrix[i,j];
                rowX = i;
                colX = j;
            }
        }
    }
    int row=0;
    int column=0;
    for(int i=0; i < myMatrix.GetLength(0); i++)
    {
        if(i==rowX) continue;
        for (int j=0; j < myMatrix.GetLength(1); j++ )
        {
            if(j==colX) continue;
            newMatrix[row,column] = myMatrix[i,j];
            column++;
        }
        column=0;
        row++;
    }
    return newMatrix;
}