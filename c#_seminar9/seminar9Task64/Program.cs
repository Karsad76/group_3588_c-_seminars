// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

int n = ReadData("Введите число: ");

string resultLine = RecLineGenerator(n);
PrintData (resultLine);

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

string RecLineGenerator (int num) // method for gathering string via recursion
{
    if (num <= 0) 
    {
        return string.Empty;
    }
    else
    {
    string outLine = num +" " +RecLineGenerator(num-1);
    return outLine;
    }
}



