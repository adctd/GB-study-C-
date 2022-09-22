//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
using static System.Console;
Clear();
int number=new Random().Next(100,999+1);
WriteLine(number);
int a0=number%10;
//int a1=number/10;
int a2=number/100;
//WriteLine($"{a2}{a0}");
int res = a2*10+a0;
WriteLine(res);