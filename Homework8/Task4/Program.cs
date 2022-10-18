// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


using static System.Console;
Clear();
int[,,] matrix = Get3DMatrix(new int[2,2,2]);
PrintMatrix3D(matrix);

//Функция, создающая новый 3D массив
int[,,] Get3DMatrix(int[,,] newMatrix3D)
{
    for (int i = 0; i < newMatrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix3D.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                    if (FindElementInArray(newMatrix3D, num))
                    {
                        k--;
                    }
                    else
                    {
                        newMatrix3D[i, j, k] = num;
                    }
            }
        }
    }
    return newMatrix3D;
}

bool FindElementInArray(int[,,] array, int element)
{
    foreach (int el in array)
    {
    if (el == element) return true;
    }
    return false;
}



//Функция, выводящая 3D массив в консоль
void PrintMatrix3D(int[,,] matrix3D)
{
    for(int i=0; i < matrix3D.GetLength(0); i++)
    {
        for (int j=0; j < matrix3D.GetLength(1); j++ )
        {
            for (int k=0; k < matrix3D.GetLength(2); k++ )
            {
                Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}