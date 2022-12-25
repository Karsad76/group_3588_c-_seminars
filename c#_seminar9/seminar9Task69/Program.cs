// Задача 69. Напишите прграмму, которая будет принимать 2 числа А и В возведите А в степень В с помощью рекурсии

int numA = ReadData("Введите число: ");
int numB = ReadData("Введите число: ");

long result = RecPow(numA, numB);
PrintData("Число в степени: " + result);

long result2 = MyPow(numA, numB);
PrintData("Число в степени: " + result2);

// METHODS
int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

long RecPow(int num1, int num2) // method for pow via recursion
{
    if (num2 <= 1) return num1;
    return num1 * RecPow(num1, num2 - 1);
}

long MyPow(int num1, int num2)  // method for pow via recursion
{
    if (num2 == 2) return num1 * num1;
    return MyPow(num1, num2 / 2) * MyPow(num1, num2 / 2);
}