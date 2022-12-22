// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// (*) Найдите площадь треугольника образованного пересечением 3 прямых (y = k3 * x + b3)

string newArg = ReadFromConsole("Введите значения К и В для трех уравнений в формате К(1,2,3), B(1,2,3): ").ToString();
double k1, k2, k3, b1, b2, b3;  // global variables for equation arguments init
double x1, x2, x3, y1, y2, y3;  // global variables for points coordinates of intersection of lines init

ParsingStringToDouble(newArg);  // parsing equation arguments from input string
PointIntersectionCoordsFind(k1, b1, k2, b2, k3, b3);    // finding points coordinates of intersection of lines

double sideA = LenghtOfSegmentCalc(x1, y1, x2, y2);     // calculating the length of triangle sides
double sideB = LenghtOfSegmentCalc(x2, y2, x3, y3);
double sideC = LenghtOfSegmentCalc(x3, y3, x1, y1);

PrintData($"Координаты точек пересечения прямых: ({x1.ToString("0.000")}, {y1.ToString("0.000")}), ({x2.ToString("0.000")}, {y2.ToString("0.000")}), ({x3.ToString("0.000")}, {y3.ToString("0.000")})");
PrintData($"Длины сторон треугольника: сторона A = {sideA.ToString("#.000")}; сторона B = {sideB.ToString("#.000")}, сторона C = {sideC.ToString("#.000")}");
PrintData($"Площадь треугольника S = {TriangleAreaCalc(sideA, sideB, sideC).ToString("#.000")}");

string ReadFromConsole(string msg)    // input data method
{
    Console.Write(msg);
    string inputString = Console.ReadLine() ?? "";
    return inputString;
}

void ParsingStringToDouble(string text) // parsing numbers from input string to double
{
    text = text.Replace("K", "").Replace("B", "").Replace("(", "").Replace(")", "").Replace(" ", "").Replace("К", "").Replace("В", "");
    string[] digits = text.Split(",");

    k1 = double.Parse(digits[0]);
    k2 = double.Parse(digits[1]);
    k3 = double.Parse(digits[2]);
    b1 = double.Parse(digits[3]);
    b2 = double.Parse(digits[4]);
    b3 = double.Parse(digits[5]);
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

void PointIntersectionCoordsFind(double argK1, double argB1, double argK2, double argB2, double argK3, double argB3) // method for finding points coordinates of intersection of lines
{
    x1 = (argB2 - argB1) / (argK1 - argK2);
    y1 = (argK1 * argB2 - argK2 * argB1) / (argK1 - argK2);
    x2 = (argB3 - argB2) / (argK2 - argK3);
    y2 = (argK2 * argB3 - argK3 * argB2) / (argK2 - argK3);
    x3 = (argB1 - argB3) / (argK3 - argK1);
    y3 = (argK3 * argB1 - argK1 * argB3) / (argK3 - argK1);
}

double LenghtOfSegmentCalc(double coordX1, double coordY1, double coordX2, double coordY2)     // method for calculating the length of a segment
{
    double result = Math.Sqrt(Math.Pow((coordX1 - coordX2), 2) + Math.Pow((coordY1 - coordY2), 2));
    return result;
}

double TriangleAreaCalc(double a, double b, double c)     // method for calculating the area of a triangle
{
    double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
    return squareT;
}