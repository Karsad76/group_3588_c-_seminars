// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// * сравнить быстродействие с вариантом решения через string
using System;
using System.Diagnostics;

long ReadData(string msg) // input data method
{
    Console.Write(msg);
    return long.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

double SumOfDigitsMathMethod(long num)
{
    double qtyOfDigits = Math.Floor(Math.Log10(num) + 1);
    long sumOfDig = 0;
    while (qtyOfDigits >= 1)
    {
        sumOfDig = sumOfDig + num % 10;
        num = num / 10;
        qtyOfDigits = qtyOfDigits - 1;
    }
    return sumOfDig;
}

int SumOfDigitsStringMethod(string s)
{
    int sumOfDigitFromString = 0;
    for (int i = 0; i < s.Length; i++)
    {
        sumOfDigitFromString = sumOfDigitFromString + (Convert.ToInt32(s[i] - 48));
    }
    return sumOfDigitFromString;
}

long inputNum = Math.Abs(ReadData("Введите число: "));  // data entry prompt
string inputNumLine = inputNum.ToString();  // preparing data for String method

Stopwatch sw1 = new Stopwatch();                                                // stopwatch #1 init
sw1.Start();                                                                    // making measurement start
PrintData("Сумма цифр введенного числа = " + SumOfDigitsMathMethod(inputNum));  // calculate via MathMethod and print result
sw1.Stop();                                                                     // making measurement stop
Console.WriteLine($"Время выполнения MathMethod: {sw1.Elapsed}");               // print measurement results
Console.WriteLine();

Stopwatch sw2 = new Stopwatch();                                                        // stopwatch #2 init
sw2.Start();                                                                            // making measurement start                                            
PrintData("Сумма цифр введенного числа = " + SumOfDigitsStringMethod(inputNumLine));    // calculate via StringMethod and print result
sw2.Stop();                                                                             // making measurement stop
Console.WriteLine($"Время выполнения StringMethod: {sw2.Elapsed}");                     // print measurement results
Console.WriteLine();

if (sw1.Elapsed > sw2.Elapsed)   // comparison who is faster 
{ Console.WriteLine("StringMethod быстрее на: " + (sw1.Elapsed - sw2.Elapsed)); }
else { Console.WriteLine("MathMethod быстрее на: " + (sw2.Elapsed - sw1.Elapsed)); }


