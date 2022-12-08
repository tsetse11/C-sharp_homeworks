// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()), count = 0;
while (a != 0)
{
    count +=a % 10;
    a /= 10;
}
Console.WriteLine(count);