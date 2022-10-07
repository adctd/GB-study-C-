//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// см ниже второй вариант

using static System.Console;
Clear();
Write("Введите число: ");
int a = int.Parse(ReadLine()!);
Write(DexToBin(a));


string DexToBin(int number)
{
    if(number == 0)
    {
        return "0";
    } 
    string result = string.Empty;
    while(number != 0)
    {
        result = (number%2) + result;
        number = number/2;
    }
    return result;
}

//Второй вариант короткий
// using static System.Console;
// Clear();
// Write("Введите число: ");
// int a = int.Parse(ReadLine()!);
// WriteLine(Convert.ToString(a,2));
