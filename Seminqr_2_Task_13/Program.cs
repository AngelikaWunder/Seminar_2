// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);
while (num > 1000)
{
    num = num / 100;
}
int res1 = num / 100;
if ( res1 != 0)
{
   int res2 = num % 10;
    Console.WriteLine($"-> {res2}");
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

