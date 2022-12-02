// Задача №14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write ("Введите число: ");
int numA = int.Parse(Console.ReadLine()??"0");

int numR1 = numA%7;
int numR2 = numA%23;

if (numR1==0 && numR2==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}