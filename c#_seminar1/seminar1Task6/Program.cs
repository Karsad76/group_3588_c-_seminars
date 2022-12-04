// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");                   // data entry prompt
int a1 = int.Parse(Console.ReadLine() ?? "0");  // console input parsing to int

if (a1%2 == 0)  // check parity
{
    Console.WriteLine("Введенное число - четное");  // output if TRUE
}
else
{
    Console.WriteLine("Введенное число - нечетное");    // output if FALSE
}