//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Получаем данные с консоли
string? inputLine=Console.ReadLine();

// Проверяем на пустую строку
if(inputLine!=null)
{
    // Парсим в число
    int inputNumber=int.Parse(inputLine);
    
    // Находим отрицательное значение
    int startNumber=inputNumber*(-1);

    // Присваиваем результату пустую строку
    string outLine=string.Empty;

    // Цикл по условию
    while(startNumber<inputNumber)
    {
        // Собираем результат и двигаем счетчик цикла
        outLine=outLine+startNumber+", ";
        startNumber++;
    }

    // Добавляем к результату введенное число
    outLine=outLine+inputNumber;

    // Вывод результата
    Console.WriteLine(outLine);
}
