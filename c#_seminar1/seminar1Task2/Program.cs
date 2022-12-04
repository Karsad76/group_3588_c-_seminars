// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число: ");                   // data entry prompt
int num1 = int.Parse(Console.ReadLine() ?? "0");    // console input parsing to int
Console.Write("Введите другое число: ");            // data entry prompt
int num2 = int.Parse(Console.ReadLine() ?? "0");    // console input parsing to int

if (num1 == num2)                           // "num1 = num2" variant checking
{
    Console.WriteLine(num1+" = "+num2);     // output if TRUE
}
else
{
    Console.WriteLine(Math.Max(num1, num2) + " больше чем " + Math.Min(num1, num2));    //output if FALSE
}