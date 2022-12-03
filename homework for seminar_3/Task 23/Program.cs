// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
    Console.Write($"{i * i * i} ");
