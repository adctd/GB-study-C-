Console.Clear();
Console.Write("Введите число: ");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=int.Parse(Console.ReadLine()!);
int sqr1=num1*num1;
int sqr2=Convert.ToInt32(Math.Pow(num2,2));
Console.WriteLine($"Квадрат числа {num1} = {sqr1}");
Console.WriteLine($"Квадрат числа {num2} = {sqr2}");