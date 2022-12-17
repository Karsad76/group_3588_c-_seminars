// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * добавить в программу сортировку массива "пузырьком"

using System;
using System.Diagnostics;

// preparing data
int[] collection = GenArray(60);
FillArray(collection, 100, 1000);
int[] collection2 = (int[])collection.Clone();      // add [collection] clones to measure the performance of sorting algorithms
int[] collection3 = (int[])collection.Clone();      // (for the purity of the experiment)
int[] collection4 = (int[])collection.Clone();

// executing, measurement and output results
Console.WriteLine("Исходный массив");
Console.WriteLine("===============");
PrintArray(collection);
Console.WriteLine();

Stopwatch sw1 = new Stopwatch();                                                // stopwatch #1 init
sw1.Start();                                                                    // making measurement start
BubbleSortArray(collection);
sw1.Stop();                                                                     // making measurement stop
Console.WriteLine("Массив, отсортированный методом \"пузырька\"");
Console.WriteLine("==========================================");
PrintArray(collection); Console.WriteLine();
Console.WriteLine($"Время выполнения (метод \"пузырька\"): {sw1.Elapsed}");     // print measurement results
Console.WriteLine(); Console.WriteLine();

Stopwatch sw2 = new Stopwatch();                                                // stopwatch #2 init
sw2.Start();                                                                    // making measurement start
SelectionSortArray(collection2);
sw2.Stop();                                                                     // making measurement stop
Console.WriteLine("Массив, отсортированный методом выбора");
Console.WriteLine("======================================");
PrintArray(collection2); Console.WriteLine();
Console.WriteLine($"Время выполнения (метод выбора): {sw2.Elapsed}");           // print measurement results
Console.WriteLine(); Console.WriteLine();

Stopwatch sw3 = new Stopwatch();                                                // stopwatch #3 init
sw3.Start();                                                                    // making measurement start
InsertionSortArray(collection3);
sw3.Stop();                                                                     // making measurement stop
Console.WriteLine("Массив, отсортированный методом вставки");
Console.WriteLine("=======================================");
PrintArray(collection3); Console.WriteLine();
Console.WriteLine($"Время выполнения (метод вставки): {sw3.Elapsed}");          // print measurement results
Console.WriteLine(); Console.WriteLine();

Stopwatch sw4 = new Stopwatch();                                                // stopwatch #4 init
sw4.Start();                                                                    // making measurement start
CountingSortArray(collection4);
sw4.Stop();                                                                     // making measurement stop
Console.WriteLine("Массив, отсортированный методом подсчета");
Console.WriteLine("========================================");
PrintArray(collection4); Console.WriteLine();
Console.WriteLine($"Время выполнения (метод подсчета): {sw4.Elapsed}");         // print measurement results
Console.WriteLine(); Console.WriteLine();

// don't forget a simple Task34))
PrintData("Кол-во четных элементов: ", CountEvenElement(collection));

// METHODS
int[] GenArray(int lenght)  // array generator with given lenght
{
    int[] arr = new int[lenght];  // Определяем массив
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

void PrintArray(int[] col)              // print array method
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

int CountEvenElement(int[] array)       // method for finding the number of even array elements
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}

void SelectionSortArray(int[] arr)      // method for selection sort in array 
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

void BubbleSortArray(int[] arr)         // method for bubble sort array
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

void InsertionSortArray(int[] inArray)  // method for insertion sort in array
{
    for (int i = 1; i < inArray.Length; i++)
    {
        int x = inArray[i];
        int j = i;
        while (j > 0 && inArray[j - 1] > x)
        {
            int temp = inArray[j];
            inArray[j] = inArray[j - 1];
            inArray[j - 1] = temp;
            j--;
        }
        inArray[j] = x;
    }
}

void CountingSortArray(int[] inputArray)   //method for counting sort in array
{
    // find a maxValue in inputArray
    int maxValue = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] > maxValue) maxValue = inputArray[i];
    }

    // init array of frequencies
    int[] counts = new int[maxValue + 1];

    // counting the frequencies
    for (int i = 0; i < inputArray.Length; i++)
    {
        counts[inputArray[i]]++;
    }

    // Sort the array
    int index = 0;
    for (int i = 0; i < counts.Length; i++)
    {
        for (int j = 0; j < counts[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

void PrintData(string res, int value)   // print data method
{
    Console.WriteLine(res + value);
}





