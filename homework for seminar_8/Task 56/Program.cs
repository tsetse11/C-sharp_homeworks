// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] InputMatrix()
{
    Console.WriteLine("Количество строк матрицы: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Количество столбцов матрицы: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row == column)
    {   
        Console.Write("Вы ошиблись! Нужно задать прямоугольный двумерный массив.\n");
        Console.Write("Количество строк матрицы: ");
        Console.Write("Количество столбцов матрицы: ");
    }
    int[,] matrix = new int[row, column];
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {  
        int sum = 0; 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            sum += matrix[i, j];
            Console.Write($"{matrix[i,j]} \t");                                      
        }
        Console.WriteLine($"Сумма строки {i+1}: {sum} ");
    }
}

int SumElements(int[,] matrix)
{   
    int[] SumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            SumArray[i] += matrix[i, j];
        }
    }
    return SumElements(matrix);
}

Console.Clear();
Console.Write("Введите размер матрицы\n");
int[,] matrix = InputMatrix();
Print(matrix);
Console.WriteLine($"\nНаименьшая сумма элементов в {не понимаю как сделать} строке");
