// Задача №55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int row = ReadData("Введите кол-во строк массива: ");
int columns = ReadData("Введите кол-во столбцов массива: ");

int[,] array2D = Fill2DArray(row, columns, 0, 99);
Print2DArray(array2D);
if (TransporationTest(array2D)==true) Transporation2DArray(array2D);
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

bool TransporationTest(int[,] matrix) // method for checking array transporation compatability (qty of rows = qty of collumns)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("не возможно развернуть");
        return false;
    }
}

void Transporation2DArray(int[,] matrix) // trasporation 2D array method (rows --> collumns)
{
    int buffer;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            buffer = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = buffer;
        }
    }
}
