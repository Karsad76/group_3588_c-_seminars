// Задача №39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using System;
using System.Diagnostics;

int minValueForRandom = 0;
int maxValueForRandom = 0;

string inputLine = ReadFromConsole("Введите параметры для генерации массива в виде (длина, минЗначение, максЗначение): ");   //data entry prompt
int[] array1 = CreateArray(inputLine); // generate array
FillArray(array1, minValueForRandom, maxValueForRandom); // fill array with random values

Console.Clear();
                       
//PrintArray (array1);

Stopwatch sw1 = new Stopwatch();                                                // stopwatch #1 init
sw1.Start();
//PrintArray(SwapArray(array1));
SwapArray(array1);
Console.WriteLine();
sw1.Stop();                                                                     // making measurement stop
Console.WriteLine($"Время выполнения MathMethod: {sw1.Elapsed}");               // print measurement results
Console.WriteLine();

Stopwatch sw2 = new Stopwatch();                                                        // stopwatch #2 init
sw2.Start();                                                                            // making measurement start     
//PrintArray(SwapNewArray(array1));
SwapNewArray(array1);
sw2.Stop();                                                                             // making measurement stop
Console.WriteLine($"Время выполнения StringMethod: {sw2.Elapsed}");                     // print measurement results

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
    Console.WriteLine();
}

int[] SwapArray(int[] arr)      // swap array method (pair transit)
{
    int buffer = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        buffer = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = buffer;
    }
    return arr;
}

int[] SwapNewArray(int[] array)     // swap array method (new array)
{
    int[] outArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[array.Length - 1 - i];
    }
    return outArray;
}