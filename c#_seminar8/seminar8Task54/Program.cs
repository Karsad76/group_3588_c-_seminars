// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");
Console.WriteLine();

int[,] array2D = Fill2DArray(row, columns, 10, 100);

Console.WriteLine ("Случайный массив: ");
Print2DArray(array2D);
SortRows2DArray(array2D);
Console.WriteLine ("Массив, отсортированный по строкам: ");
Print2DArray(array2D);

//METHODS
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

void Print2DArray(int[,] matrix)    // method for print 2d array
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRows2DArray(int[,] matrix) // method for sort values for every row in 2D array
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int a = j + 1; a < matrix.GetLength(1); a++)
            {
                if (matrix[i, j] < matrix[i, a])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, a];
                    matrix[i, a] = temp;
                }
            }
        }
    }
}