// Задача №59. Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");

int[,] array2D = Fill2DArray(row, columns, 0, 99);
Print2DArray(array2D);
Console.WriteLine();
(int x, int y) minElement = SearchMinElementIn2DArray(array2D);
int[,] out2DArr = Convert2DArray(array2D, minElement.x, minElement.y);
Print2DArray(out2DArr);

// METHODS
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

(int x, int y) SearchMinElementIn2DArray(int[,] matrix) // method for searching minValue element in 2D array
{
    int row = 0;
    int collumn = 0;
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                collumn = j;
            }
        }
    }
    return (row, collumn);
}

int[,] Convert2DArray(int[,] arr, int x, int y) // method for delete row&collumn with minValue element from 2D array
{
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0; int m = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                outArr[k, m] = arr[i, j];
            }
            if (j != y) m++;
        }
        if (i != x) k++;
    }
    return outArr;
}






