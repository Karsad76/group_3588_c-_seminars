// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// ПРОСТОЙ ВАРИАНТ
// Data input
// Console.Write("Введите координату X: ");
// int coordX = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите координату Y: ");
// int coordY = int.Parse(Console.ReadLine() ?? "0");

// if (coordX>0 &&coordY>0) Console.WriteLine("Это координата первой четверти");
// if (coordX>0 &&coordY<0) Console.WriteLine("Это координата второй четверти");
// if (coordX<0 &&coordY<0) Console.WriteLine("Это координата третьей четверти");
// if (coordX<0 &&coordY>0) Console.WriteLine("Это координата четвертой четверти");

// ВАРИАНТ С МЕТОДАМИ

int ReadData(string msg)    // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int x = ReadData("Введите координату X: "); // input x
int y = ReadData("Введите координату Y: "); // input y

void PrintQuaterTest()  // find quater method
{
    if (x > 0 && y > 0) Console.WriteLine("Это координата первой четверти");
    if (x > 0 && y < 0) Console.WriteLine("Это координата второй четверти");
    if (x < 0 && y < 0) Console.WriteLine("Это координата третьей четверти");
    if (x < 0 && y > 0) Console.WriteLine("Это координата четвертой четверти");
}

PrintQuaterTest(); // output





