// Задача №37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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
        collection[index] = new Random().Next(0, 10);
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

int[] ConvertArray(int[] array)
{
    int lenght = array.Length;
    int[] outArr = new int[lenght / 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        outArr[i] = array[i] * array[array.Length - 1 - i];
    }
    return outArr;
}


int[] collection = GenArray(20);
FillArray(collection);
PrintArray(collection);
Console.WriteLine();
int[] convertCollection = ConvertArray(collection);
PrintArray(convertCollection);