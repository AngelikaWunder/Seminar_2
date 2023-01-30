// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

//  • 14 -> нет 
//  • 46 -> нет 
//  • 161 -> да
Console.Clear();
Console.Write("Введите число ");
int num= int.Parse(Console.ReadLine ()!);
int res1 = num % 7;
int res2 = num % 23;

if (res1 == 0 && res2 == 0)
{
Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");  
}

