// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// (*) При выводе матрицы показывать каждую цифру разного цвета (цветов всего 16).

int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");

double[,] array2D = Fill2DArray(row, columns, 0, 99);
Print2DArrayColor(array2D);

//METHODS
int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] Fill2DArray(int countRow, int countColumn, int minValue, int maxValue)   // method for fill 2d array with double type values
{
    double[,] array2D = new double[countRow, countColumn];
    System.Random rand = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = (rand.NextDouble() + rand.Next(minValue, maxValue));
        }
    }
    return array2D;
}

void Print2DArrayColor(double[,] matrix)   // method for print 2d array with color
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string c = matrix[i, j].ToString("00.0000");     // print every digit in random color
            for (int s = 0; s < c.Length - 1; s++)
            {
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(c[s]);
                Console.ResetColor();
                Thread.Sleep(1);
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




