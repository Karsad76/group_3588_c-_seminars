// Задача 24. Напишите программу, которая принимает из консоли число и выводит в консоль сумму чисел от 1 до введенного

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

int SumOfNumbersSimpleMethod (int input1) // Calc sum of numbers from 1 to N simple method
{
    int sumOfNumbers = 0;
    for (int  i=1; i<=input1; i++)
    {
        sumOfNumbers+=i;
    }
    return sumOfNumbers;
}

int num1 = ReadData("Введите число: ");

DateTime d1 = DateTime.Now; // take start algorithm time
PrintData("Сумма чисел от 1 до "+num1+" (простой метод): "+SumOfNumbersSimpleMethod(num1));
Console.WriteLine ("Время выполнения: "+(DateTime.Now - d1)); // calculate execution time

int SumOfNumbersGaussMethod (int input1)    // Calc sum of numbers from 1 to N Gausse method
{
    int sumOfNumbers1 = 0;
    sumOfNumbers1 = (((1+input1)*input1)/2);
    return sumOfNumbers1;
}

DateTime d2 = DateTime.Now; // take start algorithm time
PrintData("Сумма чисел от 1 до "+num1+" (метод Гаусса): "+SumOfNumbersGaussMethod(num1));
Console.WriteLine ("Время выполнения: "+(DateTime.Now - d2));   // calculate execution time