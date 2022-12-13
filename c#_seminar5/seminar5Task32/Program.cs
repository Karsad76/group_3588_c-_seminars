// Задача №32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные

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

int[] InverseArray(int[] array)
{
    int lenght = array.Length;
    int[] outArr = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            outArr[i] = array[i] * -1;
        }
    }
    return outArr;
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

int[] array = GenArray(10);
FillArray(array, 0, 100);
int[] outArray = InverseArray(array);
Console.Write("Массив:"); PrintArray(array);
Console.WriteLine();
Console.Write("Инвертированный массив:"); PrintArray(outArray);
