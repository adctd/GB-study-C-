//Универсальный метод перевода десятичного числа в двоичное:

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
string res = DecToNum(number,2);
WriteLine($"{number} ===> {res}");

//Функция перевода
string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
       {
       int ost=decNumber/otherSystem;
       // res=nums[ost]+res;
       res=nums[decNumber-otherSystem*ost]+res;
       decNumber/=otherSystem;
       }
    return res;
}