// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// (*) вывести пары в массиве в виде: число - позиции на которых встречаются

int[] numbers = GenArray(60);
FillArray(numbers, 0, 10);

Console.WriteLine("Исходный массив");
Console.WriteLine("===============");
PrintArray(numbers);
Console.WriteLine();

PrintData("Сумма элементов на нечетных позициях: ", SumOddPos(numbers));

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

void PrintData(string res, int value)   // print data method
{
    Console.WriteLine(res + value);
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

int SumOddPos(int[] arr)    // method for calculate sum of elements on positions with odd index
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}
