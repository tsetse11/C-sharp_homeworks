// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int rec(int a, int b)
{
    if (a == 0)
        return b + 1;
    if (a != 0 && b == 0)
        return rec(a - 1,1);
    if (a > 0 && b > 0)
        return rec(a - 1, rec(a, b - 1));
    return rec(a, b);
}

Console.Write($"{rec(a, b)} ");