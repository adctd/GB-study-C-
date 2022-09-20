using static System.Console;

Clear();
Write("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
if(num == 1)
    {
        Write("Сегодня понедельник");
    }
    if(num == 2)
    {
        Write("Сегодня вторник");
    }
    if(num == 3)
    {
        Write("Сегодня среда");
    }
    if(num == 4)
    {
        Write("Сегодня четверг");
    }
    if(num == 5)
    {
        Write("Сегодня пятница");
    }
    if(num == 6)
    {
        Write("Сегодня суббота");
    }
    if(num == 7)
    {
        Write("Сегодня воскресенье");
    }
    if(num > 7 || num < 1)
    {
        Write("Нет такого дня недели");
    }