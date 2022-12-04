// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// taking console input
Console.Write("Введите число: ");
string? num1Line = Console.ReadLine();
Console.Write("Введите другое число: ");
string? num2Line = Console.ReadLine();

// null string check
if (num1Line != null && num2Line != null)
{
    // parsing to int
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    // compare who is max
    if (num1 > num2)
    {
        // output TRUE
        Console.WriteLine(num1 + " больше чем " + num2);
    }
    else
    {
        // output FALSE
        Console.WriteLine(num2 + " больше чем " + num1);
    }
}