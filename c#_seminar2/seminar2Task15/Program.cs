// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели для проверки рабочий/выходной: "); // data entry prompt
int DayOfWeek = int.Parse(Console.ReadLine() ?? "0");                      // console input parsing to int

if (DayOfWeek >= 1 & DayOfWeek <= 7)   // input range validation
{
    if (DayOfWeek >= 1 && DayOfWeek <= 5) // working day check
    {
        Console.WriteLine("Этот день - рабочий :("); // output if TRUE
    }
    else
    {
        Console.WriteLine("Этот день выходной!"); // output if FALSE
    }
}
else
{
    Console.WriteLine("Это не день недели."); // output if validation wrong
}
