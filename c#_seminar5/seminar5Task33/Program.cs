// Задача №33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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
        collection[index] = new Random().Next(0, 100);
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

int SearchElementInArray(int[] array, int element)
{
    int res = -1;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            res = i;
            break;
        }
    }
    return res;
}

int[] arrayForSearch = GenArray(20);
FillArray(arrayForSearch);
PrintArray(arrayForSearch);
int numberForSearch = ReadData("Введите число для поиска: ");
Console.WriteLine("Число найдено на позиции: " +SearchElementInArray(arrayForSearch, numberForSearch));
