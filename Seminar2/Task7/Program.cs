//Развернуть Nзначное число (решение через массив и индекс элементов)
using static System.Console;
Clear();
string number = ReadLine();
string result = string.Empty;
int i = 0;
while(i<number.Length)
{
    result=number[i]+result;
    i++;
}
WriteLine(result);