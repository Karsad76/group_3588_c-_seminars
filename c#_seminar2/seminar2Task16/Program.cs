// Задача №16. Напишите программу, которая принимает на вход два числа и проверяет, являетсяли одно число квадратом другого.

// ВАРИАНТ 1
Console.Write ("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()??"0");

Console.Write ("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()??"0");

 if(numA/numB==numB)
 {
    Console.WriteLine("Первое число квадрат второго");
 }
 else
 {
    if (numB/numA==numA)
    {
        Console.WriteLine("Второе число квадрат первого");
    }
    else
    {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }
 }

// // ВАРИАНТ 2
Console.WriteLine("является ли одно число квадратом другого ?");
Console.Write("Введите первое число: ");
int firstNumber;
bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
validate(isNumber);

Console.Write("Введите второе число: ");
int secondNumber;
isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
validate(isNumber);

Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

void validate(bool isNumber){
    if (!isNumber){
        Console.WriteLine("Вы ввели не число, выход");
        Environment.Exit(0);
    }
}

bool isSqrt(int a, int b){
    return (a*a == b) || (b*b == a) ;
}

// ВАРИАНТ 3
void TestSqrt(int a1, int a2)
{
    bool result = (a1/a2==a2);

    if (result==true)Console.WriteLine(" Число "+a1+" является квадратом числа "+a2);
    else Console.WriteLine(" Число "+a1+" не является квадратом числа "+a2);
}


Console.Write ("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.Write ("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()??"0");
TestSqrt (num1, num2);
TestSqrt (num2, num1);