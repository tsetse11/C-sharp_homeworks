// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 10000 || a > 100000)
{
    Console.WriteLine("Вы ввели не пятизначное число!\nВведите пятизначное число: ");
    a = Convert.ToInt32(Console.ReadLine());     
}
int a1 = a / 10000;
int a2 = a / 1000 - a1 * 10;
int a3 = a / 100 - a2 * 10 - a1 * 100;
int a4 = a / 10 - a3 * 10 - a2 * 100 - a1 * 1000;
int a5 = a - a4 * 10 - a3 * 100 - a2 * 1000 - a1 * 10000;
if (a1 == a5 && a2 == a4)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
