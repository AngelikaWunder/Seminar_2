﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// // является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// // то программа выводит остаток от деления.

// // ● 34, 5 -> не кратно, остаток 4
// // ● 16, 4 -> кратно
Console.Clear();
Console.Write("Введите двузначное число а");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите двузначное число b");
int b = int.Parse(Console.ReadLine()!);
int c = a % b;
if (c == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {c}");
}