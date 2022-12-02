// Задача №14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write ("Введите число: ");
int numA = int.Parse(Console.ReadLine()??"0");

if (numA%7==0 && numA%23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}