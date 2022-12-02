// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным
// первому. Если второе число некратно первому, то программа выводит о статок от деления.

Console.Write ("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()??"0");

Console.Write ("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()??"0");

int numR = numB%numA;

if (numR==0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число НЕ кратно первому");
}



int number1 = int.Parse(Console.ReadLine()??"0");
//Console.WriteLine(number1);

int number2 = int.Parse(Console.ReadLine()??"0");
//Console.WriteLine(number2);

int result = number2%number1;

if (result == 0)
{
    Console.WriteLine("Второе число делится на первое без остатка");
}
else
{
    Console.WriteLine("Второе число не крастно первому. Остаток от деления " + result);
}
