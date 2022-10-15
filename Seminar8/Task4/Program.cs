// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

using static System.Console;
Clear();
int[,] matrix = GetMatrixArray(new int[3,3]);
PrintMatrix(matrix);
int[] array = LineArray(matrix);
CountElem(array);


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

//Функция, преобразующая двумерный массив в одномерный и сразу сортирующая его

int[] LineArray(int[,] myMatrix)
{
    int[] lineArray = new int[myMatrix.GetLength(0) * myMatrix.GetLength(1)];
    int count = 0;
    for(int i=0; i < myMatrix.GetLength(0); i++)
    {
        for (int j=0; j < myMatrix.GetLength(1); j++ )
        {
            lineArray[count] = myMatrix[i,j];
            count++;
        }
    }
    WriteLine($"[{String.Join(",", lineArray)}]");
    Array.Sort(lineArray);
    return lineArray;
}

//Функция, считающая сколько раз встречается элемент входных данных
void CountElem(int[] myArray)
{
int number = myArray[0];
int count = 1;
for (int i = 1; i < myArray.Length; i++)
{
    if(myArray[i] == number) 
    {
        count++;
    }
    else 
    {
        WriteLine($"Число {number} встретилось {count} раз");
        number = myArray[i];
        count = 1;
    } 
}
WriteLine($"Число {number} встретилось {count} раз");
}