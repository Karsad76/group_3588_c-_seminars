// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int minValueForRandom = 0;
int maxValueForRandom = 0;

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
    minValueForRandom = int.Parse(digits[1]);
    maxValueForRandom = int.Parse(digits[2]);
    int[] arr = new int[arrLenght];
    // arr[0] = minValue;
    // arr[1] = maxValue;
    return arr;
}

void FillArray(int[] collection, int minValue, int maxValue) // random fill array method
{
    int lenght = collection.Length;
    int index = 0;
    
    while (index < lenght)
    {
        collection[index] = new Random().Next(minValue, maxValue);
        index++;
    }
}

void PrintArray(int[] col)      // print array method
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < (count - 1))
    {
        Console.Write(col[position]); Console.Write(", ");
        position++;
    }
    Console.Write((col[count - 1]) + "]");
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

string inputLine = ReadFromConsole("Введите параметры для генерации массива в виде (длина, минЗначение, максЗначение): ");   //data entry prompt
int[] array = CreateArray(inputLine); // generate array
FillArray(array, minValueForRandom, maxValueForRandom); // fill array with random values

Console.Clear();

Console.Write("Сгенерированный массив: ");  //data output
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

SortSelectionArray(array); // sorting array

Console.Write("Отсортированный массив: ");  //data output
PrintArray(array);
Console.WriteLine();