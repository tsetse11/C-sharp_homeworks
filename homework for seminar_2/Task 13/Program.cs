// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99)
    Console.Write((a / 10) % 10);
    if (a > 9999)
        Console.Write((a / 100) % 10);
else
    Console.Write("Третьей цифры нет");
    

    
