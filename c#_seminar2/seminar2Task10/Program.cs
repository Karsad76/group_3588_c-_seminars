// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число от 100 до 999: ");     // data entry prompt
int numA = int.Parse(Console.ReadLine() ?? "0");    // console input parsing to int

if (numA>99 & numA<1000)
{
    Console.WriteLine((numA%100-numA%10)/10);       // output second digit of input if TRUE
}
else
{
    Console.WriteLine("Вы ввели число не из диапазона 100-999. Попробуйте еще раз."); // output if FALSE
}