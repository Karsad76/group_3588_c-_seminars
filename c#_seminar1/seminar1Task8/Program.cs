// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число больше 1: ");    // data entry prompt
int end = int.Parse(Console.ReadLine() ?? "0");             // console input parsing to int
int count = 2;                                              // counter initialising
string resultString = string.Empty;                         // result string initialising

if (end > 1)                                                // correct console input checking
{
    while (count < (end - 1))                               // conditional cycle
    {
        if (count % 2 == 0)                                 // counter parity check
        {
            resultString = (resultString + count + ", ");   // collect result string
        }
        count = count + 2;                                  // counter+
    }
    Console.WriteLine(resultString + count);                // output if TRUE
}

else
{
    Console.WriteLine("Число меньше 2");                    // output if FALSE
}

