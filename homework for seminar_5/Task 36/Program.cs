// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 51);
}

void ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum += array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях:{sum} ");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
