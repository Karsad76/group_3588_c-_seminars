// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int quat = ReadData("Введите пятизначное число: ");

var palindromHashDict = new Dictionary<int, int>();

void FillDictionary()   // fill dictionary with palindrom hashes method
{
    for (int i = 10; i < 100; i++)
    {
        int palindromHash = (i*100+((i % 10)*10 + i / 10));
        palindromHashDict.Add(i, palindromHash);
    }
}

void PrintDictionary()  // print dictionary method (for test only)
{
    for (int i = 10; i < 100; i++)
    {
        Console.WriteLine(palindromHashDict[i]);
    }
}

FillDictionary();
//PrintDictionary();

if (palindromHashDict.ContainsValue((quat/1000)*100+quat%100) == true)  // check input hash via dictionary
{
    Console.WriteLine ("Введенное число является палиндромом");
}
else
{
    Console.WriteLine ("Введенное число не является палиндромом");
}