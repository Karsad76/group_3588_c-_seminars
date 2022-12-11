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
    text = text.Replace("(", "").Replace(")","");
    string[] digits = text.Split(" ");

    double a = double.Parse(digits[0]);
    double b = double.Parse(digits[2]);
    double result = 0;

    if (digits[1] == "+")
    {
        result = (a + b);
    }
    if (digits[1] == "-")
    {
        result = (a - b);
    }

    if (digits[1] == "*")
    {
        result = (a * b);
    }
if (digits[1] == "/")
    {
        result = (a / b);
    }
if (digits[1] == "^")
    {
        result = Math.Pow(a,b);
    }
    return result;
}

string inputLine = ReadFromConsole("Введите выражение вида (a + b), где действием могут быть (+ - * / ^): ");   // data entry prompt
PrintData((inputLine) + " = " + ParsingStringToNumAndCalculate(inputLine));

