// Задача №44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

string FibNum(int a)        // fibbonacci line constructor
{
    string fibNumLine = "0 1 ";
    long first = 0;
    long second = 1;
    long buffer = 0;

    for (int i = 2; i < a; i++)
    {
        fibNumLine = fibNumLine + (first+second).ToString() + " ";
        buffer=first+second;
        first=second;
        second=buffer;
    }
    return fibNumLine;
}

int lenghtOfFibLine = ReadData ("Введите кол-во чисел для вывода: ");
PrintData ("Последовательность Фиббоначи из "+lenghtOfFibLine+" чисел: "+FibNum (lenghtOfFibLine));