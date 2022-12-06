// Задача №20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int ReadData(string msg)    // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int x2 = ReadData("Введите координату Х точки Б: ");
int y2 = ReadData("Введите координату Y точки Б: ");

double LenghtCalc(int x1, int y1, int x2, int y2)   // lenght calculate method
{
    double result = 0;
    result = Math.Sqrt((x1 - x2) + (y1 - y2)*(y1 - y2));
    return result;
}

void PrintData(string msg, double result)   // print data method
{
    Console.WriteLine(msg + result);
}

PrintData ("Расстояние между точками: ", LenghtCalc(x1, y1, x2, y2));