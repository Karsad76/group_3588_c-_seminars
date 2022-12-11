// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int inputNum = ReadData("Введите число: ");         // input number
int numSt = ReadData("Введите степень числа: ");    // input degree of number 

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

string LineBuilder(int arg, int pow)    // line constructor method
{
    string line = String.Empty;

    for (int i = 1; i < arg; i++)
    {
        line = line + Math.Pow(i, pow) + " ";
    }
    line = line + Math.Pow(arg, pow);

    return line;
}

PrintData(LineBuilder(inputNum, 1));        // output line of numbers from 1 to inputNum
PrintData(LineBuilder(inputNum, numSt));    // output line of degrees of numbers from 1 to inputNum
