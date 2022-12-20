// Задача №48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");

int[,] array2D = Fill2DArrayIndexed(row, columns);
Print2DArray(array2D);

// METHODS
int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Fill2DArrayIndexed(int countRow, int countColumn)    // method for fill 2d array with index multiplication
{
    int[,] array2D = new int[countRow, countColumn];
    System.Random rand = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = i + j;
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
}






