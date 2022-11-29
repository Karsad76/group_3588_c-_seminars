// Задача №0. Напишите программу, которая на вход принимает число и выдаёт его квадрат

// Считываем число с консоли
string? inputLine=Console.ReadLine();

// Проверяем ввод на пустую строку
if(inputLine!=null)
{
    // Парсим строку в число
    int inputNumber=int.Parse(inputLine);

    //Находим квадрат числа
    int outResult = inputNumber * inputNumber;

    //Вариант 2 int outResult = (int)Math.Pow(num1,2);

    //Выводим результат
    Console.WriteLine(outResult);
}