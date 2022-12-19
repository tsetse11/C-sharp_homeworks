//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i,j]}\t");
        }        
        Console.WriteLine();
    }
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");                                      
        }
        Console.WriteLine();
    }
}

void OrderElements(int[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            int maxNumber = k;
            for (int j = k + 1; j < matrix.GetLength(1); j++)
            {   
                if(matrix[i, j] > matrix[i, maxNumber])
                maxNumber = j;
            }
            int temp = matrix[i, k];
            matrix[i, k] = matrix[i, maxNumber];
            matrix[i, maxNumber] = temp;
        }

    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
OrderElements(matrix);
Console.WriteLine("Конечный массив: ");
Print(matrix);