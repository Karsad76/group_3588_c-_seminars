// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число: ");                   // data entry prompt
int input1 = int.Parse(Console.ReadLine() ?? "0");  // console input parsing to int
Console.Write("Введите другое число: ");            // data entry prompt
int input2 = int.Parse(Console.ReadLine() ?? "0");  // console input parsing to int
Console.Write("Введите последнее число: ");         // data entry prompt
int input3 = int.Parse(Console.ReadLine() ?? "0");  // console input parsing to int

Console.WriteLine("Наибольшее число: " + Math.Max((Math.Max(input1, input2)), input3)); // output Max from three