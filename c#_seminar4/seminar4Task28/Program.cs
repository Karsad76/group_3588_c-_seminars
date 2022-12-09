// Задача №28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

int CalculationFactorial(int input1) // factorial calculation method
{
    int count = 1;
    for (int i = 1; i <= input1; i++)
    {
        count *= i;
    }
    return count;
}

int number1 = ReadData("Введите число: ");
PrintData("Факториал "+number1+" равен: "+CalculationFactorial(number1));
