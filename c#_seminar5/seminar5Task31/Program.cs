// Задача №31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int positiveSum = 0;
int negativeSum = 0;
int[] testArray = GenArray(12);
FillArray(testArray, -9, 9);
Console.Write("Массив:"); PrintArray(testArray);
Console.WriteLine();

NegativePositiveSumArray(testArray);

PrintData("Сумма положительных значений: ", positiveSum);
PrintData("Сумма отрицательных значений: ", negativeSum);

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

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void NegativePositiveSumArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveSum += arr[i];
        }
        else
        {
            negativeSum += arr[i];
        }
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

