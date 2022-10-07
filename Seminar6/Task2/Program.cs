// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();
Write("Введите 3 числа(стороны треугольника): ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);
CheckTriangle(a,b,c);


//Функция проверяющая стороны треугольника
void CheckTriangle(int side1, int side2, int side3)
{
    if(side1+side2 > side3 && side2+side3 > side1 && side1+side3 > side2)
    {
        WriteLine("Треугольник с такими сторонами существует");
    }
    else
    {
        WriteLine("Треугольник с такими сторонами НЕ существует");
    }
}