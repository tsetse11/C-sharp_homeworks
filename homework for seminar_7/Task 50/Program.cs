// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix, int i, int j)
{
    if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
    {
        Console.WriteLine($"Позиции {i}, {j} в массиве нет");
        return;
    }
    else
        Console.WriteLine($"{matrix[i, j]}");
        return;
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.Write($"\nВведите позицию элемента в массиве (строка_столбец): ");
int[] coordnew = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
ReleaseMatrix(matrix, coordnew[0], coordnew[1]);
