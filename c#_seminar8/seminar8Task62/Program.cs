// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

// input data prompt
int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");

// preparing data
int[,] array2D = new int[row, columns];
int[,] array2Dsecond = new int[row, columns];

// output result
Console.WriteLine();
Console.WriteLine("Массив заполненный по и против часовой стрелки:");
Console.WriteLine();
Print2DArray(Fill2DArrSpiral(array2D), Fill2DArrSpiralCounterClockwise(array2Dsecond));

// METHODS
int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Fill2DArrSpiral(int[,] matrix, int startNumber = 1, int count = 1)   //method for filling array clockwise
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        Fill2DArrSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}

void Print2DArray(int[,] matrix, int[,] matrix2)    // method for print 2d array
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        string outline = "";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            outline = outline + "   ".Substring(matrix[i, j].ToString().Length) + matrix[i, j].ToString();
        }
        outline = outline + "   ";
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            outline = outline + "   ".Substring(matrix2[i, k].ToString().Length) + matrix2[i, k].ToString();
        }
        Console.WriteLine(outline);
    }
    Console.WriteLine();
}

int[,] Fill2DArrSpiralCounterClockwise(int[,] matrix, int startNumber = 1, int count = 1) //method for filling array counterclockwise
{
    for (int j = -1 + count; j < matrix.GetLength(0) + 1 - count; j++)
    {
        matrix[j, -1 + count] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(1) + 1 - count; i++)
    {
        matrix[matrix.GetLength(1) - count, i] = startNumber++;
    }
    for (int j = matrix.GetLength(0) - 1 - count; j > -1 + count; j--)
    {
        matrix[j, matrix.GetLength(0) - count] = startNumber++;
    }
    for (int i = matrix.GetLength(1) - count; i > -1 + count; i--)
    {
        matrix[-1 + count, i] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        Fill2DArrSpiralCounterClockwise(matrix, startNumber, ++count);
    }
    return matrix;
}