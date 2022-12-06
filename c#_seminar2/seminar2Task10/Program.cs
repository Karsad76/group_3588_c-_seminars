// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите любое трехзначное число: ");     // data entry prompt
int numA = int.Parse(Console.ReadLine() ?? "0");        // console input parsing to int

if (Math.Abs(numA)>99 & Math.Abs(numA)<1000)            // input range validation
{
    Console.WriteLine(Math.Abs((numA%100-numA%10)/10)); // output second digit of input if TRUE
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число. Попробуйте еще раз."); // output if FALSE
}