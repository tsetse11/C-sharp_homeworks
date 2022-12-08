// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
int Factorial(int a, int b)
{
    int result = 1;
    
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую необходимо возвести число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Factorial(num1, num2));
