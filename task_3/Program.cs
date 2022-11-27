// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Кубы чисел от 1 до {num}:");
    for (int i = 1; i <= num; i++)
    {
        int result = i * i * i;
        Console.Write($"{result} ");
    }
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}
