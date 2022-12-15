// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double SumColumn = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            SumColumn += matrix[i, j];
        double Average = Math.Round(SumColumn / matrix.GetLength(0), 2);
        Console.Write($"{Average} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
ReleaseMatrix(matrix);
