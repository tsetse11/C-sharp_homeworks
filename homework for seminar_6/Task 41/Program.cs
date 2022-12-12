// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0, number = 0;
string result = String.Empty;
for (int i = 1; i < M + 1; i++)
{
    Console.Write($"Введите {i} число: ");
    number = Convert.ToInt32(Console.ReadLine());
    {
    if(i == 1)
        result += number.ToString() + ",";
    else if(i == M)
        result += " " + number.ToString();
    else result += " " + number.ToString() + ",";
    }
    if(number > 0)
        count++;    
}
Console.Write($"\nКоличество чисел больше 0: {count} ");