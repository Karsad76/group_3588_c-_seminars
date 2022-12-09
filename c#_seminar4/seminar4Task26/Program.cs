// Задача №26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

int CountDigitInNumberSimpleMethod(int num) // count the digits in a number simple method
{
    int res = 0;
    while (num > 1)
    {
        num = num / 10;
        res++;
    }
    return res;
}

int CountDigitInNumberLog10Method(int num)  // count the digits in a number Log10 method
{
    int res = (int)Math.Log10(num) + 1;
    return res;
}

int VariantString(int num)  // count the digits in a number string method
{
    int count = num.ToString().Length;
    return count;
}

int number1 = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;     // take start algorithm time
PrintData("Кол-во цифр в числе " + number1 + " (простой метод): " + CountDigitInNumberSimpleMethod(number1));
Console.WriteLine(DateTime.Now - d1);   // calculate execution time

DateTime d2 = DateTime.Now;     // take start algorithm time
PrintData("Кол-во цифр в числе " + number1 + " (метод Log10): " + CountDigitInNumberLog10Method(number1));
Console.WriteLine(DateTime.Now - d2);   // calculate execution time

DateTime d3 = DateTime.Now;     // take start algorithm time
PrintData("Кол-во цифр в числе " + number1 + " (метод String): " + VariantString(number1));
Console.WriteLine(DateTime.Now - d3);   // calculate execution time
