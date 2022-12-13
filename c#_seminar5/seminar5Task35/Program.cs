// Задача №35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
        collection[index] = new Random().Next(-100, 100);
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

int CountElement(int[] array, int min, int max)
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max)
        {
            res++;
        }
    }
    return res;
}

int[] collection = GenArray(123);
FillArray(collection);
Console.WriteLine("Кол-во элементов в диапазоне 10-99: " + CountElement(collection, 10, 99));
