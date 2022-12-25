// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// (*) Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

Console.Clear();
// input data prompt
int rows = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");
Console.WriteLine();

// preparing data
int[,] array2D = Fill2DArray(rows, columns, 0, 99);
ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

// output average for collumns
Console.WriteLine($"Случайный массив целых чисел {rows}x{columns} (раскраска столбцов):");
Print2DArrayColorCollumns(array2D);
Console.WriteLine("Среднее арифметическое по столбцам:");
PrintArrayIndex(CalcAverageForArrayCollumns(array2D));
Print1DArrayColored(CalcAverageForArrayCollumns(array2D), colors);

// output average for diagonals
Console.WriteLine($"Случайный массив целых чисел {rows}x{columns} (раскраска диагоналей):");
Print2DArrayColored(array2D, colors);
Console.WriteLine("Среднее арифметическое по диагоналям:");
PrintArrayIndex(CalcAverageForArrayDiagonals(array2D));
Print1DArrayColored(CalcAverageForArrayDiagonals(array2D), colors);

// METHODS
int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Fill2DArray(int countRow, int countColumn, int minValue, int maxValue) // fill 2d array method via random
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

void Print2DArrayColorCollumns(int[,] matrix) // method for print 2D array with colored collumns 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[j % colors.Length];
            Console.Write(("   ".Substring(matrix[i, j].ToString().Length) + matrix[i, j]));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] CalcAverageForArrayCollumns(int[,] arr) // method for average calculation for every array collumn
{
    double[] averageList = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            averageList[i] += arr[j, i];
        }
        averageList[i] = averageList[i] / arr.GetLength(0);
    }
    return averageList;
}

void PrintArrayIndex(double[] col)      // print array indexes method
{
    int count = col.Length;
    int position = 1;
    Console.Write("|");
    while (position <= (count))
    {
        Console.Write(("_____".Substring(position.ToString().Length) + position) + "|");
        position++;
    }
    Console.WriteLine();
}

void Print2DArrayColored(int[,] arr, ConsoleColor[] colors) // method for print 2D array with colored diagonals
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[(j - i + (arr.GetLength(0) - 1)) % colors.Length];
            Console.Write(("   ".Substring(arr[i, j].ToString().Length) + arr[i, j]));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print1DArrayColored(double[] arr, ConsoleColor[] colors)   // method for print 2D array with color
{
    string arrString = String.Empty;
    Console.Write("|");
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = colors[i % colors.Length];
        Console.Write(arr[i].ToString("00.00")); Console.Write("|");
        Console.ResetColor();
    }
    Console.WriteLine(); Console.WriteLine();
}

double[] CalcAverageForArrayDiagonals(int[,] arr)  // method for average calculation for every array diagonal
{
    // Create a 1D array with length = qty of diagonals
    double[] diagAverages = new double[arr.GetLength(1) + arr.GetLength(0) - 1];

    // calculate diagonals sum
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            diagAverages[j - i + (arr.GetLength(0) - 1)] += arr[i, j];
        }
    }

    // return array with average for every diagonals
    return DivideArrDiagonals(diagAverages, arr.GetLength(0));
}

double[] DivideArrDiagonals(double[] arr, int maxDivider) // submethod for average calculation for every array diagonal 
{
    for (int i = 0; i < arr.Length; i++)
    {
        // calculate the number of elements in a certain diagonal, divide the array element by this number
        int diagSize = Math.Min(Math.Min(i + 1, maxDivider), arr.Length - i);
        arr[i] = Math.Round(arr[i] / diagSize, 2);
    }
    return arr;
}
