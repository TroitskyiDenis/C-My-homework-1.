// Напишите программу, которая на вход принимает два числа и выдает, какое число максимальное.
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
Console.WriteLine($"{num1}");
if (num1 < num2)
Console.WriteLine($"Максимальное число {num2}");