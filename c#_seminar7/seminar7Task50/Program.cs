// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание, что такого элемента нет.
// (*) Заполнить числами Фиббоначи и выделить цветом найденную цифру

string elementIndexLine = ReadFromCons("Введите индекс элемента в массиве 7х6 в формате (1,2): ");
int[,] array = Fill2DArray(7, 6);
(int x, int y) index = getIndexFromStringLine(elementIndexLine);

if (index.x < array.GetLength(0) && index.y < array.GetLength(1))
{
    PrintData("Значение элемента с запрошенным индексом: ", array[index.x, index.y]);
    Print2DArrayColor(array, index.x, index.y);
}
else
{
    Console.WriteLine("Элемента с запрошенным индексом в массиве нет");
}

//METHODS
int[,] Fill2DArray(int countRow, int countColumn)   // fill 2d array method
{
    int[,] array2D = new int[countRow, countColumn];
    int currentFibNum = 1;
    int previosFibNum = 0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = currentFibNum;
            int temp = currentFibNum;
            currentFibNum = currentFibNum + previosFibNum;
            previosFibNum = temp;
        }
    }
    return array2D;
}

void Print2DArrayColor(int[,] matrix, int index0, int index1)   // method for print 2d array with color
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == index0 && j == index1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("          ".Substring(matrix[i, j].ToString().Length) + matrix[i, j]);
                Console.ResetColor();
            }
            else
            {
                Console.Write("          ".Substring(matrix[i, j].ToString().Length) + matrix[i, j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintData(string res, int value)   // print data method
{
    Console.Clear();
    Console.Write(res);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(value);
    Console.ResetColor();
    Console.WriteLine();
}

string ReadFromCons(string msg)    // input data method
{
    Console.Write(msg);
    string inputString = Console.ReadLine() ?? "";
    return inputString;
}

(int x, int y) getIndexFromStringLine(string text)  // method for parcing index from input string
{
    text = text.Replace("(", "").Replace(")", "");
    string[] digits = text.Split(",");

    int x = int.Parse(digits[0]) - 1;
    int y = int.Parse(digits[1]) - 1;
    return (x, y);
}