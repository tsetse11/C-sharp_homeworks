// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    if (k1 == k2)
        Console.Write($"Заданные прямые не пересекаются!");
    else
        Console.Write($"Точка пересения двух прямых: ({x}; {y})");
}
