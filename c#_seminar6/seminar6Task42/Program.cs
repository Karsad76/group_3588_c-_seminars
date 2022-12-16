// Задача №42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int input = ReadData("Введите число: ");
PrintData("В двоичной системе " + input + " будет: " + DecToBin(input));
PrintData("В двоичной системе " + input + " будет: " + DegToBinNew(input));
PrintData("В восьмеричной системе " + input + " будет: " + Convert.ToString(input, 8));
PrintData("В шестнадцатиричной системе " + input + " будет: " + Convert.ToString(input, 16));

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

string DecToBin(int num)    // convert decimal to binary via C# internal method
{
    return Convert.ToString(num, 2);
}

string DegToBinNew(int num) // convert decimal to binary method
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}
