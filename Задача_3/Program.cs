// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на два без остатка).
// int a = 5; int ost = 5 % 2; int ost1 = 4 % 2; 4 -> да; -3 -> нет; 7 -> нет;
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if(a % 2 == 0)
Console.WriteLine($"Да, четное {a}");
if(a % 2 != 0)
Console.WriteLine($"Нет, нечетное {a}");
