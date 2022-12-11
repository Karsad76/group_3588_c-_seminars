// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData(string msg) // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int inputNumber = ReadData("Введите пятизначное число: "); // data entry prompt

Dictionary<int,int> palindromHashDict = new Dictionary<int, int>(); // dictionary init

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

FillDictionary(); // filling dictionary via method
//PrintDictionary(); // for test only

if (palindromHashDict.ContainsValue((inputNumber/1000)*100+inputNumber%100) == true)  // check inputNumber hash via dictionary
{
    Console.WriteLine ("Введенное число "+inputNumber+" - палиндром"); // output if TRUE
}
else
{
    Console.WriteLine ("Введенное число "+inputNumber+" - не палиндром"); // output if FALSE
}