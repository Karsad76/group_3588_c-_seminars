//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Получаем данные с консоли
Console.Write("Введите число: ");
string? inputLine1 = Console.ReadLine();
Console.Write("Введите другое число: ");
string? inputLine2 = Console.ReadLine();

// Проверяем на пустые строки
if (inputLine1 != null && inputLine2 != null)
{
    // Парсим в числа
    int num1 = int.Parse(inputLine1);
    int num2 = int.Parse(inputLine2);

    // Проверяем первое на квадрат второго
    if (num1 == num2 * num2)
    {
        // Вывод TRUE
        Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
        // Вывод FALSE
        Console.WriteLine("Первое число НЕ квадрат второго");
    }
}
