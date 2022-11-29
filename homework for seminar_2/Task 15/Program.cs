// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите день недели при помощи цифр: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a == 6 || a ==7)
{
    Console.Write("Ура! Это выходной))\nВведите день недели при помощи цифр: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 1)
    Console.Write("Это не выходной!");
else if (a == 2)
    Console.Write("Это не выходной!");
else if (a == 3)
    Console.Write("Это не выходной!");
else if (a == 4)
    Console.Write("Это не выходной!");
else
    Console.Write("Это не выходной!");