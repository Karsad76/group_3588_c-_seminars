// Задача 7.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Получаем число из консоли
string? inputLine = Console.ReadLine();

// Проверяем на пустую строку
if (inputLine != null)
{

// Парсим в число
int inputNumber = int.Parse(inputLine);

// Ищем остаток от деления на 10
int lastDigit = inputNumber % 10;

// Вывод
Console.WriteLine(lastDigit);
}
