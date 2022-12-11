// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

string ReadFromConsole(string msg)    // input data method
{
    Console.Write(msg);
    string inputString = Console.ReadLine() ?? "";
    return inputString;
}

double ParsingStringToIntAndCalculateDistance(string text) // parsing points coordinates from input string to Int and calculate dist with LenghtCalc method
{
    text = text.Replace("A", "").Replace("B", "").Replace("(", "").Replace(")", "").Replace(" ", "").Replace("А", "").Replace("В", "");
    string[] digits = text.Split(",");

    int x1 = int.Parse(digits[0]);
    int y1 = int.Parse(digits[1]);
    int z1 = int.Parse(digits[2]);
    int x2 = int.Parse(digits[3]);
    int y2 = int.Parse(digits[4]);
    int z2 = int.Parse(digits[5]);

    double distanceBetweenPoints = LenghtCalc(x1, y1, z1, x2, y2, z2);

    return distanceBetweenPoints;
}

double LenghtCalc(int x1, int y1, int z1, int x2, int y2, int z2)   // lenght calculate method
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

void PrintData(string msg, double result)   // print data method
{
    Console.WriteLine(msg + result);
}

string newPoints = ReadFromConsole("Введите координаты двух точек в формате A(1,2,3), B(1,2,3): ").ToString();
PrintData("Расстояние между точками: ", ParsingStringToIntAndCalculateDistance(newPoints));