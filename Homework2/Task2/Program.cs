// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6
using static System.Console;
Clear();
WriteLine("Введите число: ");
int num=int.Parse(ReadLine());
if(num<100)
{
    WriteLine("Третьей цифры нет");
}
else 
{
    int a1=num/100;
    int a2=a1%10;
    WriteLine(a2);
}
