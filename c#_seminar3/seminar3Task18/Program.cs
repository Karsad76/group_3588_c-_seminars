// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int quat = ReadData("Введите номер четверти: ");

void PrintConditionForQuater(int num)
{
    if (num == 1) Console.WriteLine("X > 0, Y > 0");
    if (num == 2) Console.WriteLine("X > 0, Y < 0");
    if (num == 3) Console.WriteLine("X < 0, Y < 0");
    if (num == 4) Console.WriteLine("X < 0, Y > 0");
}
PrintConditionForQuater (quat);