﻿//Два стрелка стреляют по банкам, первый - слева-направо, второй - справа - налево
//в какой-то момент они простреливают одну банку, каждый знает сколько он прострелил,
//вычислить кто сколько не поразил.
using static System.Console;
Clear();
Write("Сколько банок сбил первый: ");
int number1=int.Parse(ReadLine()!);
Console.Write("Сколько банок сбил второй: ");
int number2=int.Parse(ReadLine()!);
WriteLine($"Первый не поразил {number2 - 1}, а второй не поразил {number1 - 1}");