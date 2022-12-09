// Задача №30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenArray(int lenght)  // array generator with given lenght
{
    int[] arr = new int[lenght];  // Определяем массив
    return arr;
}

void FillArray(int[] collection) // random fill array method
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);
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

int inputNum = ReadData("Введите число: "); // input
int[] array = GenArray(inputNum);   //generate array
FillArray(array); // fill array with random
PrintArray(array);

