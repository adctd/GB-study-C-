//по числу выдать день недели через кейсы

using static System.Console;

Clear();
Write("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1:
    {
        Write("Сегодня понедельник");
        break;
    }
    case 2:
    {
        Write("Сегодня вторник");
        break;
    }
    case 3:
    {
        Write("Сегодня среда");
        break;
    }
    case 4:
    {
        Write("Сегодня четверг");
        break;
    }
    case 5:
    {
        Write("Сегодня пятница");
        break;
    }
    case 6:
    {
        Write("Сегодня суббота");
        break;
    }
    case 7:
    {
        Write("Сегодня воскресенье");
        break;
    }
    default:
    {
        Write("Нет такого дня недели");
        break;
    }
    }