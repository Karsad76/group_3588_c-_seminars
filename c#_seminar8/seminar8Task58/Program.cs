// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
// input data prompt
int rows = ReadData("Введите кол-во строк массивов: ");
int columns = ReadData("Введите кол-во столбцов массивов: ");
Console.WriteLine();

// preparing data
int[,] array1 = Fill2DArray(rows, columns, 0, 10);
int[,] array2 = Fill2DArray(rows, columns, 0, 10);

// output results
Console.WriteLine($"Матрица №1");
Print2DArray(array1);
Console.WriteLine($"Матрица №2");
Print2DArray(array2);
Console.WriteLine($"Произведение матриц");
Console.ForegroundColor = ConsoleColor.Green;
Print2DArray(MatrixMultiplication(array1, array2));
Console.ResetColor();

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

void Print2DArray(int[,] matrix) // method for print 2D array 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(("     ".Substring(matrix[i, j].ToString().Length) + matrix[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2) // method for matrix multiplication
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixResult;
}



