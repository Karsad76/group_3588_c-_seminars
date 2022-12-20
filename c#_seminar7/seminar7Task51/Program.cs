// Задача №51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");

int[,] array2D = Fill2DArray(row, columns, 0, 99);
Print2DArrayColor(array2D);
PrintData("Сумма элементов по короткой диагонали равна: " + CalcDiagonal2DArray(array2D));


int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Fill2DArray(int countRow, int countColumn, int minValue, int maxValue)   // fill 2d array method
{
    int[,] array2D = new int[countRow, countColumn];
    System.Random rand = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return array2D;
}

void Print2DArrayColor(int[,] matrix)   // method for print 2d array with color
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
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintData(string msg)   // print data method
{
    Console.WriteLine(msg);
}

int CalcDiagonal2DArray(int[,] matrix)  // methods for calculation sum of elements on main diagonal of array
{
    int res = 0;
    int minMeasurement = matrix.GetLength(0) < matrix.GetLength(1) ?
                        matrix.GetLength(0) : matrix.GetLength(1);

    for (int i = 0; i < minMeasurement; i++)
    {
        res = res + matrix[i, i];
    }
    return res;
}