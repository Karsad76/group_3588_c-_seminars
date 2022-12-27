// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

int result = m < n ? RecSumOfNumbers(m, n) : RecSumOfNumbers(n, m);
PrintData($"Сумма натуральных элементов на отрезке {m}...{n} = {result}");

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

int RecSumOfNumbers(int num1, int num2) // method for calc sum of numbers subsequence via recursion
{
    int sum = num1;
    if (num1 >= num2)
    {
        return sum;
    }
    else
    {
        sum = sum + RecSumOfNumbers(num1 + 1, num2);
        return sum;
    }
}

