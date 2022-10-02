//Напишите программу, которая принимает на вход число N
//и выдает произведение чисел от 1 до N

using static System.Console;
Clear();
Write("Введите число: ");
int N = int.Parse(ReadLine()!);
int mult = GetMult3(N);
WriteLine($"Произведение цифр от 1 до {N} равно {mult}");


//Функция умножения чисел:
int GetMult(int number)
{
    int result = 1;
    while(number > 0)
    {
        result=result*number;
        number--;
    }
    return result;
}


//Функция умножения чисел:
int GetMult2(int number)
{
    int result = 1;
    for(int i=0; number > 0; i++)
    {
        result=result*number;
        number--;
    }
    return result;
}

//Функция умножения чисел:
int GetMult3(int number)
{
    int result = 1;
    for(int i=1; i<= number; i++)
    {
        result*=i;
    }
    return result;
}