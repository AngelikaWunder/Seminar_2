// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 999990)
{
    Console.WriteLine("ваше число больше, чем пятизначное. Введите пятизначное число: ");
}
else
{
    int num1 = num / 10000;
    int num5 = num % 10;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("-> да, число является палиндромом");
    }
    else
    {
        Console.WriteLine("-> нет, число не является палиндромом");
    }
}