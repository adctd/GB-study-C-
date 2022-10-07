// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

using static System.Console;
Clear();
WriteLine("Введите число: ");
int N = int.Parse(ReadLine()!);
int[] array = Fibonacci(new int[N]);
WriteLine($"[{String.Join(",", array)}]");

int[] Fibonacci(int[] myArray)
{
    myArray[0] = 0;
    myArray[1] = 1;
    for(int i=2; i<N; i++)
    {
    myArray[i] = myArray[i-1] + myArray[i-2];
    }
    return myArray;
}