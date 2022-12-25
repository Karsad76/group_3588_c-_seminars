//  Задача 65. Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

int m = ReadData("Введите число: ");
int n = ReadData("Введите число: ");

string resultLine = m < n ? ReccurentLineGenerator(m, n) : ReccurentLineGenerator(n, m);
PrintData(resultLine);

// METHODS
int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

string ReccurentLineGenerator(int m, int n) // method for gathering string via recursion
{
    string outRes = string.Empty;

    if (m >= n)
    {
        return outRes + n;
    }
    else
    {
        string outLine = m + " " + ReccurentLineGenerator(m + 1, n);
        return outLine;
    }
}