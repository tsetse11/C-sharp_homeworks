// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 51);
}

void DifferenceMaxMin(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min)
            Min = array[i];
        if (array[i] > Max)
            Max = array[i];
    }
    Console.Write($"Разность между максимальным и минимальным элементами массива: {Max - Min} ");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
DifferenceMaxMin(array);
