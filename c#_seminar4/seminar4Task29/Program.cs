// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string ReadFromConsole(string msg)    // input data method
{
    Console.Write(msg);
    string inputString = Console.ReadLine() ?? "";
    return inputString;
}

int[] CreateArray(string text) // parsing input string to number and calculate method
{
    text = text.Replace("(", "").Replace(")", "");
    string[] digits = text.Split(",");

    int arrLenght = int.Parse(digits[0]);
    int minValue = int.Parse(digits[1]);
    int maxValue = int.Parse(digits[2]);
    int[] arr = new int[arrLenght];
    arr[0] = minValue;
    arr[1] = maxValue;
    return arr;
}

void FillArray(int[] collection) // random fill array method
{
    int lenght = collection.Length;
    int index = 0;
    int min = collection[0];
    int max = collection[1];

    while (index < lenght)
    {
        collection[index] = new Random().Next(min, max);
        index++;
    }
}

void PrintArray(int[] col)      // print array method
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]); Console.Write(" ");
        position++;
    }
}

void SortSelectionArray(int[] arr)      // sort array method
{
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

string inputLine = ReadFromConsole("Введите параметры массива в виде (длина, минЗначение, максЗначение): ");   //data entry prompt
int[] array = CreateArray(inputLine); // generate array
FillArray(array); // fill array with random values

Console.Clear();
Console.WriteLine("Запрошенный массив:");
Console.WriteLine("===========================================================");
PrintArray(array);

Console.WriteLine();
Console.WriteLine();
SortSelectionArray(array); // sorting array
Console.WriteLine("Отсортированный массив:");
Console.WriteLine("===========================================================");
PrintArray(array);