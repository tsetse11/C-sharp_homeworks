// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a / 10) % 10);
