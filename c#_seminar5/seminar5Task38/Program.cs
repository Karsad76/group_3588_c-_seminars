// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// * Массив int. Добавить сортировку массива методами вставки, подсчета, "пузырьком". Замерить производительность каждого.

using System;
using System.Diagnostics;

// preparing data
int[] collection = GenArray(100);
FillArray(collection, 0, 100000);
int[] collection1 = (int[])collection.Clone();      // add [collection] clones to measure the performance of sorting algorithms
int[] collection2 = (int[])collection.Clone();      // (for the purity of the experiment)

// executing, measurement and output results
Console.Clear();
Console.WriteLine("Исходный массив");
Console.WriteLine("===============");
PrintArray(collection);
Console.WriteLine(); Console.WriteLine();

StopWatchPerfTest("метод пузырька", collection);        // test performance and print result
StopWatchPerfTest("метод вставки", collection1);
StopWatchPerfTest("метод подсчета", collection2);

PrintData("Разница между максимальным и минимальным элементом массива: ", (collection[collection.Length - 1] - collection[0]));
Console.WriteLine();


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

void StopWatchPerfTest(string msg, int[] arr)   // test performance method
{
    Stopwatch sw1 = new Stopwatch();                                                // stopwatch #1 init
    sw1.Start();                                                                    // making measurement start
    switch (msg)
    {
        case "метод пузырька": BubbleSortArray(arr); break;
        case "метод вставки": InsertionSortArray(arr); break;
        case "метод подсчета": CountingSortArray(arr); break;
        default: break;
    }
    sw1.Stop();                                                                     // making measurement stop
    Console.WriteLine("Отсортированный массив (" + msg + ")");
    Console.WriteLine("=======================================");
    PrintArray(arr); Console.WriteLine("---------------------------------------");
    Console.WriteLine("Время выполнения (" + msg + "): " + sw1.Elapsed);     // print measurement results
    Console.WriteLine(); Console.WriteLine();
}



