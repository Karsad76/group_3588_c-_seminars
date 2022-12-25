// Задача 67. Примает на вход число и возвращает сумму цифр в числе

int num = ReadData("Введите число: ");

int result = RecSumOfDigits(num);
PrintData("Сумма цифр в числе: "+ result);

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

int RecSumOfDigits(int num) // method for calc sum of digits via recursion
{
    if (num < 10)
    {
        return num; ;
    }
    else
    {
        return num % 10 + RecSumOfDigits(num / 10);
    }
}
