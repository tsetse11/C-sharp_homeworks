//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int rec(int a, int b)
{
    if (a == b)
        return a;
    return rec(a, b - 1) + a;
}

int sum( int a, int b)
{
    int result = 0;
    for (int i = a; i <= b; i++) result+=i;
    return result;
}
Console.Write(sum(a, b));