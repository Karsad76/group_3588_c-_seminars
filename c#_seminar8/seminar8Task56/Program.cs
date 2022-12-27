// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
// input data prompt
int rows = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");
Console.WriteLine();

// preparing data
int[,] array2D = Fill2DArray(rows, columns, 10, 100);
(int index, int sum) minRow = CalcSumForArrayRows(array2D);

// output result
Console.WriteLine($"Минимальная сумма элементов = {minRow.sum} в строке {minRow.index + 1}");
Print2DArrayRowColored(array2D, minRow.index);

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

void Print2DArrayRowColored(int[,] matrix, int indexRow) // method for print 2D array with colored row 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == indexRow)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(("   ".Substring(matrix[i, j].ToString().Length) + matrix[i, j]));
                Console.ResetColor();
            }
            else
            {
                Console.Write(("   ".Substring(matrix[i, j].ToString().Length) + matrix[i, j]));
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

(int x, int y) CalcSumForArrayRows(int[,] arr) // method for sum calculation for every array row
{
    int minRowSum = int.MaxValue;
    int indexMinRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumValuesCurrentRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumValuesCurrentRow += arr[i, j];
        }

        if (sumValuesCurrentRow < minRowSum)
        {
            minRowSum = sumValuesCurrentRow;
            indexMinRow = i;
        }
    }
    return (indexMinRow, minRowSum);
}

