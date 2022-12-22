// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// (*) Пользователь вводит с клавиатуры любую последовательность символов в кол-ве М. Программа должна распознать
// все положительные числа в последовательности.

using System;
using System.Text.RegularExpressions;

int qtyOfTaps = ReadData("Укажите количество символов для ввода: ");    // data input prompt
string tapsSequence = ReadStringLine("Введите любые символы с клавиатуры: ");   // data input prompt
TakePositiveNumsFromInputString(tapsSequence);  // find numbers via Regex method

// METHODS
int ReadData(string msg)    // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadStringLine(string txt)   // input string method
{
    Console.Write(txt);
    string s = String.Empty;
    for (int i = 0; i < qtyOfTaps; i++)
    {
        var key = Console.ReadKey(false); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
        s = s + String.Format(key.KeyChar.ToString());// + ","; 
    }
    Console.WriteLine();
    return s;
}

void TakePositiveNumsFromInputString(string str)    // Regex method for take all positive numbers from string
{
    Regex regex = new Regex(@"(?<!-\d*)\d+");   // Regex pattern init
    MatchCollection matches = regex.Matches(str);  
    int posNums = 0;
    if (matches.Count > 0) 
    {
        Console.Write("Введенные положительные числа: ");

        foreach (Match match in matches)    // output finded numbers and counting of that
        {
            Console.Write($"[{match.Value}] ");
            posNums = posNums + 1;
        }
        Console.WriteLine();
        Console.WriteLine($"Всего положительных чисел: {posNums}");
    }
    else
    {
        Console.WriteLine("Чисел не найдено");
    }
}
