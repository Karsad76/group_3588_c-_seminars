// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// * сделать калькулятор для 4х действий + возведение в степень

string ReadFromConsole(string msg)    // input data method
{
    Console.Write(msg);
    string inputString = Console.ReadLine() ?? "";
    return inputString;
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

double ParsingStringToNumAndCalculate(string text) // parsing input string to number and calculate method
{
    text = text.Replace("(", "").Replace(")", "");
    string[] digits = text.Split(" ");

    double a = double.Parse(digits[0]);
    double b = double.Parse(digits[2]);
    double result = 0;

    if (b == 0 && digits[1] == "/") Console.WriteLine("Недопустимая операция: деление на 0");
    switch (digits[1])
    {
        case "+": return result = (a + b);
        case "-": return result = (a - b);
        case "*": return result = (a * b);
        case "/": return result = (a / b);
        case "^": return result = Math.Pow(a, b);
        default:
            Console.WriteLine("Недопустимая операция");
            return 0;
    }
}

string inputLine = ReadFromConsole("Введите выражение вида (a + b), где действием могут быть (+ - * / ^): ");   // data entry prompt
PrintData((inputLine) + " = " + ParsingStringToNumAndCalculate(inputLine));

